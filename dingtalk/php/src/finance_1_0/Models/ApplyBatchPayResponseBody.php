<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyBatchPayResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 20210909153300000002734753314700
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description This parameter is required.
     *
     * @example payData
     *
     * @var string
     */
    public $payData;
    protected $_name = [
        'orderNo' => 'orderNo',
        'payData' => 'payData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->payData) {
            $res['payData'] = $this->payData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApplyBatchPayResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['payData'])) {
            $model->payData = $map['payData'];
        }

        return $model;
    }
}
