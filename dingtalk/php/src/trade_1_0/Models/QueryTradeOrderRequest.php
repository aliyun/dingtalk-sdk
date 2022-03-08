<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTradeOrderRequest extends Model
{
    /**
     * @description 内部订单号
     *
     * @var int
     */
    public $orderId;

    /**
     * @description 外部订单号
     *
     * @var string
     */
    public $outerOrderId;
    protected $_name = [
        'orderId'      => 'orderId',
        'outerOrderId' => 'outerOrderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->outerOrderId) {
            $res['outerOrderId'] = $this->outerOrderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTradeOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['outerOrderId'])) {
            $model->outerOrderId = $map['outerOrderId'];
        }

        return $model;
    }
}
