<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveRobotFromConversationRequest extends Model
{
    /**
     * @description 机器人在会话里的id
     *
     * @var string
     */
    public $chatBotUserId;

    /**
     * @description 会话id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'chatBotUserId'      => 'chatBotUserId',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatBotUserId) {
            $res['chatBotUserId'] = $this->chatBotUserId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveRobotFromConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatBotUserId'])) {
            $model->chatBotUserId = $map['chatBotUserId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
