<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryOrgInvoiceUrlShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $companyCode;

    /**
     * @var string
     */
    public $invoiceKeyVOListShrink;

    /**
     * @var string
     */
    public $operator;
    protected $_name = [
        'companyCode'            => 'companyCode',
        'invoiceKeyVOListShrink' => 'invoiceKeyVOList',
        'operator'               => 'operator',
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
        if (null !== $this->invoiceKeyVOListShrink) {
            $res['invoiceKeyVOList'] = $this->invoiceKeyVOListShrink;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryOrgInvoiceUrlShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['invoiceKeyVOList'])) {
            $model->invoiceKeyVOListShrink = $map['invoiceKeyVOList'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
