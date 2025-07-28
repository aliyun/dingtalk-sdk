<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOpenConversationReceiveUserRequest extends Model
{
    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $sendUserId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'sendUserId' => 'sendUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->sendUserId) {
            $res['sendUserId'] = $this->sendUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOpenConversationReceiveUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['sendUserId'])) {
            $model->sendUserId = $map['sendUserId'];
        }

        return $model;
    }
}
