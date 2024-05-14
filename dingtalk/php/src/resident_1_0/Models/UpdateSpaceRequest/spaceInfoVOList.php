<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateSpaceRequest;

use AlibabaCloud\Tea\Model;

class spaceInfoVOList extends Model
{
    /**
     * @example 123.4
     *
     * @var float
     */
    public $billingArea;

    /**
     * @example 123.4
     *
     * @var float
     */
    public $buildingArea;

    /**
     * @example 当tagcode为Building的时候必填
     *
     * @var int
     */
    public $buildingType;

    /**
     * @description This parameter is required.
     *
     * @example 10005
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 12
     *
     * @var string
     */
    public $floor;

    /**
     * @example 1
     *
     * @var int
     */
    public $houseState;

    /**
     * @example 1
     *
     * @var int
     */
    public $houseType;

    /**
     * @example 二单元
     *
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $parentDeptId;

    /**
     * @description This parameter is required.
     *
     * @example 空间类型标签code，House/Unit/Building/Partition
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
