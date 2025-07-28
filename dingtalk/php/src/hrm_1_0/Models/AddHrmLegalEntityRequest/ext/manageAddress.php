<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmLegalEntityRequest\ext;

use AlibabaCloud\Tea\Model;

class manageAddress extends Model
{
    /**
     * @example 110101
     *
     * @var string
     */
    public $areaCode;

    /**
     * @example 东城区
     *
     * @var string
     */
    public $areaName;

    /**
     * @example 123
     *
     * @var string
     */
    public $cityCode;

    /**
     * @example 广州市
     *
     * @var string
     */
    public $cityName;

    /**
     * @example 123
     *
     * @var string
     */
    public $countryCode;

    /**
     * @example China
     *
     * @var string
     */
    public $countryName;

    /**
     * @example 北京市东城区xx街道xx小区xx楼
     *
     * @var string
     */
    public $detailAddress;

    /**
     * @example 1
     *
     * @var string
     */
    public $globalAreaType;

    /**
     * @example 123
     *
     * @var string
     */
    public $provinceCode;

    /**
     * @example 广东省
     *
     * @var string
     */
    public $provinceName;
    protected $_name = [
        'areaCode' => 'areaCode',
        'areaName' => 'areaName',
        'cityCode' => 'cityCode',
        'cityName' => 'cityName',
        'countryCode' => 'countryCode',
        'countryName' => 'countryName',
        'detailAddress' => 'detailAddress',
        'globalAreaType' => 'globalAreaType',
        'provinceCode' => 'provinceCode',
        'provinceName' => 'provinceName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->areaCode) {
            $res['areaCode'] = $this->areaCode;
        }
        if (null !== $this->areaName) {
            $res['areaName'] = $this->areaName;
        }
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->cityName) {
            $res['cityName'] = $this->cityName;
        }
        if (null !== $this->countryCode) {
            $res['countryCode'] = $this->countryCode;
        }
        if (null !== $this->countryName) {
            $res['countryName'] = $this->countryName;
        }
        if (null !== $this->detailAddress) {
            $res['detailAddress'] = $this->detailAddress;
        }
        if (null !== $this->globalAreaType) {
            $res['globalAreaType'] = $this->globalAreaType;
        }
        if (null !== $this->provinceCode) {
            $res['provinceCode'] = $this->provinceCode;
        }
        if (null !== $this->provinceName) {
            $res['provinceName'] = $this->provinceName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return manageAddress
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['areaCode'])) {
            $model->areaCode = $map['areaCode'];
        }
        if (isset($map['areaName'])) {
            $model->areaName = $map['areaName'];
        }
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['cityName'])) {
            $model->cityName = $map['cityName'];
        }
        if (isset($map['countryCode'])) {
            $model->countryCode = $map['countryCode'];
        }
        if (isset($map['countryName'])) {
            $model->countryName = $map['countryName'];
        }
        if (isset($map['detailAddress'])) {
            $model->detailAddress = $map['detailAddress'];
        }
        if (isset($map['globalAreaType'])) {
            $model->globalAreaType = $map['globalAreaType'];
        }
        if (isset($map['provinceCode'])) {
            $model->provinceCode = $map['provinceCode'];
        }
        if (isset($map['provinceName'])) {
            $model->provinceName = $map['provinceName'];
        }

        return $model;
    }
}
