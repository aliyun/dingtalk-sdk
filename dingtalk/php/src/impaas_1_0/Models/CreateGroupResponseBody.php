<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupResponseBody extends Model
{
    /**
     * @var string
     */
    public $conversationId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $chatId;
    protected $_name = [
        'conversationId' => 'conversationId',
        'createTime'     => 'createTime',
        'chatId'         => 'chatId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->chatId) {
            $res['chatId'] = $this->chatId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['chatId'])) {
            $model->chatId = $map['chatId'];
        }

        return $model;
    }
}
