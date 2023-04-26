<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody;

use AlibabaCloud\Tea\Model;

class hotelList extends Model
{
    /**
     * @example 12312
     *
     * @var int
     */
    public $hotelOrderId;

    /**
     * @example 1
     *
     * @var int
     */
    public $hotelOrderStatus;
    protected $_name = [
        'hotelOrderId'     => 'hotelOrderId',
        'hotelOrderStatus' => 'hotelOrderStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hotelOrderId) {
            $res['hotelOrderId'] = $this->hotelOrderId;
        }
        if (null !== $this->hotelOrderStatus) {
            $res['hotelOrderStatus'] = $this->hotelOrderStatus;
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
        if (isset($map['hotelOrderId'])) {
            $model->hotelOrderId = $map['hotelOrderId'];
        }
        if (isset($map['hotelOrderStatus'])) {
            $model->hotelOrderStatus = $map['hotelOrderStatus'];
        }

        return $model;
    }
}
