<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchExecuteProcessInstancesRequest;

use AlibabaCloud\Tea\Model;

class taskInfoList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example a171de6c-8bxxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'processInstanceId' => 'processInstanceId',
        'taskId'            => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return taskInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
