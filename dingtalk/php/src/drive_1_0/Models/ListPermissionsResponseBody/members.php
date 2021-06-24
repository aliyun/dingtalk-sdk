<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody\members\member;
use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 权限角色
     *
     * @var string
     */
    public $role;

    /**
     * @description 成员信息
     *
     * @var member
     */
    public $member;

    /**
     * @description 是否是继承的权限
     *
     * @var bool
     */
    public $extend;
    protected $_name = [
        'role'   => 'role',
        'member' => 'member',
        'extend' => 'extend',
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
        if (null !== $this->member) {
            $res['member'] = null !== $this->member ? $this->member->toMap() : null;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
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
        if (isset($map['member'])) {
            $model->member = member::fromMap($map['member']);
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }

        return $model;
    }
}
