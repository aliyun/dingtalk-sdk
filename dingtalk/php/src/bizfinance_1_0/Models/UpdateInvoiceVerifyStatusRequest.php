<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\generalInvoiceVOList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceVerifyStatusRequest\invoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceVerifyStatusRequest extends Model
{
    /**
     * @description 抵扣状态
     *
     *
     * @var string
     */
    public $deductStatus;

    /**
     * @description 发票模型
     *
     * @var generalInvoiceVOList[]
     */
    public $generalInvoiceVOList;

    /**
     * @description 待更新
     *
     * @var invoiceKeyVOList[]
     */
    public $invoiceKeyVOList;

    /**
     * @description 操作员
     *
     * @var string
     */
    public $operator;

    /**
     * @description 认证状态
     *
     * @var string
     */
    public $verifyStatus;
    protected $_name = [
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
