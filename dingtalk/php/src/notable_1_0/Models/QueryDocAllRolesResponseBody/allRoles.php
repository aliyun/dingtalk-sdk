<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody\allRoles\members;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody\allRoles\role;
use AlibabaCloud\Tea\Model;

class allRoles extends Model
{
    /**
     * @var members[]
     */
    public $members;

    /**
     * @var role
     */
    public $role;
    protected $_name = [
        'members' => 'members',
        'role' => 'role',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->role) {
            $res['role'] = null !== $this->role ? $this->role->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return allRoles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['role'])) {
            $model->role = role::fromMap($map['role']);
        }

        return $model;
    }
}
