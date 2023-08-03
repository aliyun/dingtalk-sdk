<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\generalInvoiceVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\invoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceVerifyStatusRequest extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example DEDUCTED
     *
     * @var string
     */
    public $deductStatus;

    /**
     * @var generalInvoiceVOList[]
     */
    public $generalInvoiceVOList;

    /**
     * @var invoiceKeyVOList[]
     */
    public $invoiceKeyVOList;

    /**
     * @example abc
     *
     * @var string
     */
    public $operator;

    /**
     * @example abc
     *
     * @var string
     */
    public $verifyStatus;
    protected $_name = [
        'companyCode'          => 'companyCode',
        'deductStatus'         => 'deductStatus',
        'generalInvoiceVOList' => 'generalInvoiceVOList',
        'invoiceKeyVOList'     => 'invoiceKeyVOList',
        'operator'             => 'operator',
        'verifyStatus'         => 'verifyStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->deductStatus) {
            $res['deductStatus'] = $this->deductStatus;
        }
        if (null !== $this->generalInvoiceVOList) {
            $res['generalInvoiceVOList'] = [];
            if (null !== $this->generalInvoiceVOList && \is_array($this->generalInvoiceVOList)) {
                $n = 0;
                foreach ($this->generalInvoiceVOList as $item) {
                    $res['generalInvoiceVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->invoiceKeyVOList) {
            $res['invoiceKeyVOList'] = [];
            if (null !== $this->invoiceKeyVOList && \is_array($this->invoiceKeyVOList)) {
                $n = 0;
                foreach ($this->invoiceKeyVOList as $item) {
                    $res['invoiceKeyVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->verifyStatus) {
            $res['verifyStatus'] = $this->verifyStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceVerifyStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['deductStatus'])) {
            $model->deductStatus = $map['deductStatus'];
        }
        if (isset($map['generalInvoiceVOList'])) {
            if (!empty($map['generalInvoiceVOList'])) {
                $model->generalInvoiceVOList = [];
                $n                           = 0;
                foreach ($map['generalInvoiceVOList'] as $item) {
                    $model->generalInvoiceVOList[$n++] = null !== $item ? generalInvoiceVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['invoiceKeyVOList'])) {
            if (!empty($map['invoiceKeyVOList'])) {
                $model->invoiceKeyVOList = [];
                $n                       = 0;
                foreach ($map['invoiceKeyVOList'] as $item) {
                    $model->invoiceKeyVOList[$n++] = null !== $item ? invoiceKeyVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['verifyStatus'])) {
            $model->verifyStatus = $map['verifyStatus'];
        }

        return $model;
    }
}
