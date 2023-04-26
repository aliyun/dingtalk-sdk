<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryAppActiveUsersResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example kxm9dhfs01jd98cuv
     *
     * @var string
     */
    public $appTraceId;

    /**
     * @example 123.123
     *
     * @var float
     */
    public $latitude;

    /**
     * @example 123.123
     *
     * @var float
     */
    public $longitude;

    /**
     * @example 1619341954123
     *
     * @var int
     */
    public $reportTime;

    /**
     * @example 1619341754123
     *
     * @var int
     */
    public $startTime;

    /**
     * @example I0912384771
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appTraceId' => 'appTraceId',
        'latitude'   => 'latitude',
        'longitude'  => 'longitude',
        'reportTime' => 'reportTime',
        'startTime'  => 'startTime',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appTraceId) {
            $res['appTraceId'] = $this->appTraceId;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->reportTime) {
            $res['reportTime'] = $this->reportTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appTraceId'])) {
            $model->appTraceId = $map['appTraceId'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['reportTime'])) {
            $model->reportTime = $map['reportTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
