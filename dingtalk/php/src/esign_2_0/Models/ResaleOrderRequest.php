<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class ResaleOrderRequest extends Model
{
    /**
     * @description 下单时间
     *
     * @var float
     */
    public $orderCreateTime;

    /**
     * @description isv方的订单Id（用于幂等，请保证唯一性）
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 购买数量（电子合同份数）
     *
     * @var float
     */
    public $quantity;

    /**
     * @description 合同生效起始时间
     *
     * @var float
     */
    public $serviceStartTime;

    /**
     * @description 合同失效截止日期，默认有效时间一年
     *
     * @var float
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
     * @return ResaleOrderRequest
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
