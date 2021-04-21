<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponseBody\list_;

use AlibabaCloud\Tea\Model;

class coordinates extends Model
{
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
    protected $_name = [
        'longitude' => 'longitude',
        'latitude'  => 'latitude',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return coordinates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }

        return $model;
    }
}
