<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListRoleInfoByUserResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $canManageRole;

    /**
     * @example 123
     *
     * @var int
     */
    public $roleId;

    /**
     * @example 财务
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'canManageRole' => 'canManageRole',
        'roleId'        => 'roleId',
        'roleName'      => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
