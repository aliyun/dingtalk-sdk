<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusRequest;

use AlibabaCloud\Tea\Model;

class invoiceFinanceInfoVOList extends Model
{
    /**
     * @example in_account
     *
     * @var string
     */
    public $accountingStatus;

    /**
     * @example 2022002022
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example 20022
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @example VAT_DIGITAL_NORMAL
     *
     * @var string
     */
    public $invoiceType;
    protected $_name = [
        'accountingStatus' => 'accountingStatus',
        'invoiceCode' => 'invoiceCode',
        'invoiceNo' => 'invoiceNo',
        'invoiceType' => 'invoiceType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountingStatus) {
            $res['accountingStatus'] = $this->accountingStatus;
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
        if (isset($map['accountingStatus'])) {
            $model->accountingStatus = $map['accountingStatus'];
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
