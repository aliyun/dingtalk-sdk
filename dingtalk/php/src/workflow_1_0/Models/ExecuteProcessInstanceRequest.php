<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ExecuteProcessInstanceRequest\file;
use AlibabaCloud\Tea\Model;

class ExecuteProcessInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 133743186427339452
     *
     * @var string
     */
    public $actionerUserId;

    /**
     * @var file
     */
    public $file;

    /**
     * @description This parameter is required.
     *
     * @example a171de6c-8bxxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 同意。
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example agree
     *
     * @var string
     */
    public $result;

    /**
     * @description This parameter is required.
     *
     * @example 67583405630
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'actionerUserId'    => 'actionerUserId',
        'file'              => 'file',
        'processInstanceId' => 'processInstanceId',
        'remark'            => 'remark',
        'result'            => 'result',
        'taskId'            => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionerUserId) {
            $res['actionerUserId'] = $this->actionerUserId;
        }
        if (null !== $this->file) {
            $res['file'] = null !== $this->file ? $this->file->toMap() : null;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteProcessInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionerUserId'])) {
            $model->actionerUserId = $map['actionerUserId'];
        }
        if (isset($map['file'])) {
            $model->file = file::fromMap($map['file']);
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
