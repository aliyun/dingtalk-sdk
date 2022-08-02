<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\generalInvoiceVOList;

use AlibabaCloud\Tea\Model;

class secondHandCarInvoiceDetailList extends Model
{
    /**
     * @description 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 车牌号
     *
     * @var string
     */
    public $cardNo;

    /**
     * @description 通行日期止
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 商品名称
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 税收分类编码
     *
     * @var string
     */
    public $revenueCode;

    /**
     * @description 行号
     *
     * @var string
     */
    public $rowNo;

    /**
     * @description 通行日期起
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 税额
     *
     * @var string
     */
    public $taxAmount;

    /**
     * @description 税率
     *
     * @var string
     */
    public $taxRate;

    /**
     * @description 类型
     *
     * @var string
     */
    public $vehicleType;
    protected $_name = [
        'amount'      => 'amount',
        'cardNo'      => 'cardNo',
        'endDate'     => 'endDate',
        'goodsName'   => 'goodsName',
        'revenueCode' => 'revenueCode',
        'rowNo'       => 'rowNo',
        'startDate'   => 'startDate',
        'taxAmount'   => 'taxAmount',
        'taxRate'     => 'taxRate',
        'vehicleType' => 'vehicleType',
    ];

    public function validate()
    {
    }

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
