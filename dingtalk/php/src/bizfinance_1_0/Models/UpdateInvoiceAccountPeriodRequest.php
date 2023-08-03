<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodRequest\generalInvoiceVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountPeriodRequest\invoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAccountPeriodRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountPeriod;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

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
    protected $_name = [
        'accountPeriod'        => 'accountPeriod',
        'companyCode'          => 'companyCode',
        'generalInvoiceVOList' => 'generalInvoiceVOList',
        'invoiceKeyVOList'     => 'invoiceKeyVOList',
        'operator'             => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountPeriod) {
            $res['accountPeriod'] = $this->accountPeriod;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAccountPeriodRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountPeriod'])) {
            $model->accountPeriod = $map['accountPeriod'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
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

        return $model;
    }
}
