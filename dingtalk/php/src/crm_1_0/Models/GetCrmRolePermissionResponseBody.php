<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;
use AlibabaCloud\Tea\Model;

class GetCrmRolePermissionResponseBody extends Model
{
    /**
     * @description CRM表单权限配置
     *
     * @var permissions[]
     */
    public $permissions;
    protected $_name = [
        'permissions' => 'permissions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissions) {
            $res['permissions'] = [];
            if (null !== $this->permissions && \is_array($this->permissions)) {
                $n = 0;
                foreach ($this->permissions as $item) {
                    $res['permissions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCrmRolePermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissions'])) {
            if (!empty($map['permissions'])) {
                $model->permissions = [];
                $n                  = 0;
                foreach ($map['permissions'] as $item) {
                    $model->permissions[$n++] = null !== $item ? permissions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
