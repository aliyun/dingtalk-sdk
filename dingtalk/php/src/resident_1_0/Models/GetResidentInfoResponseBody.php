<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoResponseBody\projectManager;
use AlibabaCloud\Tea\Model;

class GetResidentInfoResponseBody extends Model
{
    /**
     * @description 小区地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 全员群opencid
     *
     * @var string
     */
    public $allUserGroupOpenConversationId;

    /**
     * @description 全员群群主 userid
     *
     * @var string
     */
    public $allUserGroupOwnerUserId;

    /**
     * @var float
     */
    public $buildingArea;

    /**
     * @description 小区归属的市的id
     *
     * @var int
     */
    public $cityId;

    /**
     * @description 通信录模式:0标准/1自定义
     *
     * @var int
     */
    public $contactMode;

    /**
     * @description 小区归属的区/县的id
     *
     * @var int
     */
    public $countyId;

    /**
     * @description 交付时间
     *
     * @var int
     */
    public $deliveryTime;

    /**
     * @description 经纬度，格式：经度,纬度
     *
     * @var string
     */
    public $location;

    /**
     * @description 小区名称
     *
     * @var string
     */
    public $name;

    /**
     * @var projectManager
     */
    public $projectManager;

    /**
     * @description 物业部门群cid
     *
     * @var string
     */
    public $propertyDeptGroupOpenConversationId;

    /**
     * @description 物业部门群主userid
     *
     * @var string
     */
    public $propertyDeptGroupOwnerUserId;

    /**
     * @description 小区归属的省的id
     *
     * @var int
     */
    public $provId;

    /**
     * @description 物业管理范围-东
     *
     * @var string
     */
    public $scopeEast;

    /**
     * @description 物业管理范围-北
     *
     * @var string
     */
    public $scopeNorth;

    /**
     * @description 物业管理范围-南
     *
     * @var string
     */
    public $scopeSouth;

    /**
     * @description 物业管理范围-西
     *
     * @var string
     */
    public $scopeWest;

    /**
     * @description 物业电话
     *
     * @var string
     */
    public $telephone;

    /**
     * @description 小区归属的街道/镇的id
     *
     * @var int
     */
    public $townId;

    /**
     * @description 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'address'                             => 'address',
        'allUserGroupOpenConversationId'      => 'allUserGroupOpenConversationId',
        'allUserGroupOwnerUserId'             => 'allUserGroupOwnerUserId',
        'buildingArea'                        => 'buildingArea',
        'cityId'                              => 'cityId',
        'contactMode'                         => 'contactMode',
        'countyId'                            => 'countyId',
        'deliveryTime'                        => 'deliveryTime',
        'location'                            => 'location',
        'name'                                => 'name',
        'projectManager'                      => 'projectManager',
        'propertyDeptGroupOpenConversationId' => 'propertyDeptGroupOpenConversationId',
        'propertyDeptGroupOwnerUserId'        => 'propertyDeptGroupOwnerUserId',
        'provId'                              => 'provId',
        'scopeEast'                           => 'scopeEast',
        'scopeNorth'                          => 'scopeNorth',
        'scopeSouth'                          => 'scopeSouth',
        'scopeWest'                           => 'scopeWest',
        'telephone'                           => 'telephone',
        'townId'                              => 'townId',
        'type'                                => 'type',
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
        if (null !== $this->allUserGroupOpenConversationId) {
            $res['allUserGroupOpenConversationId'] = $this->allUserGroupOpenConversationId;
        }
        if (null !== $this->allUserGroupOwnerUserId) {
            $res['allUserGroupOwnerUserId'] = $this->allUserGroupOwnerUserId;
        }
        if (null !== $this->buildingArea) {
            $res['buildingArea'] = $this->buildingArea;
        }
        if (null !== $this->cityId) {
            $res['cityId'] = $this->cityId;
        }
        if (null !== $this->contactMode) {
            $res['contactMode'] = $this->contactMode;
        }
        if (null !== $this->countyId) {
            $res['countyId'] = $this->countyId;
        }
        if (null !== $this->deliveryTime) {
            $res['deliveryTime'] = $this->deliveryTime;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->projectManager) {
            $res['projectManager'] = null !== $this->projectManager ? $this->projectManager->toMap() : null;
        }
        if (null !== $this->propertyDeptGroupOpenConversationId) {
            $res['propertyDeptGroupOpenConversationId'] = $this->propertyDeptGroupOpenConversationId;
        }
        if (null !== $this->propertyDeptGroupOwnerUserId) {
            $res['propertyDeptGroupOwnerUserId'] = $this->propertyDeptGroupOwnerUserId;
        }
        if (null !== $this->provId) {
            $res['provId'] = $this->provId;
        }
        if (null !== $this->scopeEast) {
            $res['scopeEast'] = $this->scopeEast;
        }
        if (null !== $this->scopeNorth) {
            $res['scopeNorth'] = $this->scopeNorth;
        }
        if (null !== $this->scopeSouth) {
            $res['scopeSouth'] = $this->scopeSouth;
        }
        if (null !== $this->scopeWest) {
            $res['scopeWest'] = $this->scopeWest;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->townId) {
            $res['townId'] = $this->townId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['allUserGroupOpenConversationId'])) {
            $model->allUserGroupOpenConversationId = $map['allUserGroupOpenConversationId'];
        }
        if (isset($map['allUserGroupOwnerUserId'])) {
            $model->allUserGroupOwnerUserId = $map['allUserGroupOwnerUserId'];
        }
        if (isset($map['buildingArea'])) {
            $model->buildingArea = $map['buildingArea'];
        }
        if (isset($map['cityId'])) {
            $model->cityId = $map['cityId'];
        }
        if (isset($map['contactMode'])) {
            $model->contactMode = $map['contactMode'];
        }
        if (isset($map['countyId'])) {
            $model->countyId = $map['countyId'];
        }
        if (isset($map['deliveryTime'])) {
            $model->deliveryTime = $map['deliveryTime'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['projectManager'])) {
            $model->projectManager = projectManager::fromMap($map['projectManager']);
        }
        if (isset($map['propertyDeptGroupOpenConversationId'])) {
            $model->propertyDeptGroupOpenConversationId = $map['propertyDeptGroupOpenConversationId'];
        }
        if (isset($map['propertyDeptGroupOwnerUserId'])) {
            $model->propertyDeptGroupOwnerUserId = $map['propertyDeptGroupOwnerUserId'];
        }
        if (isset($map['provId'])) {
            $model->provId = $map['provId'];
        }
        if (isset($map['scopeEast'])) {
            $model->scopeEast = $map['scopeEast'];
        }
        if (isset($map['scopeNorth'])) {
            $model->scopeNorth = $map['scopeNorth'];
        }
        if (isset($map['scopeSouth'])) {
            $model->scopeSouth = $map['scopeSouth'];
        }
        if (isset($map['scopeWest'])) {
            $model->scopeWest = $map['scopeWest'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['townId'])) {
            $model->townId = $map['townId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
