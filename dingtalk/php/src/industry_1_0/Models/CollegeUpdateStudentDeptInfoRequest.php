<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateStudentDeptInfoRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 学生id
     *
     * @var int
     */
    public $studentId;

    /**
     * @description 学号
     *
     * @var string
     */
    public $studentNumber;
    protected $_name = [
        'deptId'        => 'deptId',
        'studentId'     => 'studentId',
        'studentNumber' => 'studentNumber',
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
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeUpdateStudentDeptInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }

        return $model;
    }
}
