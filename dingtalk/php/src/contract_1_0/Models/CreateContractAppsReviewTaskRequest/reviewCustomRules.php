<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsReviewTaskRequest;

use AlibabaCloud\Tea\Model;

class reviewCustomRules extends Model
{
    /**
     * @var string
     */
    public $riskLevel;

    /**
     * @var string
     */
    public $ruleDesc;

    /**
     * @var string
     */
    public $ruleSequence;

    /**
     * @var string
     */
    public $ruleTag;

    /**
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
