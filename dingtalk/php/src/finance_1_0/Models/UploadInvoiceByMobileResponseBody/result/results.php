<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByMobileResponseBody\result;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 20006
     *
     * @var string
     */
    public $errCode;

    /**
     * @description This parameter is required.
     *
     * @example 033002000712
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description This parameter is required.
     *
     * @example 20532643
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description This parameter is required.
     *
     * @example duplicateInvoice
     *
     * @var string
     */
    public $reason;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'errCode' => 'errCode',
        'invoiceCode' => 'invoiceCode',
        'invoiceNo' => 'invoiceNo',
        'reason' => 'reason',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errCode) {
            $res['errCode'] = $this->errCode;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return results
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errCode'])) {
            $model->errCode = $map['errCode'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
