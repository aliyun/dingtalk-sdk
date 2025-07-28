<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendDingMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $code;

    /**
     * @description This parameter is required.
     *
     * @example {"msg_type":"text","text":"hello world"}
     *
     * @var string
     */
    public $message;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $messageType;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $receiverId;

    /**
     * @description This parameter is required.
     *
     * @example 1745****8777
     *
     * @var string
     */
    public $senderId;
    protected $_name = [
        'code' => 'code',
        'message' => 'message',
        'messageType' => 'messageType',
        'openConversationId' => 'openConversationId',
        'receiverId' => 'receiverId',
        'senderId' => 'senderId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiverId) {
            $res['receiverId'] = $this->receiverId;
        }
        if (null !== $this->senderId) {
            $res['senderId'] = $this->senderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendDingMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiverId'])) {
            $model->receiverId = $map['receiverId'];
        }
        if (isset($map['senderId'])) {
            $model->senderId = $map['senderId'];
        }

        return $model;
    }
}
