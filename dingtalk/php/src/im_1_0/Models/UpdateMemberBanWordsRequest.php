<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMemberBanWordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 300000
     *
     * @var int
     */
    public $muteDuration;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $muteStatus;

    /**
     * @description This parameter is required.
     *
     * @example cid5d5uM3XEw3gxbNc/n7EQ4g==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
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
