<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcquireRefundOrderRequest extends Model
{
    /**
     * @description 外部退款订单流水号
     *
     * @var string
     */
    public $outRefundNo;
    protected $_name = [
        'outRefundNo' => 'outRefundNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outRefundNo) {
            $res['outRefundNo'] = $this->outRefundNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAcquireRefundOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outRefundNo'])) {
            $model->outRefundNo = $map['outRefundNo'];
        }

        return $model;
    }
}
