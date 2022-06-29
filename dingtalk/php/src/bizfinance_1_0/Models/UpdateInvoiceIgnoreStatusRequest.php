<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceIgnoreStatusRequest\generalInvoiceVO;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceIgnoreStatusRequest extends Model
{
    /**
     * @description 发票全票面信息
     *
     * @var generalInvoiceVO
     */
    public $generalInvoiceVO;

    /**
     * @description 发票编码
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
     * @description 发票状态
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'generalInvoiceVO' => 'generalInvoiceVO',
        'invoiceCode'      => 'invoiceCode',
        'invoiceNo'        => 'invoiceNo',
        'status'           => 'status',
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceIgnoreStatusRequest
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
