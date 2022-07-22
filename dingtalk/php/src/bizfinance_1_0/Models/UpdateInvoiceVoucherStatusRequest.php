<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInvoiceVoucherStatusRequest extends Model
{
    /**
     * @description 操作类型
     *
     * @var string
     */
    public $actionType;

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
     * @description 操作员
     *
     * @var string
     */
    public $operator;

    /**
     * @description 凭证id
     *
     * @var string
     */
    public $voucherId;
    protected $_name = [
        'actionType'  => 'actionType',
        'invoiceCode' => 'invoiceCode',
        'invoiceNo'   => 'invoiceNo',
        'operator'    => 'operator',
        'voucherId'   => 'voucherId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
