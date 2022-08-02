<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeQueryCollegeDeptInfoResponseBody extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 部门类型
     *
     * @var string
     */
    public $deptType;

    /**
     * @description 排序因子
     *
     * @var int
     */
    public $sortFactor;

    /**
     * @description 父部门编号
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'deptId'     => 'deptId',
        'deptName'   => 'deptName',
        'deptType'   => 'deptType',
        'sortFactor' => 'sortFactor',
        'superId'    => 'superId',
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
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->sortFactor) {
            $res['sortFactor'] = $this->sortFactor;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeQueryCollegeDeptInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['sortFactor'])) {
            $model->sortFactor = $map['sortFactor'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
