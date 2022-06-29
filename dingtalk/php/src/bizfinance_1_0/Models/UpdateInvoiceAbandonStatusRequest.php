<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\blueGeneralInvoiceVO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\redGeneralInvoiceVO;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAbandonStatusRequest extends Model
{
    /**
     * @description 发票全票面信息（蓝票）
     *
     * @var blueGeneralInvoiceVO
     */
    public $blueGeneralInvoiceVO;

    /**
     * @description 发票编码（蓝票）
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description 发票号码（蓝票）
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description 发票全票面信息（红票）
     *
     * @var redGeneralInvoiceVO
     */
    public $redGeneralInvoiceVO;

    /**
     * @description 状态-红冲、废弃
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'blueGeneralInvoiceVO' => 'blueGeneralInvoiceVO',
        'invoiceCode'          => 'invoiceCode',
        'invoiceNo'            => 'invoiceNo',
        'redGeneralInvoiceVO'  => 'redGeneralInvoiceVO',
        'status'               => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blueGeneralInvoiceVO) {
            $res['blueGeneralInvoiceVO'] = null !== $this->blueGeneralInvoiceVO ? $this->blueGeneralInvoiceVO->toMap() : null;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->redGeneralInvoiceVO) {
            $res['redGeneralInvoiceVO'] = null !== $this->redGeneralInvoiceVO ? $this->redGeneralInvoiceVO->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAbandonStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blueGeneralInvoiceVO'])) {
            $model->blueGeneralInvoiceVO = blueGeneralInvoiceVO::fromMap($map['blueGeneralInvoiceVO']);
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['redGeneralInvoiceVO'])) {
            $model->redGeneralInvoiceVO = redGeneralInvoiceVO::fromMap($map['redGeneralInvoiceVO']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
