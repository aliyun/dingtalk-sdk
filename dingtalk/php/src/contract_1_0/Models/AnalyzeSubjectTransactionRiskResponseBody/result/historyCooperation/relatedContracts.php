<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation;

use AlibabaCloud\Tea\Model;

class relatedContracts extends Model
{
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
    public $contractType;

    /**
     * @var string
     */
    public $currency;

    /**
     * @var int
     */
    public $endDate;

    /**
     * @var int
     */
    public $startDate;

    /**
     * @var string
     */
    public $transactionDirection;
    protected $_name = [
        'contractAmount' => 'contractAmount',
        'contractId' => 'contractId',
        'contractName' => 'contractName',
        'contractType' => 'contractType',
        'currency' => 'currency',
        'endDate' => 'endDate',
        'startDate' => 'startDate',
        'transactionDirection' => 'transactionDirection',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractAmount) {
            $res['contractAmount'] = $this->contractAmount;
        }
        if (null !== $this->contractId) {
            $res['contractId'] = $this->contractId;
        }
        if (null !== $this->contractName) {
            $res['contractName'] = $this->contractName;
        }
        if (null !== $this->contractType) {
            $res['contractType'] = $this->contractType;
        }
        if (null !== $this->currency) {
            $res['currency'] = $this->currency;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->transactionDirection) {
            $res['transactionDirection'] = $this->transactionDirection;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relatedContracts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractAmount'])) {
            $model->contractAmount = $map['contractAmount'];
        }
        if (isset($map['contractId'])) {
            $model->contractId = $map['contractId'];
        }
        if (isset($map['contractName'])) {
            $model->contractName = $map['contractName'];
        }
        if (isset($map['contractType'])) {
            $model->contractType = $map['contractType'];
        }
        if (isset($map['currency'])) {
            $model->currency = $map['currency'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['transactionDirection'])) {
            $model->transactionDirection = $map['transactionDirection'];
        }

        return $model;
    }
}
