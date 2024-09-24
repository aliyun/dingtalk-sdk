<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList;
use AlibabaCloud\Tea\Model;

class BatchAddInvoiceRequest extends Model
{
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
     * @example abc
     *
     * @var string
     */
    public $operator;

    /**
     * @example XXX
     *
     * @var string
     */
    public $orderId;

    /**
     * @example APPROVAL
     *
     * @var string
     */
    public $source;
    protected $_name = [
        'companyCode'          => 'companyCode',
        'generalInvoiceVOList' => 'generalInvoiceVOList',
        'operator'             => 'operator',
        'orderId'              => 'orderId',
        'source'               => 'source',
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
        if (null !== $this->generalInvoiceVOList) {
            $res['generalInvoiceVOList'] = [];
            if (null !== $this->generalInvoiceVOList && \is_array($this->generalInvoiceVOList)) {
                $n = 0;
                foreach ($this->generalInvoiceVOList as $item) {
                    $res['generalInvoiceVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchAddInvoiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
