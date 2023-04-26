<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListResponseBody\result;

use AlibabaCloud\Tea\Model;

class teacherDetails extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example teacher
     *
     * @var string
     */
    public $role;

    /**
     * @example 人员的unionId。
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 77621233
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'    => 'name',
        'role'    => 'role',
        'unionId' => 'unionId',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teacherDetails
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
