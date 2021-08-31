<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class vehicleList extends Model
{
    /**
     * @description 用车订单号
     *
     * @var int
     */
    public $id;

    /**
     * @description 订单状态:0:初始状态,1:已超时,2:派单成功,3:派单失败,4:已退款,5:已支付,6:已取消
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
     * @return vehicleList
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
