<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityRequest\detail;

use AlibabaCloud\Tea\Model;

class address extends Model
{
    /**
     * @example 重庆市重庆市
     *
     * @var string
     */
    public $district;

    /**
     * @example 29.533939
     *
     * @var string
     */
    public $lat;

    /**
     * @example 106.561853
     *
     * @var string
     */
    public $lng;

    /**
     * @example 国际会议展览中心
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'district' => 'district',
        'lat' => 'lat',
        'lng' => 'lng',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->district) {
            $res['district'] = $this->district;
        }
        if (null !== $this->lat) {
            $res['lat'] = $this->lat;
        }
        if (null !== $this->lng) {
            $res['lng'] = $this->lng;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return address
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['district'])) {
            $model->district = $map['district'];
        }
        if (isset($map['lat'])) {
            $model->lat = $map['lat'];
        }
        if (isset($map['lng'])) {
            $model->lng = $map['lng'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
