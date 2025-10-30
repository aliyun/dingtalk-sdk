<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageResponseBody extends Model
{
    /**
     * @var string
     */
    public $errmsg;

    /**
     * @example 0
     *
     * @var string
     */
    public $errorcode;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'errmsg' => 'errmsg',
        'errorcode' => 'errorcode',
        'taskId' => 'task_id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errmsg) {
            $res['errmsg'] = $this->errmsg;
        }
        if (null !== $this->errorcode) {
            $res['errorcode'] = $this->errorcode;
        }
        if (null !== $this->taskId) {
            $res['task_id'] = $this->taskId;
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
        if (isset($map['errmsg'])) {
            $model->errmsg = $map['errmsg'];
        }
        if (isset($map['errorcode'])) {
            $model->errorcode = $map['errorcode'];
        }
        if (isset($map['task_id'])) {
            $model->taskId = $map['task_id'];
        }

        return $model;
    }
}
