<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class JoinGroupSetResponseBody extends Model
{
    /**
     * @description 加密群ID。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description chatId
     *
     * @var string
     */
    public $chatId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'chatId'             => 'chatId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->chatId) {
            $res['chatId'] = $this->chatId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return JoinGroupSetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['chatId'])) {
            $model->chatId = $map['chatId'];
        }

        return $model;
    }
}
