<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class RedirectWorkflowTaskRequest extends Model
{
    /**
     * @description 操作节点名
     *
     * @var string
     */
    public $actionName;

    /**
     * @description 操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description 转交备注信息
     *
     * @var string
     */
    public $remark;

    /**
     * @description OA审批任务ID
     *
     * @var int
     */
    public $taskId;

    /**
     * @description OA审批任务被转交对象的用户ID
     *
     * @var string
     */
    public $toUserId;
    protected $_name = [
        'actionName'    => 'actionName',
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
