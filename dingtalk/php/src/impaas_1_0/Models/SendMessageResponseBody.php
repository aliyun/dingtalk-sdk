<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $messageId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $msgId;
    protected $_name = [
        'createTime' => 'createTime',
        'messageId'  => 'messageId',
        'msgId'      => 'msgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }

        return $model;
    }
}
