<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationIdRequest extends Model
{
    /**
     * @var string
     */
    public $chatId;
    protected $_name = [
        'chatId' => 'chatId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatId) {
            $res['chatId'] = $this->chatId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConversationIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatId'])) {
            $model->chatId = $map['chatId'];
        }

        return $model;
    }
}
