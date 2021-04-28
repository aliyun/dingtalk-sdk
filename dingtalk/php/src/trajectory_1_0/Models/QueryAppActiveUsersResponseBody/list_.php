<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryAppActiveUsersResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 轨迹采集开启时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 应用轨迹ID
     *
     * @var string
     */
    public $appTraceId;

    /**
     * @description 经度
     *
     * @var float
     */
    public $longitude;

    /**
     * @description 纬度
     *
     * @var float
     */
    public $latitude;

    /**
     * @description 该位置采集时间
     *
     * @var int
     */
    public $reportTime;

    /**
     * @description 员工Id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'startTime'  => 'startTime',
        'appTraceId' => 'appTraceId',
        'longitude'  => 'longitude',
        'latitude'   => 'latitude',
        'reportTime' => 'reportTime',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->appTraceId) {
            $res['appTraceId'] = $this->appTraceId;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->reportTime) {
            $res['reportTime'] = $this->reportTime;
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
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['appTraceId'])) {
            $model->appTraceId = $map['appTraceId'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['reportTime'])) {
            $model->reportTime = $map['reportTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
