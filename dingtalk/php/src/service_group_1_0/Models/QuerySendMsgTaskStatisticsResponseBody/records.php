<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponseBody\records\group;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponseBody\records\groupUserReadStatistics;
use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @var string
     */
    public $errorDetail;

    /**
     * @var group
     */
    public $group;

    /**
     * @var groupUserReadStatistics
     */
    public $groupUserReadStatistics;

    /**
     * @var string
     */
    public $openMsgId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'errorDetail'             => 'errorDetail',
        'group'                   => 'group',
        'groupUserReadStatistics' => 'groupUserReadStatistics',
        'openMsgId'               => 'openMsgId',
        'status'                  => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorDetail) {
            $res['errorDetail'] = $this->errorDetail;
        }
        if (null !== $this->group) {
            $res['group'] = null !== $this->group ? $this->group->toMap() : null;
        }
        if (null !== $this->groupUserReadStatistics) {
            $res['groupUserReadStatistics'] = null !== $this->groupUserReadStatistics ? $this->groupUserReadStatistics->toMap() : null;
        }
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorDetail'])) {
            $model->errorDetail = $map['errorDetail'];
        }
        if (isset($map['group'])) {
            $model->group = group::fromMap($map['group']);
        }
        if (isset($map['groupUserReadStatistics'])) {
            $model->groupUserReadStatistics = groupUserReadStatistics::fromMap($map['groupUserReadStatistics']);
        }
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
