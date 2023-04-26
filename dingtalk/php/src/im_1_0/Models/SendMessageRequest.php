<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @example {"msg_type":"text","text":"hello world"}
     *
     * @var string
     */
    public $message;

    /**
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
     * @example 1745****8777
     *
     * @var string
     */
    public $receiverId;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $senderId;

    /**
     * @example {     "9d801647a64******59c9da0207":"[{\"action_url\":\"http://www.baidu.com\",\"title\":\"一个按钮\"},{\"action_url\":\"http://www.baidu.com\",\"title\":\"两个按钮\"}]",     "9d801647a6******59c9da020342":"[{\"action_url\":\"http://www.baidu.com\",\"title\":\"一个按钮\"},{\"action_url\":\"http://www.baidu.com\",\"title\":\"两个按钮\"}]" }
     *
     * @var mixed[]
     */
    public $sourceInfos;
    protected $_name = [
        'message'            => 'message',
        'messageType'        => 'messageType',
        'openConversationId' => 'openConversationId',
        'receiverId'         => 'receiverId',
        'senderId'           => 'senderId',
        'sourceInfos'        => 'sourceInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->sourceInfos) {
            $res['sourceInfos'] = $this->sourceInfos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['sourceInfos'])) {
            $model->sourceInfos = $map['sourceInfos'];
        }

        return $model;
    }
}
