<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusUpdateCampusRequest extends Model
{
    /**
     * @example 锦城街道和谐社区101号
     *
     * @var string
     */
    public $address;

    /**
     * @example 5200.13（平方米）
     *
     * @var float
     */
    public $area;

    /**
     * @example 0
     *
     * @var int
     */
    public $belongProjectGroupId;

    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var int
     */
    public $campusDeptId;

    /**
     * @example 绿城未来park
     *
     * @var string
     */
    public $campusName;

    /**
     * @example 10000
     *
     * @var int
     */
    public $capacity;

    /**
     * @example 371500
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
     * @example 371502
     *
     * @var int
     */
    public $countyId;

    /**
     * @example 绿城产业
     *
     * @var string
     */
    public $description;

    /**
     * @example {"creator":"dsy"}
     *
     * @var string
     */
    public $extend;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $orderEndTime;

    /**
     * @example 线下付款
     *
     * @var int
     */
    public $orderInfo;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $orderStartTime;

    /**
     * @example 370000（山东）
     *
     * @var int
     */
    public $provId;

    /**
     * @example 156XXXX338
     *
     * @var string
     */
    public $telephone;
    protected $_name = [
        'address' => 'address',
        'area' => 'area',
        'belongProjectGroupId' => 'belongProjectGroupId',
        'campusDeptId' => 'campusDeptId',
        'campusName' => 'campusName',
        'capacity' => 'capacity',
        'cityId' => 'cityId',
        'country' => 'country',
        'countyId' => 'countyId',
        'description' => 'description',
        'extend' => 'extend',
        'orderEndTime' => 'orderEndTime',
        'orderInfo' => 'orderInfo',
        'orderStartTime' => 'orderStartTime',
        'provId' => 'provId',
        'telephone' => 'telephone',
    ];

    public function validate() {}

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
     * @return CampusUpdateCampusRequest
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
