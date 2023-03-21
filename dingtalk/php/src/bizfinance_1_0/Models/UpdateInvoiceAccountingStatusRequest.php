<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusRequest\invoiceFinanceInfoVOList;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAccountingStatusRequest extends Model
{
    /**
     * @description 发票财务模型列表
     *
     * @var invoiceFinanceInfoVOList[]
     */
    public $invoiceFinanceInfoVOList;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'invoiceFinanceInfoVOList' => 'invoiceFinanceInfoVOList',
        'operator'                 => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return UpdateInvoiceAccountingStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoiceFinanceInfoVOList'])) {
            if (!empty($map['invoiceFinanceInfoVOList'])) {
                $model->invoiceFinanceInfoVOList = [];
                $n                               = 0;
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
