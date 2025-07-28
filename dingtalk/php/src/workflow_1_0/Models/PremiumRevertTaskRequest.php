<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumRevertTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example manager001
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description This parameter is required.
     *
     * @example processInstanceId123
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 退回到审批人（上一步）
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example REVERT_FOR_APPROVAL
     *
     * @var string
     */
    public $revertAction;

    /**
     * @description This parameter is required.
     *
     * @example d3aa_1974
     *
     * @var string
     */
    public $targetActivityId;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'operateUserId' => 'operateUserId',
        'processInstanceId' => 'processInstanceId',
        'remark' => 'remark',
        'revertAction' => 'revertAction',
        'targetActivityId' => 'targetActivityId',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->revertAction) {
            $res['revertAction'] = $this->revertAction;
        }
        if (null !== $this->targetActivityId) {
            $res['targetActivityId'] = $this->targetActivityId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumRevertTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['revertAction'])) {
            $model->revertAction = $map['revertAction'];
        }
        if (isset($map['targetActivityId'])) {
            $model->targetActivityId = $map['targetActivityId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
