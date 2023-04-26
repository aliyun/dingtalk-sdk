<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusGetCampusResponseBody extends Model
{
    /**
     * @example ##街道
     *
     * @var string
     */
    public $address;

    /**
     * @example 1000
     *
     * @var float
     */
    public $area;

    /**
     * @example 1011
     *
     * @var string
     */
    public $belongProjectGroupId;

    /**
     * @example ding121212
     *
     * @var string
     */
    public $campusCorpId;

    /**
     * @example 1001
     *
     * @var int
     */
    public $campusDeptId;

    /**
     * @example 测试园区
     *
     * @var string
     */
    public $campusName;

    /**
     * @example 100
     *
     * @var string
     */
    public $capacity;

    /**
     * @example 2030
     *
     * @var int
     */
    public $cityId;

    /**
     * @example 中国
     *
     * @var string
     */
    public $country;

    /**
     * @example 203040
     *
     * @var int
     */
    public $countyId;

    /**
     * @example 描述
     *
     * @var string
     */
    public $description;

    /**
     * @example 扩展
     *
     * @var string
     */
    public $extend;

    /**
     * @example 120.1,28.1
     *
     * @var string
     */
    public $location;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $orderEndTime;

    /**
     * @example 购买信息
     *
     * @var string
     */
    public $orderInfo;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $orderStartTime;

    /**
     * @example 20
     *
     * @var int
     */
    public $provId;

    /**
     * @example 13914772123
     *
     * @var string
     */
    public $telephone;
    protected $_name = [
        'address'              => 'address',
        'area'                 => 'area',
        'belongProjectGroupId' => 'belongProjectGroupId',
        'campusCorpId'         => 'campusCorpId',
        'campusDeptId'         => 'campusDeptId',
        'campusName'           => 'campusName',
        'capacity'             => 'capacity',
        'cityId'               => 'cityId',
        'country'              => 'country',
        'countyId'             => 'countyId',
        'description'          => 'description',
        'extend'               => 'extend',
        'location'             => 'location',
        'orderEndTime'         => 'orderEndTime',
        'orderInfo'            => 'orderInfo',
        'orderStartTime'       => 'orderStartTime',
        'provId'               => 'provId',
        'telephone'            => 'telephone',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->area) {
            $res['area'] = $this->area;
        }
        if (null !== $this->belongProjectGroupId) {
            $res['belongProjectGroupId'] = $this->belongProjectGroupId;
        }
        if (null !== $this->campusCorpId) {
            $res['campusCorpId'] = $this->campusCorpId;
        }
        if (null !== $this->campusDeptId) {
            $res['campusDeptId'] = $this->campusDeptId;
        }
        if (null !== $this->campusName) {
            $res['campusName'] = $this->campusName;
        }
        if (null !== $this->capacity) {
            $res['capacity'] = $this->capacity;
        }
        if (null !== $this->cityId) {
            $res['cityId'] = $this->cityId;
        }
        if (null !== $this->country) {
            $res['country'] = $this->country;
        }
        if (null !== $this->countyId) {
            $res['countyId'] = $this->countyId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->orderEndTime) {
            $res['orderEndTime'] = $this->orderEndTime;
        }
        if (null !== $this->orderInfo) {
            $res['orderInfo'] = $this->orderInfo;
        }
        if (null !== $this->orderStartTime) {
            $res['orderStartTime'] = $this->orderStartTime;
        }
        if (null !== $this->provId) {
            $res['provId'] = $this->provId;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusGetCampusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['area'])) {
            $model->area = $map['area'];
        }
        if (isset($map['belongProjectGroupId'])) {
            $model->belongProjectGroupId = $map['belongProjectGroupId'];
        }
        if (isset($map['campusCorpId'])) {
            $model->campusCorpId = $map['campusCorpId'];
        }
        if (isset($map['campusDeptId'])) {
            $model->campusDeptId = $map['campusDeptId'];
        }
        if (isset($map['campusName'])) {
            $model->campusName = $map['campusName'];
        }
        if (isset($map['capacity'])) {
            $model->capacity = $map['capacity'];
        }
        if (isset($map['cityId'])) {
            $model->cityId = $map['cityId'];
        }
        if (isset($map['country'])) {
            $model->country = $map['country'];
        }
        if (isset($map['countyId'])) {
            $model->countyId = $map['countyId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['orderEndTime'])) {
            $model->orderEndTime = $map['orderEndTime'];
        }
        if (isset($map['orderInfo'])) {
            $model->orderInfo = $map['orderInfo'];
        }
        if (isset($map['orderStartTime'])) {
            $model->orderStartTime = $map['orderStartTime'];
        }
        if (isset($map['provId'])) {
            $model->provId = $map['provId'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }

        return $model;
    }
}
