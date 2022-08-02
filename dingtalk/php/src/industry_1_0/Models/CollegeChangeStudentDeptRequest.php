<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeChangeStudentDeptRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 新部门id
     *
     * @var int
     */
    public $newDeptId;

    /**
     * @description 学生id
     *
     * @var int
     */
    public $studentId;
    protected $_name = [
        'deptId'    => 'deptId',
        'newDeptId' => 'newDeptId',
        'studentId' => 'studentId',
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
        if (null !== $this->newDeptId) {
            $res['newDeptId'] = $this->newDeptId;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeChangeStudentDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['newDeptId'])) {
            $model->newDeptId = $map['newDeptId'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }

        return $model;
    }
}
