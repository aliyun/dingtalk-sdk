<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeQueryStudentInfoByDeptRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 11111
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example 22222
     *
     * @var int
     */
    public $studentId;
    protected $_name = [
        'deptId' => 'deptId',
        'studentId' => 'studentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeQueryStudentInfoByDeptRequest
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

        return $model;
    }
}
