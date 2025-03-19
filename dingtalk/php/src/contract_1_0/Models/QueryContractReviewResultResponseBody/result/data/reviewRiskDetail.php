<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractReviewResultResponseBody\result\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractReviewResultResponseBody\result\data\reviewRiskDetail\subRisks;
use AlibabaCloud\Tea\Model;

class reviewRiskDetail extends Model
{
    /**
     * @var string
     */
    public $examineBrief;

    /**
     * @var string
     */
    public $examineResult;

    /**
     * @var string
     */
    public $examineStatus;

    /**
     * @var string
     */
    public $riskLevel;

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

    /**
     * @var subRisks[]
     */
    public $subRisks;
    protected $_name = [
        'examineBrief' => 'examineBrief',
        'examineResult' => 'examineResult',
        'examineStatus' => 'examineStatus',
        'riskLevel' => 'riskLevel',
        'ruleSequence' => 'ruleSequence',
        'ruleTag' => 'ruleTag',
        'ruleTitle' => 'ruleTitle',
        'subRisks' => 'subRisks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->examineBrief) {
            $res['examineBrief'] = $this->examineBrief;
        }
        if (null !== $this->examineResult) {
            $res['examineResult'] = $this->examineResult;
        }
        if (null !== $this->examineStatus) {
            $res['examineStatus'] = $this->examineStatus;
        }
        if (null !== $this->riskLevel) {
            $res['riskLevel'] = $this->riskLevel;
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
        if (null !== $this->subRisks) {
            $res['subRisks'] = [];
            if (null !== $this->subRisks && \is_array($this->subRisks)) {
                $n = 0;
                foreach ($this->subRisks as $item) {
                    $res['subRisks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reviewRiskDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['examineBrief'])) {
            $model->examineBrief = $map['examineBrief'];
        }
        if (isset($map['examineResult'])) {
            $model->examineResult = $map['examineResult'];
        }
        if (isset($map['examineStatus'])) {
            $model->examineStatus = $map['examineStatus'];
        }
        if (isset($map['riskLevel'])) {
            $model->riskLevel = $map['riskLevel'];
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
        if (isset($map['subRisks'])) {
            if (!empty($map['subRisks'])) {
                $model->subRisks = [];
                $n = 0;
                foreach ($map['subRisks'] as $item) {
                    $model->subRisks[$n++] = null !== $item ? subRisks::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
