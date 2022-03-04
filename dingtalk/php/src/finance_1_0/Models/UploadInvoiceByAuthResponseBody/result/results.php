<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthResponseBody\result;

use AlibabaCloud\Tea\Model;

class results extends Model
{
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
     * @description 是否成功
     *
     * @var bool
     */
    public $success;

    /**
     * @description 失败原因
     *
     * @var string
     */
    public $reason;

    /**
     * @description 业务错误码
     *
     * @var string
     */
    public $errCode;
    protected $_name = [
        'invoiceCode' => 'invoiceCode',
        'invoiceNo'   => 'invoiceNo',
        'success'     => 'success',
        'reason'      => 'reason',
        'errCode'     => 'errCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->errCode) {
            $res['errCode'] = $this->errCode;
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
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['errCode'])) {
            $model->errCode = $map['errCode'];
        }

        return $model;
    }
}
