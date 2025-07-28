<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\generalInvoiceVOList;

use AlibabaCloud\Tea\Model;

class secondHandCarInvoiceDetailList extends Model
{
    /**
     * @var string
     */
    public $amount;

    /**
     * @var string
     */
    public $cardNo;

    /**
     * @var string
     */
    public $endDate;

    /**
     * @var string
     */
    public $goodsName;

    /**
     * @var string
     */
    public $revenueCode;

    /**
     * @var string
     */
    public $rowNo;

    /**
     * @var string
     */
    public $startDate;

    /**
     * @var string
     */
    public $taxAmount;

    /**
     * @var string
     */
    public $taxRate;

    /**
     * @var string
     */
    public $vehicleType;
    protected $_name = [
        'amount' => 'amount',
        'cardNo' => 'cardNo',
        'endDate' => 'endDate',
        'goodsName' => 'goodsName',
        'revenueCode' => 'revenueCode',
        'rowNo' => 'rowNo',
        'startDate' => 'startDate',
        'taxAmount' => 'taxAmount',
        'taxRate' => 'taxRate',
        'vehicleType' => 'vehicleType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->cardNo) {
            $res['cardNo'] = $this->cardNo;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->revenueCode) {
            $res['revenueCode'] = $this->revenueCode;
        }
        if (null !== $this->rowNo) {
            $res['rowNo'] = $this->rowNo;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->vehicleType) {
            $res['vehicleType'] = $this->vehicleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return secondHandCarInvoiceDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['cardNo'])) {
            $model->cardNo = $map['cardNo'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['revenueCode'])) {
            $model->revenueCode = $map['revenueCode'];
        }
        if (isset($map['rowNo'])) {
            $model->rowNo = $map['rowNo'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['vehicleType'])) {
            $model->vehicleType = $map['vehicleType'];
        }

        return $model;
    }
}
