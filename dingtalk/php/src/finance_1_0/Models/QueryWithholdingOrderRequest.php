<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryWithholdingOrderRequest extends Model
{
    /**
     * @example 202100001
     *
     * @var string
     */
    public $outTradeNo;
    protected $_name = [
        'outTradeNo' => 'outTradeNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryWithholdingOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }

        return $model;
    }
}
