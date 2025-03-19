<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSpaceRequest extends Model
{
    /**
     * @var float
     */
    public $billingArea;

    /**
     * @var float
     */
    public $buildingArea;

    /**
     * @var string
     */
    public $floor;

    /**
     * @var int
     */
    public $houseState;

    /**
     * @description This parameter is required.
     *
     * @example A栋
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example -7
     *
     * @var string
     */
    public $parentDeptId;

    /**
     * @description This parameter is required.
     *
     * @example House
     *
     * @var string
     */
    public $tagCode;

    /**
     * @example 2
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'billingArea' => 'billingArea',
        'buildingArea' => 'buildingArea',
        'floor' => 'floor',
        'houseState' => 'houseState',
        'name' => 'name',
        'parentDeptId' => 'parentDeptId',
        'tagCode' => 'tagCode',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->billingArea) {
            $res['billingArea'] = $this->billingArea;
        }
        if (null !== $this->buildingArea) {
            $res['buildingArea'] = $this->buildingArea;
        }
        if (null !== $this->floor) {
            $res['floor'] = $this->floor;
        }
        if (null !== $this->houseState) {
            $res['houseState'] = $this->houseState;
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
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSpaceRequest
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
        if (isset($map['floor'])) {
            $model->floor = $map['floor'];
        }
        if (isset($map['houseState'])) {
            $model->houseState = $map['houseState'];
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
