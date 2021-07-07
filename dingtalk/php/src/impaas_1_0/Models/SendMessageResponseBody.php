<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageResponseBody extends Model
{
    /**
     * @var string
     */
    public $msgId;

    /**
     * @var int
     */
    public $createTime;
    protected $_name = [
        'msgId'      => 'msgId',
        'createTime' => 'createTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
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
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }

        return $model;
    }
}
