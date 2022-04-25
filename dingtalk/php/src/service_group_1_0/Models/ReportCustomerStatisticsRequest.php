<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReportCustomerStatisticsRequest extends Model
{
    /**
     * @description 群主列表
     *
     * @var string[]
     */
    public $groupOwnerUserIds;

    /**
     * @description 群标签列表
     *
     * @var string[]
     */
    public $groupTags;

    /**
     * @description 截止日期
     *
     * @var string
     */
    public $maxDt;

    /**
     * @description 起始日期
     *
     * @var string
     */
    public $minDt;

    /**
     * @description 开放群id列表
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @description 开放群组id
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 开发团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页大小
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'groupOwnerUserIds'   => 'groupOwnerUserIds',
        'groupTags'           => 'groupTags',
        'maxDt'               => 'maxDt',
        'minDt'               => 'minDt',
        'openConversationIds' => 'openConversationIds',
        'openGroupSetId'      => 'openGroupSetId',
        'openTeamId'          => 'openTeamId',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupOwnerUserIds) {
            $res['groupOwnerUserIds'] = $this->groupOwnerUserIds;
        }
        if (null !== $this->groupTags) {
            $res['groupTags'] = $this->groupTags;
        }
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReportCustomerStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupOwnerUserIds'])) {
            if (!empty($map['groupOwnerUserIds'])) {
                $model->groupOwnerUserIds = $map['groupOwnerUserIds'];
            }
        }
        if (isset($map['groupTags'])) {
            if (!empty($map['groupTags'])) {
                $model->groupTags = $map['groupTags'];
            }
        }
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
