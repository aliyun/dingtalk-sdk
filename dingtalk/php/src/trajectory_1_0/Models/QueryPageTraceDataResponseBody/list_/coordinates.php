<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponseBody\list_;

use AlibabaCloud\Tea\Model;

class coordinates extends Model
{
    /**
     * @var float
     */
    public $latitude;

    /**
     * @var float
     */
    public $longitude;
    protected $_name = [
        'latitude'  => 'latitude',
        'longitude' => 'longitude',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
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
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }

        return $model;
    }
}
