<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @description 消息内容。
     *
     * @var string
     */
    public $message;

    /**
     * @description 消息类型。
     *
     * @var string
     */
    public $messageType;

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
    public $receiverId;

    /**
     * @description 钉外账号在业务系统内的唯一标志。
     *
     * @var string
     */
    public $senderId;

    /**
     * @description 渠道按钮跳转信息。
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
