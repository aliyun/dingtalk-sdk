<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1107****2120
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description This parameter is required.
     *
     * @example oK4e****qER2
     *
     * @var string
     */
    public $channelCode;

    /**
     * @example 123**789
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example f67b****8a0f
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1745****8777
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId'          => 'appUserId',
        'channelCode'        => 'channelCode',
        'deviceId'           => 'deviceId',
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
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
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
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
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
