<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusResponseBody\result;

use AlibabaCloud\Tea\Model;

class failInvoices extends Model
{
    /**
     * @example 50001
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example invoice not exist
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @example 123123123
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example 123123123123
     *
     * @var string
     */
    public $invoiceNo;
    protected $_name = [
        'errorCode'   => 'errorCode',
        'errorMsg'    => 'errorMsg',
        'invoiceCode' => 'invoiceCode',
        'invoiceNo'   => 'invoiceNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failInvoices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }

        return $model;
    }
}
