<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveRobotFromConversationResponseBody extends Model
{
    /**
     * @description Id of the request
     *
     * @var string
     */
    public $chatBotUserId;
    protected $_name = [
        'chatBotUserId' => 'chatBotUserId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveRobotFromConversationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatBotUserId'])) {
            $model->chatBotUserId = $map['chatBotUserId'];
        }

        return $model;
    }
}
