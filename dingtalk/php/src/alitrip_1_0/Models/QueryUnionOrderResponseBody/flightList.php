<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class flightList extends Model
{
    /**
     * @description 订单id
     *
     * @var int
     */
    public $flightOrderId;

    /**
     * @description 订单状态：0待支付,1出票中,2已关闭,3有改签单,4有退票单,5出票成功,6退票申请中,7改签申请中
     *
     * @var int
     */
    public $flightOrderStatus;
    protected $_name = [
        'flightOrderId'     => 'flightOrderId',
        'flightOrderStatus' => 'flightOrderStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->flightOrderId) {
            $res['flightOrderId'] = $this->flightOrderId;
        }
        if (null !== $this->flightOrderStatus) {
            $res['flightOrderStatus'] = $this->flightOrderStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return flightList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flightOrderId'])) {
            $model->flightOrderId = $map['flightOrderId'];
        }
        if (isset($map['flightOrderStatus'])) {
            $model->flightOrderStatus = $map['flightOrderStatus'];
        }

        return $model;
    }
}
