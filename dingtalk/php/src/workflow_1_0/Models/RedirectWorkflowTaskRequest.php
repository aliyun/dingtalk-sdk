<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\RedirectWorkflowTaskRequest\file;
use AlibabaCloud\Tea\Model;

class RedirectWorkflowTaskRequest extends Model
{
    /**
     * @example test
     *
     * @var string
     */
    public $actionName;

    /**
     * @var file
     */
    public $file;

    /**
     * @description This parameter is required.
     *
     * @example manager001
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @example 请XX帮忙审批一下
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var int
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example manager001
     *
     * @var string
     */
    public $toUserId;
    protected $_name = [
        'actionName'    => 'actionName',
        'file'          => 'file',
        'operateUserId' => 'operateUserId',
        'remark'        => 'remark',
        'taskId'        => 'taskId',
        'toUserId'      => 'toUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->file) {
            $res['file'] = null !== $this->file ? $this->file->toMap() : null;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->toUserId) {
            $res['toUserId'] = $this->toUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RedirectWorkflowTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['file'])) {
            $model->file = file::fromMap($map['file']);
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['toUserId'])) {
            $model->toUserId = $map['toUserId'];
        }

        return $model;
    }
}
