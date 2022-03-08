<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrderResaleRequest extends Model
{
    /**
     * @var int
     */
    public $orderCreateTime;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var int
     */
    public $quantity;

    /**
     * @var int
     */
    public $serviceStartTime;

    /**
     * @var int
     */
    public $serviceStopTime;
    protected $_name = [
        'orderCreateTime'  => 'orderCreateTime',
        'orderId'          => 'orderId',
        'quantity'         => 'quantity',
        'serviceStartTime' => 'serviceStartTime',
        'serviceStopTime'  => 'serviceStopTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderCreateTime) {
            $res['orderCreateTime'] = $this->orderCreateTime;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->serviceStartTime) {
            $res['serviceStartTime'] = $this->serviceStartTime;
        }
        if (null !== $this->serviceStopTime) {
            $res['serviceStopTime'] = $this->serviceStopTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrderResaleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderCreateTime'])) {
            $model->orderCreateTime = $map['orderCreateTime'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['serviceStartTime'])) {
            $model->serviceStartTime = $map['serviceStartTime'];
        }
        if (isset($map['serviceStopTime'])) {
            $model->serviceStopTime = $map['serviceStopTime'];
        }

        return $model;
    }
}
