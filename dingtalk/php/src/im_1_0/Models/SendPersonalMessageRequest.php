<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendPersonalMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example {"content":"月会通知<@all> ","at":{"atUserIds":[],"isAtAll":true}}
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @example cidc4iLyQBuHFQRvzxznz204Q==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1662055829854977
     *
     * @var string
     */
    public $receiverUserId;
    protected $_name = [
        'content' => 'content',
        'msgType' => 'msgType',
        'openConversationId' => 'openConversationId',
        'receiverUserId' => 'receiverUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendPersonalMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }

        return $model;
    }
}
