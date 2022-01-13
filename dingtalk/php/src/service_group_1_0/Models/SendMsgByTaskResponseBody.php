<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMsgByTaskResponseBody extends Model
{
    /**
     * @description Id of the request
     *
     * @var string
     */
    public $openBatchTaskId;
    protected $_name = [
        'openBatchTaskId' => 'openBatchTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMsgByTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }

        return $model;
    }
}
