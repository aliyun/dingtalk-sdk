<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotMessageResponseBody extends Model
{
    /**
     * @var string
     */
    public $openMsgId;
    protected $_name = [
        'openMsgId' => 'openMsgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }

        return $model;
    }
}
