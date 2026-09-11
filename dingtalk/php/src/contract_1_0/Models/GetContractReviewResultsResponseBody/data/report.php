<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\report\allIssues;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\report\summary;
use AlibabaCloud\Tea\Model;

class report extends Model
{
    /**
     * @var allIssues[]
     */
    public $allIssues;

    /**
     * @var string
     */
    public $conclusion;

    /**
     * @var string[]
     */
    public $crossClauseFindings;

    /**
     * @var string[]
     */
    public $deterministicFindings;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var string
     */
    public $generatedAt;

    /**
     * @var string[]
     */
    public $missingClauses;

    /**
     * @var string
     */
    public $reviewId;

    /**
     * @var string[]
     */
    public $riskIssues;

    /**
     * @var summary
     */
    public $summary;

    /**
     * @var string
     */
    public $version;
    protected $_name = [
        'allIssues' => 'all_issues',
        'conclusion' => 'conclusion',
        'crossClauseFindings' => 'cross_clause_findings',
        'deterministicFindings' => 'deterministic_findings',
        'fileName' => 'file_name',
        'generatedAt' => 'generated_at',
        'missingClauses' => 'missing_clauses',
        'reviewId' => 'review_id',
        'riskIssues' => 'risk_issues',
        'summary' => 'summary',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allIssues) {
            $res['all_issues'] = [];
            if (null !== $this->allIssues && \is_array($this->allIssues)) {
                $n = 0;
                foreach ($this->allIssues as $item) {
                    $res['all_issues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->conclusion) {
            $res['conclusion'] = $this->conclusion;
        }
        if (null !== $this->crossClauseFindings) {
            $res['cross_clause_findings'] = $this->crossClauseFindings;
        }
        if (null !== $this->deterministicFindings) {
            $res['deterministic_findings'] = $this->deterministicFindings;
        }
        if (null !== $this->fileName) {
            $res['file_name'] = $this->fileName;
        }
        if (null !== $this->generatedAt) {
            $res['generated_at'] = $this->generatedAt;
        }
        if (null !== $this->missingClauses) {
            $res['missing_clauses'] = $this->missingClauses;
        }
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->riskIssues) {
            $res['risk_issues'] = $this->riskIssues;
        }
        if (null !== $this->summary) {
            $res['summary'] = null !== $this->summary ? $this->summary->toMap() : null;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return report
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['all_issues'])) {
            if (!empty($map['all_issues'])) {
                $model->allIssues = [];
                $n = 0;
                foreach ($map['all_issues'] as $item) {
                    $model->allIssues[$n++] = null !== $item ? allIssues::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conclusion'])) {
            $model->conclusion = $map['conclusion'];
        }
        if (isset($map['cross_clause_findings'])) {
            if (!empty($map['cross_clause_findings'])) {
                $model->crossClauseFindings = $map['cross_clause_findings'];
            }
        }
        if (isset($map['deterministic_findings'])) {
            if (!empty($map['deterministic_findings'])) {
                $model->deterministicFindings = $map['deterministic_findings'];
            }
        }
        if (isset($map['file_name'])) {
            $model->fileName = $map['file_name'];
        }
        if (isset($map['generated_at'])) {
            $model->generatedAt = $map['generated_at'];
        }
        if (isset($map['missing_clauses'])) {
            if (!empty($map['missing_clauses'])) {
                $model->missingClauses = $map['missing_clauses'];
            }
        }
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['risk_issues'])) {
            if (!empty($map['risk_issues'])) {
                $model->riskIssues = $map['risk_issues'];
            }
        }
        if (isset($map['summary'])) {
            $model->summary = summary::fromMap($map['summary']);
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
