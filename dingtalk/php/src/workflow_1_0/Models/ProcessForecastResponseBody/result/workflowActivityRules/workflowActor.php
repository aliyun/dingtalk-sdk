<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange;
use AlibabaCloud\Tea\Model;

class workflowActor extends Model
{
    /**
     * @description 节点激活类型
     *
     * @var string
     */
    public $actorActivateType;

    /**
     * @description 节点操作人 key
     *
     * @var string
     */
    public $actorKey;

    /**
     * @description 节点操作人选择范围
     *
     * @var actorSelectionRange
     */
    public $actorSelectionRange;

    /**
     * @description 节点操作人选择范围类型
     *
     * @var string
     */
    public $actorSelectionType;

    /**
     * @description 节点操作人类型
     *
     * @var string
     */
    public $actorType;

    /**
     * @description 是否允许多选，还是仅允许选一人
     *
     * @var bool
     */
    public $allowedMulti;

    /**
     * @description 节点审批方式
     *
     * @var string
     */
    public $approvalMethod;

    /**
     * @description 节点审批类型
     *
     * @var string
     */
    public $approvalType;

    /**
     * @description 该审批人节点在发起审批时是否必填
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
