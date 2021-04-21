<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponseBody\list_\coordinates;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 经纬度
     *
     * @var coordinates
     */
    public $coordinates;

    /**
     * @description 定位时间
     *
     * @var int
     */
    public $gmtLocation;

    /**
     * @description 上报时间
     *
     * @var int
     */
    public $gmtUpload;
    protected $_name = [
        'coordinates' => 'coordinates',
        'gmtLocation' => 'gmtLocation',
        'gmtUpload'   => 'gmtUpload',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coordinates) {
            $res['coordinates'] = null !== $this->coordinates ? $this->coordinates->toMap() : null;
        }
        if (null !== $this->gmtLocation) {
            $res['gmtLocation'] = $this->gmtLocation;
        }
        if (null !== $this->gmtUpload) {
            $res['gmtUpload'] = $this->gmtUpload;
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
        if (isset($map['coordinates'])) {
            $model->coordinates = coordinates::fromMap($map['coordinates']);
        }
        if (isset($map['gmtLocation'])) {
            $model->gmtLocation = $map['gmtLocation'];
        }
        if (isset($map['gmtUpload'])) {
            $model->gmtUpload = $map['gmtUpload'];
        }

        return $model;
    }
}
