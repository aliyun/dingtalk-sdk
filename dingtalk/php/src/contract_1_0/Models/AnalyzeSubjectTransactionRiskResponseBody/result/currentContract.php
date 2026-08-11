<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result;

use AlibabaCloud\Tea\Model;

class currentContract extends Model
{
    /**
     * @var string
     */
    public $acceptanceTerms;

    /**
     * @var string
     */
    public $breachLiability;

    /**
     * @var string
     */
    public $contractAmount;

    /**
     * @var int
     */
    public $contractId;

    /**
     * @var string
     */
    public $contractName;

    /**
     * @var string
     */
    public $contractSubject;

    /**
     * @var string
     */
    public $contractType;

    /**
     * @var int
     */
    public $contractVersion;

    /**
     * @var string
     */
    public $currency;

    /**
     * @var string
     */
    public $dataStatus;

    /**
     * @var string
     */
    public $deliveryTerms;

    /**
     * @var string
     */
    public $disputeResolution;

    /**
     * @var string
     */
    public $guaranteeTerms;

    /**
     * @var string[]
     */
    public $missingFields;

    /**
     * @var string
     */
    public $paymentTerms;

    /**
     * @var string
     */
    public $performancePeriod;

    /**
     * @var string
     */
    public $terminationTerms;

    /**
     * @var string
     */
    public $transactionDirection;
    protected $_name = [
        'acceptanceTerms' => 'acceptanceTerms',
        'breachLiability' => 'breachLiability',
        'contractAmount' => 'contractAmount',
        'contractId' => 'contractId',
        'contractName' => 'contractName',
        'contractSubject' => 'contractSubject',
        'contractType' => 'contractType',
        'contractVersion' => 'contractVersion',
        'currency' => 'currency',
        'dataStatus' => 'dataStatus',
        'deliveryTerms' => 'deliveryTerms',
        'disputeResolution' => 'disputeResolution',
        'guaranteeTerms' => 'guaranteeTerms',
        'missingFields' => 'missingFields',
        'paymentTerms' => 'paymentTerms',
        'performancePeriod' => 'performancePeriod',
        'terminationTerms' => 'terminationTerms',
        'transactionDirection' => 'transactionDirection',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->acceptanceTerms) {
            $res['acceptanceTerms'] = $this->acceptanceTerms;
        }
        if (null !== $this->breachLiability) {
            $res['breachLiability'] = $this->breachLiability;
        }
        if (null !== $this->contractAmount) {
            $res['contractAmount'] = $this->contractAmount;
        }
        if (null !== $this->contractId) {
            $res['contractId'] = $this->contractId;
        }
        if (null !== $this->contractName) {
            $res['contractName'] = $this->contractName;
        }
        if (null !== $this->contractSubject) {
            $res['contractSubject'] = $this->contractSubject;
        }
        if (null !== $this->contractType) {
            $res['contractType'] = $this->contractType;
        }
        if (null !== $this->contractVersion) {
            $res['contractVersion'] = $this->contractVersion;
        }
        if (null !== $this->currency) {
            $res['currency'] = $this->currency;
        }
        if (null !== $this->dataStatus) {
            $res['dataStatus'] = $this->dataStatus;
        }
        if (null !== $this->deliveryTerms) {
            $res['deliveryTerms'] = $this->deliveryTerms;
        }
        if (null !== $this->disputeResolution) {
            $res['disputeResolution'] = $this->disputeResolution;
        }
        if (null !== $this->guaranteeTerms) {
            $res['guaranteeTerms'] = $this->guaranteeTerms;
        }
        if (null !== $this->missingFields) {
            $res['missingFields'] = $this->missingFields;
        }
        if (null !== $this->paymentTerms) {
            $res['paymentTerms'] = $this->paymentTerms;
        }
        if (null !== $this->performancePeriod) {
            $res['performancePeriod'] = $this->performancePeriod;
        }
        if (null !== $this->terminationTerms) {
            $res['terminationTerms'] = $this->terminationTerms;
        }
        if (null !== $this->transactionDirection) {
            $res['transactionDirection'] = $this->transactionDirection;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return currentContract
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['acceptanceTerms'])) {
            $model->acceptanceTerms = $map['acceptanceTerms'];
        }
        if (isset($map['breachLiability'])) {
            $model->breachLiability = $map['breachLiability'];
        }
        if (isset($map['contractAmount'])) {
            $model->contractAmount = $map['contractAmount'];
        }
        if (isset($map['contractId'])) {
            $model->contractId = $map['contractId'];
        }
        if (isset($map['contractName'])) {
            $model->contractName = $map['contractName'];
        }
        if (isset($map['contractSubject'])) {
            $model->contractSubject = $map['contractSubject'];
        }
        if (isset($map['contractType'])) {
            $model->contractType = $map['contractType'];
        }
        if (isset($map['contractVersion'])) {
            $model->contractVersion = $map['contractVersion'];
        }
        if (isset($map['currency'])) {
            $model->currency = $map['currency'];
        }
        if (isset($map['dataStatus'])) {
            $model->dataStatus = $map['dataStatus'];
        }
        if (isset($map['deliveryTerms'])) {
            $model->deliveryTerms = $map['deliveryTerms'];
        }
        if (isset($map['disputeResolution'])) {
            $model->disputeResolution = $map['disputeResolution'];
        }
        if (isset($map['guaranteeTerms'])) {
            $model->guaranteeTerms = $map['guaranteeTerms'];
        }
        if (isset($map['missingFields'])) {
            if (!empty($map['missingFields'])) {
                $model->missingFields = $map['missingFields'];
            }
        }
        if (isset($map['paymentTerms'])) {
            $model->paymentTerms = $map['paymentTerms'];
        }
        if (isset($map['performancePeriod'])) {
            $model->performancePeriod = $map['performancePeriod'];
        }
        if (isset($map['terminationTerms'])) {
            $model->terminationTerms = $map['terminationTerms'];
        }
        if (isset($map['transactionDirection'])) {
            $model->transactionDirection = $map['transactionDirection'];
        }

        return $model;
    }
}
