<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListSubSpaceResponseBody;

use AlibabaCloud\Tea\Model;

class spaceList extends Model
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
     * @description 房屋状态：0空置/1未领/2入住/3空关/4装修
     *
     * @var int
     */
    public $houseState;

    /**
     * @var int
     */
    public $isVirtual;

    /**
     * @var int
     */
    public $parentReferId;

    /**
     * @var int
     */
    public $referId;

    /**
     * @var string
     */
    public $spaceName;

    /**
     * @var string
     */
    public $tagCode;

    /**
     * @description 空间类型为楼时，1高层/2低层/3别墅/4其他，空间类型为房屋是，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'billingArea'   => 'billingArea',
        'buildingArea'  => 'buildingArea',
        'floor'         => 'floor',
        'houseState'    => 'houseState',
        'isVirtual'     => 'isVirtual',
        'parentReferId' => 'parentReferId',
        'referId'       => 'referId',
        'spaceName'     => 'spaceName',
        'tagCode'       => 'tagCode',
        'type'          => 'type',
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
        if (null !== $this->isVirtual) {
            $res['isVirtual'] = $this->isVirtual;
        }
        if (null !== $this->parentReferId) {
            $res['parentReferId'] = $this->parentReferId;
        }
        if (null !== $this->referId) {
            $res['referId'] = $this->referId;
        }
        if (null !== $this->spaceName) {
            $res['spaceName'] = $this->spaceName;
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
     * @return spaceList
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
        if (isset($map['isVirtual'])) {
            $model->isVirtual = $map['isVirtual'];
        }
        if (isset($map['parentReferId'])) {
            $model->parentReferId = $map['parentReferId'];
        }
        if (isset($map['referId'])) {
            $model->referId = $map['referId'];
        }
        if (isset($map['spaceName'])) {
            $model->spaceName = $map['spaceName'];
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
