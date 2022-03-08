<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody\flightList;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody\hotelList;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody\trainList;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponseBody\vehicleList;
use AlibabaCloud\Tea\Model;

class QueryUnionOrderResponseBody extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 飞机订单信息
     *
     * @var flightList[]
     */
    public $flightList;

    /**
     * @description 酒店订单信息
     *
     * @var hotelList[]
     */
    public $hotelList;

    /**
     * @description 火车订单信息
     *
     * @var trainList[]
     */
    public $trainList;

    /**
     * @description 用车订单信息
     *
     * @var vehicleList[]
     */
    public $vehicleList;
    protected $_name = [
        'corpId'      => 'corpId',
        'flightList'  => 'flightList',
        'hotelList'   => 'hotelList',
        'trainList'   => 'trainList',
        'vehicleList' => 'vehicleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->flightList) {
            $res['flightList'] = [];
            if (null !== $this->flightList && \is_array($this->flightList)) {
                $n = 0;
                foreach ($this->flightList as $item) {
                    $res['flightList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hotelList) {
            $res['hotelList'] = [];
            if (null !== $this->hotelList && \is_array($this->hotelList)) {
                $n = 0;
                foreach ($this->hotelList as $item) {
                    $res['hotelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->trainList) {
            $res['trainList'] = [];
            if (null !== $this->trainList && \is_array($this->trainList)) {
                $n = 0;
                foreach ($this->trainList as $item) {
                    $res['trainList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->vehicleList) {
            $res['vehicleList'] = [];
            if (null !== $this->vehicleList && \is_array($this->vehicleList)) {
                $n = 0;
                foreach ($this->vehicleList as $item) {
                    $res['vehicleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUnionOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['flightList'])) {
            if (!empty($map['flightList'])) {
                $model->flightList = [];
                $n                 = 0;
                foreach ($map['flightList'] as $item) {
                    $model->flightList[$n++] = null !== $item ? flightList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hotelList'])) {
            if (!empty($map['hotelList'])) {
                $model->hotelList = [];
                $n                = 0;
                foreach ($map['hotelList'] as $item) {
                    $model->hotelList[$n++] = null !== $item ? hotelList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['trainList'])) {
            if (!empty($map['trainList'])) {
                $model->trainList = [];
                $n                = 0;
                foreach ($map['trainList'] as $item) {
                    $model->trainList[$n++] = null !== $item ? trainList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['vehicleList'])) {
            if (!empty($map['vehicleList'])) {
                $model->vehicleList = [];
                $n                  = 0;
                foreach ($map['vehicleList'] as $item) {
                    $model->vehicleList[$n++] = null !== $item ? vehicleList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
