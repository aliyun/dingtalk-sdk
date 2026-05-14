<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponseBody\result\deviceLocations;

use AlibabaCloud\Tea\Model;

class locations extends Model
{
    /**
     * @var string
     */
    public $latitude;

    /**
     * @var string
     */
    public $longitude;

    /**
     * @var string
     */
    public $time;
    protected $_name = [
        'latitude' => 'latitude',
        'longitude' => 'longitude',
        'time' => 'time',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return locations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
