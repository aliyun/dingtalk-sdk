<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceRequest;

use AlibabaCloud\Tea\Model;

class invoiceFilter extends Model
{
    /**
     * @description 发票类型 进项、销项
     *
     * @var string
     */
    public $financeType;

    /**
     * @description 发票状态列表
     *
     * @var string[]
     */
    public $relationStatus;
    protected $_name = [
        'financeType'    => 'financeType',
        'relationStatus' => 'relationStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->financeType) {
            $res['financeType'] = $this->financeType;
        }
        if (null !== $this->relationStatus) {
            $res['relationStatus'] = $this->relationStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return invoiceFilter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['financeType'])) {
            $model->financeType = $map['financeType'];
        }
        if (isset($map['relationStatus'])) {
            if (!empty($map['relationStatus'])) {
                $model->relationStatus = $map['relationStatus'];
            }
        }

        return $model;
    }
}
