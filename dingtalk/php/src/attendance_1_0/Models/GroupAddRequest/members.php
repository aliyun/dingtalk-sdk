<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example Attendance
     *
     * @var string
     */
    public $role;

    /**
     * @description This parameter is required.
     *
     * @example StaffMember
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example 1212jfkd
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'role'   => 'role',
        'type'   => 'type',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
