<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange;
use AlibabaCloud\Tea\Model;

class workflowActor extends Model
{
    /**
     * @example ALL:并行，ONE_BY_ONE:串行
     *
     * @var string
     */
    public $actorActivateType;

    /**
     * @example manual_e203_14a3_895a_45ad
     *
     * @var string
     */
    public $actorKey;

    /**
     * @var actorSelectionRange
     */
    public $actorSelectionRange;

    /**
     * @example allStaff：全公司，approvals：指定成员，labels：角色
     *
     * @var string
     */
    public $actorSelectionType;

    /**
     * @example approver:审批人，notifier:抄送人，audit：办理人
     *
     * @var string
     */
    public $actorType;

    /**
     * @example true
     *
     * @var bool
     */
    public $allowedMulti;

    /**
     * @example ONE_BY_ONE：依次审批，AND：会签审批，OR：或签审批
     *
     * @var string
     */
    public $approvalMethod;

    /**
     * @example MANUAL:人工审批，AUTO_AGREE:自动通过，AUTO_REFUSE:自动拒绝
     *
     * @var string
     */
    public $approvalType;

    /**
     * @example true
     *
     * @var bool
     */
    public $required;
    protected $_name = [
        'actorActivateType'   => 'actorActivateType',
        'actorKey'            => 'actorKey',
        'actorSelectionRange' => 'actorSelectionRange',
        'actorSelectionType'  => 'actorSelectionType',
        'actorType'           => 'actorType',
        'allowedMulti'        => 'allowedMulti',
        'approvalMethod'      => 'approvalMethod',
        'approvalType'        => 'approvalType',
        'required'            => 'required',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actorActivateType) {
            $res['actorActivateType'] = $this->actorActivateType;
        }
        if (null !== $this->actorKey) {
            $res['actorKey'] = $this->actorKey;
        }
        if (null !== $this->actorSelectionRange) {
            $res['actorSelectionRange'] = null !== $this->actorSelectionRange ? $this->actorSelectionRange->toMap() : null;
        }
        if (null !== $this->actorSelectionType) {
            $res['actorSelectionType'] = $this->actorSelectionType;
        }
        if (null !== $this->actorType) {
            $res['actorType'] = $this->actorType;
        }
        if (null !== $this->allowedMulti) {
            $res['allowedMulti'] = $this->allowedMulti;
        }
        if (null !== $this->approvalMethod) {
            $res['approvalMethod'] = $this->approvalMethod;
        }
        if (null !== $this->approvalType) {
            $res['approvalType'] = $this->approvalType;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workflowActor
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actorActivateType'])) {
            $model->actorActivateType = $map['actorActivateType'];
        }
        if (isset($map['actorKey'])) {
            $model->actorKey = $map['actorKey'];
        }
        if (isset($map['actorSelectionRange'])) {
            $model->actorSelectionRange = actorSelectionRange::fromMap($map['actorSelectionRange']);
        }
        if (isset($map['actorSelectionType'])) {
            $model->actorSelectionType = $map['actorSelectionType'];
        }
        if (isset($map['actorType'])) {
            $model->actorType = $map['actorType'];
        }
        if (isset($map['allowedMulti'])) {
            $model->allowedMulti = $map['allowedMulti'];
        }
        if (isset($map['approvalMethod'])) {
            $model->approvalMethod = $map['approvalMethod'];
        }
        if (isset($map['approvalType'])) {
            $model->approvalType = $map['approvalType'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }

        return $model;
    }
}
