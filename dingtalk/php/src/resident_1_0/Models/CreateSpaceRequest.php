<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSpaceRequest extends Model
{
    /**
     * @description 仅当tag未房屋时有用
     *
     * @var float
     */
    public $billingArea;

    /**
     * @description 仅当tag未房屋时有用
     *
     * @var float
     */
    public $buildingArea;

    /**
     * @description 仅当tag未房屋时有用
     *
     * @var string
     */
    public $floor;

    /**
     * @description 仅当tag未房屋时有用
     *
     * @var int
     */
    public $houseState;

    /**
     * @description 空间名称，如A栋，二单元，406室等
     *
     * @var string
     */
    public $name;

    /**
     * @description 父节点id，根节点为-7
     *
     * @var string
     */
    public $parentDeptId;

    /**
     * @description 空间tag标识，目前有House/Unit/Building/Partition
     *
     * @var string
     */
    public $tagCode;

    /**
     * @description * 空间类型为楼时，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他      * 空间类型为房屋是，1普通住宅/2公寓/3排屋/4物业管理用房/5社区用房/6别墅/7商铺/8办公用房（商写）/9经营用房/10其他
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'billingArea'  => 'billingArea',
        'buildingArea' => 'buildingArea',
        'floor'        => 'floor',
        'houseState'   => 'houseState',
        'name'         => 'name',
        'parentDeptId' => 'parentDeptId',
        'tagCode'      => 'tagCode',
        'type'         => 'type',
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
