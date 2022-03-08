<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class ChannelOrdersRequest extends Model
{
    /**
     * @description 商品id
     *
     * @var string
     */
    public $itemCode;

    /**
     * @description 商品名称
     *
     * @var string
     */
    public $itemName;

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
     * @description 支付金额（以分为单位，仅作记录，不作为凭证）
     *
     * @var float
     */
    public $payFee;

    /**
     * @description 购买数量
     *
     * @var float
     */
    public $quantity;
    protected $_name = [
        'itemCode'        => 'itemCode',
        'itemName'        => 'itemName',
        'orderCreateTime' => 'orderCreateTime',
        'orderId'         => 'orderId',
        'payFee'          => 'payFee',
        'quantity'        => 'quantity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemCode) {
            $res['itemCode'] = $this->itemCode;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->orderCreateTime) {
            $res['orderCreateTime'] = $this->orderCreateTime;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->payFee) {
            $res['payFee'] = $this->payFee;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChannelOrdersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemCode'])) {
            $model->itemCode = $map['itemCode'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['orderCreateTime'])) {
            $model->orderCreateTime = $map['orderCreateTime'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['payFee'])) {
            $model->payFee = $map['payFee'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }

        return $model;
    }
}
