<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateRequest\invoiceFinanceInfoVOList;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAccountingPeriodDateRequest extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @var invoiceFinanceInfoVOList[]
     */
    public $invoiceFinanceInfoVOList;

    /**
     * @example 1234567
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'companyCode' => 'companyCode',
        'invoiceFinanceInfoVOList' => 'invoiceFinanceInfoVOList',
        'operator' => 'operator',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->invoiceFinanceInfoVOList) {
            $res['invoiceFinanceInfoVOList'] = [];
            if (null !== $this->invoiceFinanceInfoVOList && \is_array($this->invoiceFinanceInfoVOList)) {
                $n = 0;
                foreach ($this->invoiceFinanceInfoVOList as $item) {
                    $res['invoiceFinanceInfoVOList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return UpdateInvoiceAccountingPeriodDateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['invoiceFinanceInfoVOList'])) {
            if (!empty($map['invoiceFinanceInfoVOList'])) {
                $model->invoiceFinanceInfoVOList = [];
                $n = 0;
                foreach ($map['invoiceFinanceInfoVOList'] as $item) {
                    $model->invoiceFinanceInfoVOList[$n++] = null !== $item ? invoiceFinanceInfoVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
