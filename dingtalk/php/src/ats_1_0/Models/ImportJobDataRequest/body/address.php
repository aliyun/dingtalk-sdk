<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\ImportJobDataRequest\body;

use AlibabaCloud\Tea\Model;

class address extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cityCode;

    /**
     * @var string
     */
    public $customName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $districtCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $latitude;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $longitude;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $provinceCode;
    protected $_name = [
        'cityCode'     => 'cityCode',
        'customName'   => 'customName',
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
        if (null !== $this->customName) {
            $res['customName'] = $this->customName;
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
        if (isset($map['customName'])) {
            $model->customName = $map['customName'];
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
