<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMemberBanWordsRequest extends Model
{
    /**
     * @description 禁言持续时长（单位：毫秒）
     *
     * @var int
     */
    public $muteDuration;

    /**
     * @description 禁言状态(0表示取消禁言，1表示禁言)
     *
     * @var int
     */
    public $muteStatus;

    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 需要禁言或取消禁言的群成员列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'muteDuration'       => 'muteDuration',
        'muteStatus'         => 'muteStatus',
        'openConversationId' => 'openConversationId',
        'userIdList'         => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->muteDuration) {
            $res['muteDuration'] = $this->muteDuration;
        }
        if (null !== $this->muteStatus) {
            $res['muteStatus'] = $this->muteStatus;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMemberBanWordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['muteDuration'])) {
            $model->muteDuration = $map['muteDuration'];
        }
        if (isset($map['muteStatus'])) {
            $model->muteStatus = $map['muteStatus'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
