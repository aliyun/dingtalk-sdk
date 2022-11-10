<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskResponseBody\task;
use AlibabaCloud\Tea\Model;

class GetTaskResponseBody extends Model
{
    /**
     * @description 任务信息
     *
     * @var task
     */
    public $task;
    protected $_name = [
        'task' => 'task',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->task) {
            $res['task'] = null !== $this->task ? $this->task->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['task'])) {
            $model->task = task::fromMap($map['task']);
        }

        return $model;
    }
}
