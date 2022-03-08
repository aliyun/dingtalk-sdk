<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteUniversityStudentRequest extends Model
{
    /**
     * @description 班级ID
     *
     * @var int
     */
    public $classId;

    /**
     * @description 操作人用户ID
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 学生用户ID
     *
     * @var string
     */
    public $studentUserId;
    protected $_name = [
        'classId'       => 'classId',
        'opUserId'      => 'opUserId',
        'studentUserId' => 'studentUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteUniversityStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }

        return $model;
    }
}
