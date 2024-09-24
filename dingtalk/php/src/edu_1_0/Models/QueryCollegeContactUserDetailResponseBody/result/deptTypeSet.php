<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class deptTypeSet extends Model
{
    /**
     * @example 123456
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 土木202班
     *
     * @var string
     */
    public $deptName;

    /**
     * @example stru_standard_dept
     *
     * @var string
     */
    public $deptStructType;

    /**
     * @example contact_class_dept
     *
     * @var string
     */
    public $deptType;

    /**
     * @example 10000
     *
     * @var int
     */
    public $structDeptId;
    protected $_name = [
        'deptId'         => 'deptId',
        'deptName'       => 'deptName',
        'deptStructType' => 'deptStructType',
        'deptType'       => 'deptType',
        'structDeptId'   => 'structDeptId',
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
        if (null !== $this->deptStructType) {
            $res['deptStructType'] = $this->deptStructType;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->structDeptId) {
            $res['structDeptId'] = $this->structDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptTypeSet
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
        if (isset($map['deptStructType'])) {
            $model->deptStructType = $map['deptStructType'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['structDeptId'])) {
            $model->structDeptId = $map['structDeptId'];
        }

        return $model;
    }
}
