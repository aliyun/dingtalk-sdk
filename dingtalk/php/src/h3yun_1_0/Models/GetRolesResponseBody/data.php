<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data\roleGroups;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data\roles;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 角色组数组
     *
     * @var roleGroups[]
     */
    public $roleGroups;

    /**
     * @description 角色数组
     *
     * @var roles[]
     */
    public $roles;
    protected $_name = [
        'roleGroups' => 'roleGroups',
        'roles'      => 'roles',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleGroups) {
            $res['roleGroups'] = [];
            if (null !== $this->roleGroups && \is_array($this->roleGroups)) {
                $n = 0;
                foreach ($this->roleGroups as $item) {
                    $res['roleGroups'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roles) {
            $res['roles'] = [];
            if (null !== $this->roles && \is_array($this->roles)) {
                $n = 0;
                foreach ($this->roles as $item) {
                    $res['roles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleGroups'])) {
            if (!empty($map['roleGroups'])) {
                $model->roleGroups = [];
                $n                 = 0;
                foreach ($map['roleGroups'] as $item) {
                    $model->roleGroups[$n++] = null !== $item ? roleGroups::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roles'])) {
            if (!empty($map['roles'])) {
                $model->roles = [];
                $n            = 0;
                foreach ($map['roles'] as $item) {
                    $model->roles[$n++] = null !== $item ? roles::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
