<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content\group\leader;
use AlibabaCloud\Tea\Model;

class group extends Model
{
    /**
     * @description 医疗组id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 医疗组状态
     *
     * @var int
     */
    public $deptStatus;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @description id
     *
     * @var int
     */
    public $id;

    /**
     * @description 组长
     *
     * @var leader
     */
    public $leader;

    /**
     * @description 医疗组名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 父code
     *
     * @var string
     */
    public $parentDeptCode;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'deptId'         => 'deptId',
        'deptStatus'     => 'deptStatus',
        'gmtCreateStr'   => 'gmtCreateStr',
        'gmtModifiedStr' => 'gmtModifiedStr',
        'id'             => 'id',
        'leader'         => 'leader',
        'name'           => 'name',
        'parentDeptCode' => 'parentDeptCode',
        'remark'         => 'remark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptStatus) {
            $res['deptStatus'] = $this->deptStatus;
        }
        if (null !== $this->gmtCreateStr) {
            $res['gmtCreateStr'] = $this->gmtCreateStr;
        }
        if (null !== $this->gmtModifiedStr) {
            $res['gmtModifiedStr'] = $this->gmtModifiedStr;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->leader) {
            $res['leader'] = null !== $this->leader ? $this->leader->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentDeptCode) {
            $res['parentDeptCode'] = $this->parentDeptCode;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return group
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptStatus'])) {
            $model->deptStatus = $map['deptStatus'];
        }
        if (isset($map['gmtCreateStr'])) {
            $model->gmtCreateStr = $map['gmtCreateStr'];
        }
        if (isset($map['gmtModifiedStr'])) {
            $model->gmtModifiedStr = $map['gmtModifiedStr'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['leader'])) {
            $model->leader = leader::fromMap($map['leader']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentDeptCode'])) {
            $model->parentDeptCode = $map['parentDeptCode'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
