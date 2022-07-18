<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedResponseBody\invoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UpdateApplyReceiptAndInvoiceRelatedResponseBody extends Model
{
    /**
     * @description 失败发票列表list
     *
     * @var invoiceKeyVOList[]
     */
    public $invoiceKeyVOList;
    protected $_name = [
        'invoiceKeyVOList' => 'invoiceKeyVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceKeyVOList) {
            $res['invoiceKeyVOList'] = [];
            if (null !== $this->invoiceKeyVOList && \is_array($this->invoiceKeyVOList)) {
                $n = 0;
                foreach ($this->invoiceKeyVOList as $item) {
                    $res['invoiceKeyVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApplyReceiptAndInvoiceRelatedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoiceKeyVOList'])) {
            if (!empty($map['invoiceKeyVOList'])) {
                $model->invoiceKeyVOList = [];
                $n                       = 0;
                foreach ($map['invoiceKeyVOList'] as $item) {
                    $model->invoiceKeyVOList[$n++] = null !== $item ? invoiceKeyVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
