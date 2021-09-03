<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class trainList extends Model
{
    /**
     * @description 火车订单号
     *
     * @var int
     */
    public $trainOrderId;

    /**
     * @description 订单状态：0待支付,1出票中,2已关闭,3,改签成功,4退票成功,5出票完成,6退票申请中,7改签申请中,8已出票,已发货,9出票失败,10改签失败,11退票失败
     *
     * @var int
     */
    public $trainOrderstatus;
    protected $_name = [
        'trainOrderId'     => 'trainOrderId',
        'trainOrderstatus' => 'trainOrderstatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->trainOrderId) {
            $res['trainOrderId'] = $this->trainOrderId;
        }
        if (null !== $this->trainOrderstatus) {
            $res['trainOrderstatus'] = $this->trainOrderstatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return trainList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['trainOrderId'])) {
            $model->trainOrderId = $map['trainOrderId'];
        }
        if (isset($map['trainOrderstatus'])) {
            $model->trainOrderstatus = $map['trainOrderstatus'];
        }

        return $model;
    }
}
