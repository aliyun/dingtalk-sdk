<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt;

use AlibabaCloud\Tea\Model;

class department extends Model
{
    /**
     * @example asd123
     *
     * @var string
     */
    public $deptCode;

    /**
     * @example 骨科
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 1
     *
     * @var int
     */
    public $deptOrder;

    /**
     * @example 0
     *
     * @var int
     */
    public $deptStatus;

    /**
     * @example 1
     *
     * @var int
     */
    public $deptType;

    /**
     * @example 2021-08-24 20:30:31
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @example 2021-08-24 20:30:31
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @example 130000
     *
     * @var int
     */
    public $id;

    /**
     * @example 骨科
     *
     * @var string
     */
    public $name;

    /**
     * @example asd123
     *
     * @var string
     */
    public $parentDeptCode;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @var int[]
     */
    public $wardIdList;
    protected $_name = [
        'deptCode'       => 'deptCode',
        'deptName'       => 'deptName',
        'deptOrder'      => 'deptOrder',
        'deptStatus'     => 'deptStatus',
        'deptType'       => 'deptType',
        'gmtCreateStr'   => 'gmtCreateStr',
        'gmtModifiedStr' => 'gmtModifiedStr',
        'id'             => 'id',
        'name'           => 'name',
        'parentDeptCode' => 'parentDeptCode',
        'remark'         => 'remark',
        'wardIdList'     => 'wardIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptOrder) {
            $res['deptOrder'] = $this->deptOrder;
        }
        if (null !== $this->deptStatus) {
            $res['deptStatus'] = $this->deptStatus;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentDeptCode) {
            $res['parentDeptCode'] = $this->parentDeptCode;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->wardIdList) {
            $res['wardIdList'] = $this->wardIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return department
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptOrder'])) {
            $model->deptOrder = $map['deptOrder'];
        }
        if (isset($map['deptStatus'])) {
            $model->deptStatus = $map['deptStatus'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentDeptCode'])) {
            $model->parentDeptCode = $map['parentDeptCode'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['wardIdList'])) {
            if (!empty($map['wardIdList'])) {
                $model->wardIdList = $map['wardIdList'];
            }
        }

        return $model;
    }
}
