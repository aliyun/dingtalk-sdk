<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateChatSendRequest extends Model
{
    /**
     * @description 酷应用的code
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 消息类型的key
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description 消息体
     *
     * @var string
     */
    public $msgParam;

    /**
     * @description 开放会话ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 机器人robotCode
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'coolAppCode'        => 'coolAppCode',
        'msgKey'             => 'msgKey',
        'msgParam'           => 'msgParam',
        'openConversationId' => 'openConversationId',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateChatSendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
