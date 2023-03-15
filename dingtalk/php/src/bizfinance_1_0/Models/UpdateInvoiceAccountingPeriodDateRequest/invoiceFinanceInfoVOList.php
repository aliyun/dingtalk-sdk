<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateRequest;

use AlibabaCloud\Tea\Model;

class invoiceFinanceInfoVOList extends Model
{
    /**
     * @description 入账日期
     *
     * @var string
     */
    public $accountingPeriodData;

    /**
     * @description 发票代码
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description 发票号码
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description 发票类型
     *
     * @var string
     */
    public $invoiceType;
    protected $_name = [
        'accountingPeriodData' => 'accountingPeriodData',
        'invoiceCode'          => 'invoiceCode',
        'invoiceNo'            => 'invoiceNo',
        'invoiceType'          => 'invoiceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountingPeriodData) {
            $res['accountingPeriodData'] = $this->accountingPeriodData;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return invoiceFinanceInfoVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountingPeriodData'])) {
            $model->accountingPeriodData = $map['accountingPeriodData'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }

        return $model;
    }
}
