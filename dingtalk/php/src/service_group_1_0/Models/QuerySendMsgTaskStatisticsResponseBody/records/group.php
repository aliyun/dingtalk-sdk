<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponseBody\records;

use AlibabaCloud\Tea\Model;

class group extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $groupName;

    /**
     * @var string
     */
    public $groupSetName;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $openGroupSetId;

    /**
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'bizId'              => 'bizId',
        'groupName'          => 'groupName',
        'groupSetName'       => 'groupSetName',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupSetName) {
            $res['groupSetName'] = $this->groupSetName;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return group
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupSetName'])) {
            $model->groupSetName = $map['groupSetName'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
