<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSceneGroupResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example chatxxxxxx
     *
     * @var string
     */
    public $chatId;

    /**
     * @description This parameter is required.
     *
     * @example cidxxxxxx==
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'chatId' => 'chat_id',
        'openConversationId' => 'open_conversation_id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatId) {
            $res['chat_id'] = $this->chatId;
        }
        if (null !== $this->openConversationId) {
            $res['open_conversation_id'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSceneGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chat_id'])) {
            $model->chatId = $map['chat_id'];
        }
        if (isset($map['open_conversation_id'])) {
            $model->openConversationId = $map['open_conversation_id'];
        }

        return $model;
    }
}
