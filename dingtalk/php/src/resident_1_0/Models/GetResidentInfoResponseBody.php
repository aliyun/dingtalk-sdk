<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoResponseBody\projectManager;
use AlibabaCloud\Tea\Model;

class GetResidentInfoResponseBody extends Model
{
    /**
     * @description 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
     *
     * @var int
     */
    public $type;

    /**
     * @description 经纬度，格式：经度,纬度
     *
     * @var string
     */
    public $location;

    /**
     * @description 小区地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 小区归属的省的id
     *
     * @var int
     */
    public $provId;

    /**
     * @var float
     */
    public $buildingArea;

    /**
     * @description 小区名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 物业电话
     *
     * @var string
     */
    public $telephone;

    /**
     * @description 交付时间
     *
     * @var int
     */
    public $deliveryTime;

    /**
     * @description 通信录模式:0标准/1自定义
     *
     * @var int
     */
    public $contactMode;

    /**
     * @description 物业管理范围-东
     *
     * @var string
     */
    public $scopeEast;

    /**
     * @description 物业管理范围-西
     *
     * @var string
     */
    public $scopeWest;

    /**
     * @description 物业管理范围-南
     *
     * @var string
     */
    public $scopeSouth;

    /**
     * @description 物业管理范围-北
     *
     * @var string
     */
    public $scopeNorth;

    /**
     * @description 小区归属的市的id
     *
     * @var int
     */
    public $cityId;

    /**
     * @description 小区归属的区/县的id
     *
     * @var int
     */
    public $countyId;

    /**
     * @description 小区归属的街道/镇的id
     *
     * @var int
     */
    public $townId;

    /**
     * @var projectManager
     */
    public $projectManager;
    protected $_name = [
        'type'           => 'type',
        'location'       => 'location',
        'address'        => 'address',
        'provId'         => 'provId',
        'buildingArea'   => 'buildingArea',
        'name'           => 'name',
        'telephone'      => 'telephone',
        'deliveryTime'   => 'deliveryTime',
        'contactMode'    => 'contactMode',
        'scopeEast'      => 'scopeEast',
        'scopeWest'      => 'scopeWest',
        'scopeSouth'     => 'scopeSouth',
        'scopeNorth'     => 'scopeNorth',
        'cityId'         => 'cityId',
        'countyId'       => 'countyId',
        'townId'         => 'townId',
        'projectManager' => 'projectManager',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->provId) {
            $res['provId'] = $this->provId;
        }
        if (null !== $this->buildingArea) {
            $res['buildingArea'] = $this->buildingArea;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->deliveryTime) {
            $res['deliveryTime'] = $this->deliveryTime;
        }
        if (null !== $this->contactMode) {
            $res['contactMode'] = $this->contactMode;
        }
        if (null !== $this->scopeEast) {
            $res['scopeEast'] = $this->scopeEast;
        }
        if (null !== $this->scopeWest) {
            $res['scopeWest'] = $this->scopeWest;
        }
        if (null !== $this->scopeSouth) {
            $res['scopeSouth'] = $this->scopeSouth;
        }
        if (null !== $this->scopeNorth) {
            $res['scopeNorth'] = $this->scopeNorth;
        }
        if (null !== $this->cityId) {
            $res['cityId'] = $this->cityId;
        }
        if (null !== $this->countyId) {
            $res['countyId'] = $this->countyId;
        }
        if (null !== $this->townId) {
            $res['townId'] = $this->townId;
        }
        if (null !== $this->projectManager) {
            $res['projectManager'] = null !== $this->projectManager ? $this->projectManager->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['provId'])) {
            $model->provId = $map['provId'];
        }
        if (isset($map['buildingArea'])) {
            $model->buildingArea = $map['buildingArea'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['deliveryTime'])) {
            $model->deliveryTime = $map['deliveryTime'];
        }
        if (isset($map['contactMode'])) {
            $model->contactMode = $map['contactMode'];
        }
        if (isset($map['scopeEast'])) {
            $model->scopeEast = $map['scopeEast'];
        }
        if (isset($map['scopeWest'])) {
            $model->scopeWest = $map['scopeWest'];
        }
        if (isset($map['scopeSouth'])) {
            $model->scopeSouth = $map['scopeSouth'];
        }
        if (isset($map['scopeNorth'])) {
            $model->scopeNorth = $map['scopeNorth'];
        }
        if (isset($map['cityId'])) {
            $model->cityId = $map['cityId'];
        }
        if (isset($map['countyId'])) {
            $model->countyId = $map['countyId'];
        }
        if (isset($map['townId'])) {
            $model->townId = $map['townId'];
        }
        if (isset($map['projectManager'])) {
            $model->projectManager = projectManager::fromMap($map['projectManager']);
        }

        return $model;
    }
}
