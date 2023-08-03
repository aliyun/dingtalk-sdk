<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInvoiceVoucherStatusRequest extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @example ADD/DELETE
     *
     * @var string
     */
    public $actionType;

    /**
     * @example abc
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @example 11011023488
     *
     * @var string
     */
    public $operator;

    /**
     * @example abc
     *
     * @var string
     */
    public $voucherId;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'actionType'       => 'actionType',
        'invoiceCode'      => 'invoiceCode',
        'invoiceNo'        => 'invoiceNo',
        'operator'         => 'operator',
        'voucherId'        => 'voucherId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->voucherId) {
            $res['voucherId'] = $this->voucherId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceVoucherStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['voucherId'])) {
            $model->voucherId = $map['voucherId'];
        }

        return $model;
    }
}
