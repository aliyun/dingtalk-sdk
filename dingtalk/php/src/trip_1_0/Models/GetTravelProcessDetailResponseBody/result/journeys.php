<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys\arrival;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys\departure;
use AlibabaCloud\Tea\Model;

class journeys extends Model
{
    /**
     * @var arrival
     */
    public $arrival;

    /**
     * @var departure
     */
    public $departure;

    /**
     * @example 2023-10-25
     *
     * @var string
     */
    public $endTime;

    /**
     * @example 123455xxxxxxxx
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @example 2023-10-20
     *
     * @var string
     */
    public $startTime;

    /**
     * @example 飞机
     *
     * @var string
     */
    public $travelType;

    /**
     * @example 单程
     *
     * @var string
     */
    public $tripWay;
    protected $_name = [
        'arrival'      => 'arrival',
        'departure'    => 'departure',
        'endTime'      => 'endTime',
        'journeyBizNo' => 'journeyBizNo',
        'startTime'    => 'startTime',
        'travelType'   => 'travelType',
        'tripWay'      => 'tripWay',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrival) {
            $res['arrival'] = null !== $this->arrival ? $this->arrival->toMap() : null;
        }
        if (null !== $this->departure) {
            $res['departure'] = null !== $this->departure ? $this->departure->toMap() : null;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->journeyBizNo) {
            $res['journeyBizNo'] = $this->journeyBizNo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->travelType) {
            $res['travelType'] = $this->travelType;
        }
        if (null !== $this->tripWay) {
            $res['tripWay'] = $this->tripWay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return journeys
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arrival'])) {
            $model->arrival = arrival::fromMap($map['arrival']);
        }
        if (isset($map['departure'])) {
            $model->departure = departure::fromMap($map['departure']);
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['journeyBizNo'])) {
            $model->journeyBizNo = $map['journeyBizNo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['travelType'])) {
            $model->travelType = $map['travelType'];
        }
        if (isset($map['tripWay'])) {
            $model->tripWay = $map['tripWay'];
        }

        return $model;
    }
}
