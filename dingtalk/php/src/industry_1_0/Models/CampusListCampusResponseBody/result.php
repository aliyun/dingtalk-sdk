<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 面积
     *
     * @var float
     */
    public $area;

    /**
     * @description 项目组ID
     *
     * @var int
     */
    public $belongProjectGroupId;

    /**
     * @description 园区组织ID
     *
     * @var string
     */
    public $campusCorpId;

    /**
     * @description 园区部门ID
     *
     * @var int
     */
    public $campusDeptId;

    /**
     * @description 园区名称
     *
     * @var string
     */
    public $campusName;

    /**
     * @description 市
     *
     * @var int
     */
    public $cityId;

    /**
     * @description 国家
     *
     * @var string
     */
    public $country;

    /**
     * @description 区
     *
     * @var int
     */
    public $countyId;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extend;

    /**
     * @description 经纬度
     *
     * @var string
     */
    public $location;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $orderEndTime;

    /**
     * @description 订购信息
     *
     * @var string
     */
    public $orderInfo;

    /**
     * @description 订购时间
     *
     * @var int
     */
    public $orderStartTime;

    /**
     * @description 省
     *
     * @var int
     */
    public $provId;

    /**
     * @description 手机号
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
     * @return result
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
