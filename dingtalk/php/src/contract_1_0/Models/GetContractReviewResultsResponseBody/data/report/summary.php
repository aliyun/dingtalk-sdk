<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\report;

use AlibabaCloud\Tea\Model;

class summary extends Model
{
    /**
     * @var string
     */
    public $contractType;

    /**
     * @var int
     */
    public $crossClauseCount;

    /**
     * @var int
     */
    public $deterministicCount;

    /**
     * @var int
     */
    public $formalHintCount;

    /**
     * @var int
     */
    public $hardIssueCount;

    /**
     * @var int
     */
    public $high;

    /**
     * @var int
     */
    public $issueCount;

    /**
     * @var int
     */
    public $low;

    /**
     * @var int
     */
    public $medium;

    /**
     * @var int
     */
    public $missingClauseCount;

    /**
     * @var string
     */
    public $overallRiskLevel;

    /**
     * @var int
     */
    public $riskIssueCount;

    /**
     * @var string
     */
    public $scale;

    /**
     * @var string
     */
    public $standpoint;
    protected $_name = [
        'contractType' => 'contract_type',
        'crossClauseCount' => 'cross_clause_count',
        'deterministicCount' => 'deterministic_count',
        'formalHintCount' => 'formal_hint_count',
        'hardIssueCount' => 'hard_issue_count',
        'high' => 'high',
        'issueCount' => 'issue_count',
        'low' => 'low',
        'medium' => 'medium',
        'missingClauseCount' => 'missing_clause_count',
        'overallRiskLevel' => 'overall_risk_level',
        'riskIssueCount' => 'risk_issue_count',
        'scale' => 'scale',
        'standpoint' => 'standpoint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractType) {
            $res['contract_type'] = $this->contractType;
        }
        if (null !== $this->crossClauseCount) {
            $res['cross_clause_count'] = $this->crossClauseCount;
        }
        if (null !== $this->deterministicCount) {
            $res['deterministic_count'] = $this->deterministicCount;
        }
        if (null !== $this->formalHintCount) {
            $res['formal_hint_count'] = $this->formalHintCount;
        }
        if (null !== $this->hardIssueCount) {
            $res['hard_issue_count'] = $this->hardIssueCount;
        }
        if (null !== $this->high) {
            $res['high'] = $this->high;
        }
        if (null !== $this->issueCount) {
            $res['issue_count'] = $this->issueCount;
        }
        if (null !== $this->low) {
            $res['low'] = $this->low;
        }
        if (null !== $this->medium) {
            $res['medium'] = $this->medium;
        }
        if (null !== $this->missingClauseCount) {
            $res['missing_clause_count'] = $this->missingClauseCount;
        }
        if (null !== $this->overallRiskLevel) {
            $res['overall_risk_level'] = $this->overallRiskLevel;
        }
        if (null !== $this->riskIssueCount) {
            $res['risk_issue_count'] = $this->riskIssueCount;
        }
        if (null !== $this->scale) {
            $res['scale'] = $this->scale;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return summary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contract_type'])) {
            $model->contractType = $map['contract_type'];
        }
        if (isset($map['cross_clause_count'])) {
            $model->crossClauseCount = $map['cross_clause_count'];
        }
        if (isset($map['deterministic_count'])) {
            $model->deterministicCount = $map['deterministic_count'];
        }
        if (isset($map['formal_hint_count'])) {
            $model->formalHintCount = $map['formal_hint_count'];
        }
        if (isset($map['hard_issue_count'])) {
            $model->hardIssueCount = $map['hard_issue_count'];
        }
        if (isset($map['high'])) {
            $model->high = $map['high'];
        }
        if (isset($map['issue_count'])) {
            $model->issueCount = $map['issue_count'];
        }
        if (isset($map['low'])) {
            $model->low = $map['low'];
        }
        if (isset($map['medium'])) {
            $model->medium = $map['medium'];
        }
        if (isset($map['missing_clause_count'])) {
            $model->missingClauseCount = $map['missing_clause_count'];
        }
        if (isset($map['overall_risk_level'])) {
            $model->overallRiskLevel = $map['overall_risk_level'];
        }
        if (isset($map['risk_issue_count'])) {
            $model->riskIssueCount = $map['risk_issue_count'];
        }
        if (isset($map['scale'])) {
            $model->scale = $map['scale'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }

        return $model;
    }
}
