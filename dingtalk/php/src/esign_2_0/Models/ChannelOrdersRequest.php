<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class ChannelOrdersRequest extends Model
{
    /**
     * @var string
     */
    public $itemCode;

    /**
     * @var string
     */
    public $itemName;

    /**
     * @var float
     */
    public $orderCreateTime;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var float
     */
    public $payFee;

    /**
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
