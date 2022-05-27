<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails;

use AlibabaCloud\Tea\Model;

class hotelLocation extends Model
{
    /**
     * @description 纬度
     *
     * @var string
     */
    public $lat;

    /**
     * @description 经度
     *
     * @var string
     */
    public $lon;

    /**
     * @description 坐标数据源
     * - WGS84: 来自GPS的坐标
     * @var string
     */
    public $source;

    /**
     * @description 定位url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'lat'    => 'lat',
        'lon'    => 'lon',
        'source' => 'source',
        'url'    => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lat) {
            $res['lat'] = $this->lat;
        }
        if (null !== $this->lon) {
            $res['lon'] = $this->lon;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return hotelLocation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lat'])) {
            $model->lat = $map['lat'];
        }
        if (isset($map['lon'])) {
            $model->lon = $map['lon'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
