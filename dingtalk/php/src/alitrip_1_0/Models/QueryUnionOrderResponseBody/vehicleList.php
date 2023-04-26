<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class vehicleList extends Model
{
    /**
     * @example 1231
     *
     * @var int
     */
    public $vehicleOrderId;

    /**
     * @example 1
     *
     * @var int
     */
    public $vehicleOrderStatus;
    protected $_name = [
        'vehicleOrderId'     => 'vehicleOrderId',
        'vehicleOrderStatus' => 'vehicleOrderStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->vehicleOrderId) {
            $res['vehicleOrderId'] = $this->vehicleOrderId;
        }
        if (null !== $this->vehicleOrderStatus) {
            $res['vehicleOrderStatus'] = $this->vehicleOrderStatus;
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
        if (isset($map['vehicleOrderId'])) {
            $model->vehicleOrderId = $map['vehicleOrderId'];
        }
        if (isset($map['vehicleOrderStatus'])) {
            $model->vehicleOrderStatus = $map['vehicleOrderStatus'];
        }

        return $model;
    }
}
