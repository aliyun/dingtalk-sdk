<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UnbindApplyReceiptAndInvoiceRelatedRequest\invoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UnbindApplyReceiptAndInvoiceRelatedRequest extends Model
{
    /**
     * @description 审批单id
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 发票模型
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
    protected $_name = [
        'instanceId'       => 'instanceId',
        'invoiceKeyVOList' => 'invoiceKeyVOList',
        'operator'         => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
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
     * @return UnbindApplyReceiptAndInvoiceRelatedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
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
