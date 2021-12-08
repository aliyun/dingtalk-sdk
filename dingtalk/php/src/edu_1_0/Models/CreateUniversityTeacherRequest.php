<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUniversityTeacherRequest extends Model
{
    /**
     * @description isvOrgId
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 班级ID
     *
     * @var int
     */
    public $classId;

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

    /**
     * @description suiteKey
     *
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description 操作人用户ID
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description opOrgId
     *
     * @var int
     */
    public $dingOrgId;
    protected $_name = [
        'dingIsvOrgId'  => 'dingIsvOrgId',
        'classId'       => 'classId',
        'role'          => 'role',
        'teacherUserId' => 'teacherUserId',
        'dingSuiteKey'  => 'dingSuiteKey',
        'opUserId'      => 'opUserId',
        'dingOrgId'     => 'dingOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }

        return $model;
    }
}
