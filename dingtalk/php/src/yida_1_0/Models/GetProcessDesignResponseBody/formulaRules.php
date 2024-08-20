<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody\formulaRules\name;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody\formulaRules\rule;
use AlibabaCloud\Tea\Model;

class formulaRules extends Model
{
    /**
     * @var string[]
     */
    public $activityAction;

    /**
     * @var string[]
     */
    public $activityId;

    /**
     * @example n
     *
     * @var string
     */
    public $block;

    /**
     * @example xxx
     *
     * @var string
     */
    public $message;

    /**
     * @var name
     */
    public $name;

    /**
     * @example START
     *
     * @var string
     */
    public $nodeType;

    /**
     * @var rule
     */
    public $rule;

    /**
     * @example VALIDATOR
     *
     * @var string
     */
    public $ruleType;

    /**
     * @example null
     *
     * @var string
     */
    public $triggerMode;
    protected $_name = [
        'activityAction' => 'activityAction',
        'activityId'     => 'activityId',
        'block'          => 'block',
        'message'        => 'message',
        'name'           => 'name',
        'nodeType'       => 'nodeType',
        'rule'           => 'rule',
        'ruleType'       => 'ruleType',
        'triggerMode'    => 'triggerMode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityAction) {
            $res['activityAction'] = $this->activityAction;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->block) {
            $res['block'] = $this->block;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->nodeType) {
            $res['nodeType'] = $this->nodeType;
        }
        if (null !== $this->rule) {
            $res['rule'] = null !== $this->rule ? $this->rule->toMap() : null;
        }
        if (null !== $this->ruleType) {
            $res['ruleType'] = $this->ruleType;
        }
        if (null !== $this->triggerMode) {
            $res['triggerMode'] = $this->triggerMode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formulaRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityAction'])) {
            if (!empty($map['activityAction'])) {
                $model->activityAction = $map['activityAction'];
            }
        }
        if (isset($map['activityId'])) {
            if (!empty($map['activityId'])) {
                $model->activityId = $map['activityId'];
            }
        }
        if (isset($map['block'])) {
            $model->block = $map['block'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['nodeType'])) {
            $model->nodeType = $map['nodeType'];
        }
        if (isset($map['rule'])) {
            $model->rule = rule::fromMap($map['rule']);
        }
        if (isset($map['ruleType'])) {
            $model->ruleType = $map['ruleType'];
        }
        if (isset($map['triggerMode'])) {
            $model->triggerMode = $map['triggerMode'];
        }

        return $model;
    }
}
