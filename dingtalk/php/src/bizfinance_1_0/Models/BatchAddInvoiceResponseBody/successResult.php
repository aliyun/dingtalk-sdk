<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceResponseBody;

use AlibabaCloud\Tea\Model;

class successResult extends Model
{
    /**
     * @var string
     */
    public $invoiceCode;

    /**
     * @var string
     */
    public $invoiceNo;
    protected $_name = [
        'invoiceCode' => 'invoiceCode',
        'invoiceNo'   => 'invoiceNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return successResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }

        return $model;
    }
}
