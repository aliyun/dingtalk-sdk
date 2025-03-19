<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;

use AlibabaCloud\Tea\Model;

class address extends Model
{
    /**
     * @example 310000
     *
     * @var string
     */
    public $cityCode;

    /**
     * @example 文一西路999号
     *
     * @var string
     */
    public $detail;

    /**
     * @example 311000
     *
     * @var string
     */
    public $districtCode;

    /**
     * @example 89.54613
     *
     * @var string
     */
    public $latitude;

    /**
     * @example 128.45613
     *
     * @var string
     */
    public $longitude;

    /**
     * @example 总部大楼
     *
     * @var string
     */
    public $name;

    /**
     * @example 300000
     *
     * @var string
     */
    public $provinceCode;
    protected $_name = [
        'cityCode' => 'cityCode',
        'detail' => 'detail',
        'districtCode' => 'districtCode',
        'latitude' => 'latitude',
        'longitude' => 'longitude',
        'name' => 'name',
        'provinceCode' => 'provinceCode',
    ];

    public function validate() {}

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
