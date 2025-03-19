<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractReviewTaskRequest;

use AlibabaCloud\Tea\Model;

class reviewCustomRules extends Model
{
    /**
     * @example high
     *
     * @var string
     */
    public $riskLevel;

    /**
     * @example 审查合同金额大小，不得低于1000元
     *
     * @var string
     */
    public $ruleDesc;

    /**
     * @example 1.1
     *
     * @var string
     */
    public $ruleSequence;

    /**
     * @example 金额相关规则
     *
     * @var string
     */
    public $ruleTag;

    /**
     * @example 合同金额校验
     *
     * @var string
     */
    public $ruleTitle;
    protected $_name = [
        'riskLevel' => 'riskLevel',
        'ruleDesc' => 'ruleDesc',
        'ruleSequence' => 'ruleSequence',
        'ruleTag' => 'ruleTag',
        'ruleTitle' => 'ruleTitle',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->riskLevel) {
            $res['riskLevel'] = $this->riskLevel;
        }
        if (null !== $this->ruleDesc) {
            $res['ruleDesc'] = $this->ruleDesc;
        }
        if (null !== $this->ruleSequence) {
            $res['ruleSequence'] = $this->ruleSequence;
        }
        if (null !== $this->ruleTag) {
            $res['ruleTag'] = $this->ruleTag;
        }
        if (null !== $this->ruleTitle) {
            $res['ruleTitle'] = $this->ruleTitle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reviewCustomRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['riskLevel'])) {
            $model->riskLevel = $map['riskLevel'];
        }
        if (isset($map['ruleDesc'])) {
            $model->ruleDesc = $map['ruleDesc'];
        }
        if (isset($map['ruleSequence'])) {
            $model->ruleSequence = $map['ruleSequence'];
        }
        if (isset($map['ruleTag'])) {
            $model->ruleTag = $map['ruleTag'];
        }
        if (isset($map['ruleTitle'])) {
            $model->ruleTitle = $map['ruleTitle'];
        }

        return $model;
    }
}
