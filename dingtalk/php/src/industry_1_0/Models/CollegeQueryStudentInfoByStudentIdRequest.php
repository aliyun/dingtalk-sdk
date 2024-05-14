<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeQueryStudentInfoByStudentIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 22222
     *
     * @var int
     */
    public $studentId;
    protected $_name = [
        'studentId' => 'studentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeQueryStudentInfoByStudentIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }

        return $model;
    }
}
