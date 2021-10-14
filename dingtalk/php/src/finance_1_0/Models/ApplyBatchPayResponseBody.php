<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyBatchPayResponseBody extends Model
{
    /**
     * @description 支付确认页数据
     *
     * @var string
     */
    public $payData;

    /**
     * @description 钉钉支付的批次号
     *
     * @var string
     */
    public $orderNo;
    protected $_name = [
        'payData' => 'payData',
        'orderNo' => 'orderNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->payData) {
            $res['payData'] = $this->payData;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
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
        if (isset($map['payData'])) {
            $model->payData = $map['payData'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }

        return $model;
    }
}
