<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\report;

use AlibabaCloud\Tea\Model;

class allIssues extends Model
{
    /**
     * @var bool
     */
    public $builtin;

    /**
     * @var string
     */
    public $checkType;

    /**
     * @var string
     */
    public $clauseLocation;

    /**
     * @var string
     */
    public $clauseQuote;

    /**
     * @var bool
     */
    public $custom;

    /**
     * @var string
     */
    public $fallback;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $impact;

    /**
     * @var string
     */
    public $legalBasis;

    /**
     * @var string
     */
    public $pack;

    /**
     * @var string
     */
    public $practiceReference;

    /**
     * @var string
     */
    public $problem;

    /**
     * @var string
     */
    public $revisionText;

    /**
     * @var string
     */
    public $riskLevel;

    /**
     * @var string
     */
    public $ruleName;

    /**
     * @var string
     */
    public $source;

    /**
     * @var string
     */
    public $suggestion;

    /**
     * @var string
     */
    public $tier;
    protected $_name = [
        'builtin' => 'builtin',
        'checkType' => 'check_type',
        'clauseLocation' => 'clause_location',
        'clauseQuote' => 'clause_quote',
        'custom' => 'custom',
        'fallback' => 'fallback',
        'id' => 'id',
        'impact' => 'impact',
        'legalBasis' => 'legal_basis',
        'pack' => 'pack',
        'practiceReference' => 'practice_reference',
        'problem' => 'problem',
        'revisionText' => 'revision_text',
        'riskLevel' => 'riskLevel',
        'ruleName' => 'rule_name',
        'source' => 'source',
        'suggestion' => 'suggestion',
        'tier' => 'tier',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->builtin) {
            $res['builtin'] = $this->builtin;
        }
        if (null !== $this->checkType) {
            $res['check_type'] = $this->checkType;
        }
        if (null !== $this->clauseLocation) {
            $res['clause_location'] = $this->clauseLocation;
        }
        if (null !== $this->clauseQuote) {
            $res['clause_quote'] = $this->clauseQuote;
        }
        if (null !== $this->custom) {
            $res['custom'] = $this->custom;
        }
        if (null !== $this->fallback) {
            $res['fallback'] = $this->fallback;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->impact) {
            $res['impact'] = $this->impact;
        }
        if (null !== $this->legalBasis) {
            $res['legal_basis'] = $this->legalBasis;
        }
        if (null !== $this->pack) {
            $res['pack'] = $this->pack;
        }
        if (null !== $this->practiceReference) {
            $res['practice_reference'] = $this->practiceReference;
        }
        if (null !== $this->problem) {
            $res['problem'] = $this->problem;
        }
        if (null !== $this->revisionText) {
            $res['revision_text'] = $this->revisionText;
        }
        if (null !== $this->riskLevel) {
            $res['riskLevel'] = $this->riskLevel;
        }
        if (null !== $this->ruleName) {
            $res['rule_name'] = $this->ruleName;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->suggestion) {
            $res['suggestion'] = $this->suggestion;
        }
        if (null !== $this->tier) {
            $res['tier'] = $this->tier;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return allIssues
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['builtin'])) {
            $model->builtin = $map['builtin'];
        }
        if (isset($map['check_type'])) {
            $model->checkType = $map['check_type'];
        }
        if (isset($map['clause_location'])) {
            $model->clauseLocation = $map['clause_location'];
        }
        if (isset($map['clause_quote'])) {
            $model->clauseQuote = $map['clause_quote'];
        }
        if (isset($map['custom'])) {
            $model->custom = $map['custom'];
        }
        if (isset($map['fallback'])) {
            $model->fallback = $map['fallback'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['impact'])) {
            $model->impact = $map['impact'];
        }
        if (isset($map['legal_basis'])) {
            $model->legalBasis = $map['legal_basis'];
        }
        if (isset($map['pack'])) {
            $model->pack = $map['pack'];
        }
        if (isset($map['practice_reference'])) {
            $model->practiceReference = $map['practice_reference'];
        }
        if (isset($map['problem'])) {
            $model->problem = $map['problem'];
        }
        if (isset($map['revision_text'])) {
            $model->revisionText = $map['revision_text'];
        }
        if (isset($map['riskLevel'])) {
            $model->riskLevel = $map['riskLevel'];
        }
        if (isset($map['rule_name'])) {
            $model->ruleName = $map['rule_name'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['suggestion'])) {
            $model->suggestion = $map['suggestion'];
        }
        if (isset($map['tier'])) {
            $model->tier = $map['tier'];
        }

        return $model;
    }
}
