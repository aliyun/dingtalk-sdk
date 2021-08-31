<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class hotelList extends Model
{
    /**
     * @description 酒店订单号
     *
     * @var int
     */
    public $id;

    /**
     * @description 订单状态1:等待确认,2:等待付款,3:预订成功,4:申请退款,5:退款成功,6:已关闭,7:结账成功,8:支付成功
     *
     * @var int
     */
    public $orderStatus;
    protected $_name = [
        'id'          => 'id',
        'orderStatus' => 'orderStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->orderStatus) {
            $res['orderStatus'] = $this->orderStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return hotelList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['orderStatus'])) {
            $model->orderStatus = $map['orderStatus'];
        }

        return $model;
    }
}
