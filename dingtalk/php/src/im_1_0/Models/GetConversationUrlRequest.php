<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationUrlRequest extends Model
{
    /**
     * @description C端用户在业务账号体系内的用户userid，长度限制为1~64个字符。
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description C端客户渠道code。
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
     * @description C端客户标识。
     *
     * @var string
     */
    public $sourceCode;

    /**
     * @description B端用户的钉钉userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId'          => 'appUserId',
        'channelCode'        => 'channelCode',
        'openConversationId' => 'openConversationId',
        'sourceCode'         => 'sourceCode',
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
        if (null !== $this->sourceCode) {
            $res['sourceCode'] = $this->sourceCode;
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
        if (isset($map['sourceCode'])) {
            $model->sourceCode = $map['sourceCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
