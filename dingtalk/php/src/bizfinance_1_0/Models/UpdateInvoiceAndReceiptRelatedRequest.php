<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAndReceiptRelatedRequest extends Model
{
    /**
     * @description 发票全票面信息
     *
     * @var generalInvoiceVO
     */
    public $generalInvoiceVO;

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
     * @description 操作员
     *
     * @var string
     */
    public $operator;

    /**
     * @description 钉钉审批单号
     *
     * @var string
     */
    public $receiptCode;
    protected $_name = [
        'generalInvoiceVO' => 'generalInvoiceVO',
        'invoiceCode'      => 'invoiceCode',
        'invoiceNo'        => 'invoiceNo',
        'operator'         => 'operator',
        'receiptCode'      => 'receiptCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->generalInvoiceVO) {
            $res['generalInvoiceVO'] = null !== $this->generalInvoiceVO ? $this->generalInvoiceVO->toMap() : null;
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
        if (null !== $this->receiptCode) {
            $res['receiptCode'] = $this->receiptCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAndReceiptRelatedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['generalInvoiceVO'])) {
            $model->generalInvoiceVO = generalInvoiceVO::fromMap($map['generalInvoiceVO']);
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
        if (isset($map['receiptCode'])) {
            $model->receiptCode = $map['receiptCode'];
        }

        return $model;
    }
}
