<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceRequest;

use AlibabaCloud\Tea\Model;

class spaceInfoVOList extends Model
{
    /**
     * @description 计费面积
     *
     * @var float
     */
    public $billingArea;

    /**
     * @description 建筑面积
     *
     * @var float
     */
    public $buildingArea;

    /**
     * @description 楼栋类型
     *
     * @var int
     */
    public $buildingType;

    /**
     * @description 修改的空间的唯一标识
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 房屋所在楼层，当tagCode为House时选填
     *
     * @var string
     */
    public $floor;

    /**
     * @description 房屋状态，tagcode为house时选填，0空置/1未领/2入住/3空关/4装修
     *
     * @var int
     */
    public $houseState;

    /**
     * @description 房屋类型，当tagcode为House时必填
     *
     * @var int
     */
    public $houseType;

    /**
     * @description 修改后名称
     *
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $parentDeptId;

    /**
     * @description 空间类型
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'billingArea'  => 'billingArea',
        'buildingArea' => 'buildingArea',
        'buildingType' => 'buildingType',
        'deptId'       => 'deptId',
        'floor'        => 'floor',
        'houseState'   => 'houseState',
        'houseType'    => 'houseType',
        'name'         => 'name',
        'parentDeptId' => 'parentDeptId',
        'tagCode'      => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->billingArea) {
            $res['billingArea'] = $this->billingArea;
        }
        if (null !== $this->buildingArea) {
            $res['buildingArea'] = $this->buildingArea;
        }
        if (null !== $this->buildingType) {
            $res['buildingType'] = $this->buildingType;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->floor) {
            $res['floor'] = $this->floor;
        }
        if (null !== $this->houseState) {
            $res['houseState'] = $this->houseState;
        }
        if (null !== $this->houseType) {
            $res['houseType'] = $this->houseType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentDeptId) {
            $res['parentDeptId'] = $this->parentDeptId;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaceInfoVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['billingArea'])) {
            $model->billingArea = $map['billingArea'];
        }
        if (isset($map['buildingArea'])) {
            $model->buildingArea = $map['buildingArea'];
        }
        if (isset($map['buildingType'])) {
            $model->buildingType = $map['buildingType'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['floor'])) {
            $model->floor = $map['floor'];
        }
        if (isset($map['houseState'])) {
            $model->houseState = $map['houseState'];
        }
        if (isset($map['houseType'])) {
            $model->houseType = $map['houseType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentDeptId'])) {
            $model->parentDeptId = $map['parentDeptId'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
