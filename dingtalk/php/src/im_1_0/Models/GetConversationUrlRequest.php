<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationUrlRequest extends Model
{
    /**
     * @description 钉外账号在业务系统内的唯一标志。
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description 渠道code。
     *
     * @var string
     */
    public $channelCode;

    /**
     * @description 群会话Id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 钉内账号userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId'          => 'appUserId',
        'channelCode'        => 'channelCode',
        'openConversationId' => 'openConversationId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConversationUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
