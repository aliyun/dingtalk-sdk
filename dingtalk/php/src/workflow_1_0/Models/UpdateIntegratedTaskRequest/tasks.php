<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskRequest;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @example AGREE
     *
     * @var string
     */
    public $result;

    /**
     * @description This parameter is required.
     *
     * @example COMPLETED
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'result' => 'result',
        'status' => 'status',
        'taskId' => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
