<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;

use AlibabaCloud\Tea\Model;

class address extends Model
{
    /**
     * @description 城市编码
     *
     * @var string
     */
    public $cityCode;

    /**
     * @description 位置详情描述
     *
     * @var string
     */
    public $detail;

    /**
     * @description 区县编码
     *
     * @var string
     */
    public $districtCode;

    /**
     * @description 经度（高德地图选点）
     *
     * @var string
     */
    public $latitude;

    /**
     * @description 纬度（高德地图选点）
     *
     * @var string
     */
    public $longitude;

    /**
     * @description 位置名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 省份编码
     *
     * @var string
     */
    public $provinceCode;
    protected $_name = [
        'cityCode'     => 'cityCode',
        'detail'       => 'detail',
        'districtCode' => 'districtCode',
        'latitude'     => 'latitude',
        'longitude'    => 'longitude',
        'name'         => 'name',
        'provinceCode' => 'provinceCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->detail) {
            $res['detail'] = $this->detail;
        }
        if (null !== $this->districtCode) {
            $res['districtCode'] = $this->districtCode;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->provinceCode) {
            $res['provinceCode'] = $this->provinceCode;
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
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['detail'])) {
            $model->detail = $map['detail'];
        }
        if (isset($map['districtCode'])) {
            $model->districtCode = $map['districtCode'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['provinceCode'])) {
            $model->provinceCode = $map['provinceCode'];
        }

        return $model;
    }
}
