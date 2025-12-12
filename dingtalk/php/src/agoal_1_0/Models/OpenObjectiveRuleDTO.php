<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenObjectiveRuleDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var OpenObjectiveRuleScopeDTO[]
     */
    public $excludePopRuleView;

    /**
     * @description This parameter is required.
     *
     * @example OKR / PBC
     *
     * @var string
     */
    public $objectiveCategory;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $objectiveRuleId;

    /**
     * @description This parameter is required.
     *
     * @example 规则
     *
     * @var string
     */
    public $objectiveRuleName;

    /**
     * @description This parameter is required.
     *
     * @var OpenObjectiveRulePeriodDTO[]
     */
    public $periods;

    /**
     * @description This parameter is required.
     *
     * @var OpenObjectiveRuleScopeDTO[]
     */
    public $popRuleView;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $probationRule;

    /**
     * @description This parameter is required.
     *
     * @example ONLINE
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'excludePopRuleView' => 'excludePopRuleView',
        'objectiveCategory' => 'objectiveCategory',
        'objectiveRuleId' => 'objectiveRuleId',
        'objectiveRuleName' => 'objectiveRuleName',
        'periods' => 'periods',
        'popRuleView' => 'popRuleView',
        'probationRule' => 'probationRule',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->excludePopRuleView) {
            $res['excludePopRuleView'] = [];
            if (null !== $this->excludePopRuleView && \is_array($this->excludePopRuleView)) {
                $n = 0;
                foreach ($this->excludePopRuleView as $item) {
                    $res['excludePopRuleView'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->objectiveCategory) {
            $res['objectiveCategory'] = $this->objectiveCategory;
        }
        if (null !== $this->objectiveRuleId) {
            $res['objectiveRuleId'] = $this->objectiveRuleId;
        }
        if (null !== $this->objectiveRuleName) {
            $res['objectiveRuleName'] = $this->objectiveRuleName;
        }
        if (null !== $this->periods) {
            $res['periods'] = [];
            if (null !== $this->periods && \is_array($this->periods)) {
                $n = 0;
                foreach ($this->periods as $item) {
                    $res['periods'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->popRuleView) {
            $res['popRuleView'] = [];
            if (null !== $this->popRuleView && \is_array($this->popRuleView)) {
                $n = 0;
                foreach ($this->popRuleView as $item) {
                    $res['popRuleView'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->probationRule) {
            $res['probationRule'] = $this->probationRule;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenObjectiveRuleDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['excludePopRuleView'])) {
            if (!empty($map['excludePopRuleView'])) {
                $model->excludePopRuleView = [];
                $n = 0;
                foreach ($map['excludePopRuleView'] as $item) {
                    $model->excludePopRuleView[$n++] = null !== $item ? OpenObjectiveRuleScopeDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['objectiveCategory'])) {
            $model->objectiveCategory = $map['objectiveCategory'];
        }
        if (isset($map['objectiveRuleId'])) {
            $model->objectiveRuleId = $map['objectiveRuleId'];
        }
        if (isset($map['objectiveRuleName'])) {
            $model->objectiveRuleName = $map['objectiveRuleName'];
        }
        if (isset($map['periods'])) {
            if (!empty($map['periods'])) {
                $model->periods = [];
                $n = 0;
                foreach ($map['periods'] as $item) {
                    $model->periods[$n++] = null !== $item ? OpenObjectiveRulePeriodDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['popRuleView'])) {
            if (!empty($map['popRuleView'])) {
                $model->popRuleView = [];
                $n = 0;
                foreach ($map['popRuleView'] as $item) {
                    $model->popRuleView[$n++] = null !== $item ? OpenObjectiveRuleScopeDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['probationRule'])) {
            $model->probationRule = $map['probationRule'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
