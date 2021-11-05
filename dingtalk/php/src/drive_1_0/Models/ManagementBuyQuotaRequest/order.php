<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaRequest;

use AlibabaCloud\Tea\Model;

class order extends Model
{
    /**
     * @description 订单id
     *
     * @var int
     */
    public $orderId;

    /**
     * @description 业务类型
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 容量类型
     *
     * @var string
     */
    public $capacityType;

    /**
     * @description 待扩容的容量
     *
     * @var int
     */
    public $capacity;

    /**
     * @description 时长
     *
     * @var int
     */
    public $day;

    /**
     * @description 金额
     *
     * @var int
     */
    public $money;
    protected $_name = [
        'orderId'      => 'orderId',
        'bizType'      => 'bizType',
        'capacityType' => 'capacityType',
        'capacity'     => 'capacity',
        'day'          => 'day',
        'money'        => 'money',
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
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->capacityType) {
            $res['capacityType'] = $this->capacityType;
        }
        if (null !== $this->capacity) {
            $res['capacity'] = $this->capacity;
        }
        if (null !== $this->day) {
            $res['day'] = $this->day;
        }
        if (null !== $this->money) {
            $res['money'] = $this->money;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return order
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['capacityType'])) {
            $model->capacityType = $map['capacityType'];
        }
        if (isset($map['capacity'])) {
            $model->capacity = $map['capacity'];
        }
        if (isset($map['day'])) {
            $model->day = $map['day'];
        }
        if (isset($map['money'])) {
            $model->money = $map['money'];
        }

        return $model;
    }
}
