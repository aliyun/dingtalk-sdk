<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaRequest;

use AlibabaCloud\Tea\Model;

class order extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $capacity;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $capacityType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $day;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $money;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $orderId;
    protected $_name = [
        'bizType' => 'bizType',
        'capacity' => 'capacity',
        'capacityType' => 'capacityType',
        'day' => 'day',
        'money' => 'money',
        'orderId' => 'orderId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->capacity) {
            $res['capacity'] = $this->capacity;
        }
        if (null !== $this->capacityType) {
            $res['capacityType'] = $this->capacityType;
        }
        if (null !== $this->day) {
            $res['day'] = $this->day;
        }
        if (null !== $this->money) {
            $res['money'] = $this->money;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
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
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['capacity'])) {
            $model->capacity = $map['capacity'];
        }
        if (isset($map['capacityType'])) {
            $model->capacityType = $map['capacityType'];
        }
        if (isset($map['day'])) {
            $model->day = $map['day'];
        }
        if (isset($map['money'])) {
            $model->money = $map['money'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }

        return $model;
    }
}
