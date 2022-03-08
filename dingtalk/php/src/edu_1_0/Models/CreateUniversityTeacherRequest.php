<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUniversityTeacherRequest extends Model
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
     * @description 角色
     *
     * @var string
     */
    public $role;

    /**
     * @description 教师用户ID
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'classId'       => 'classId',
        'opUserId'      => 'opUserId',
        'role'          => 'role',
        'teacherUserId' => 'teacherUserId',
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
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUniversityTeacherRequest
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
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
