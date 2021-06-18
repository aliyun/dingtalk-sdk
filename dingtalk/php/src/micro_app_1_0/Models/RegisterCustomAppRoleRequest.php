<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterCustomAppRoleRequest extends Model
{
    /**
     * @description 执行用户userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $roleName;

    /**
     * @description 是否拥有管理角色的权限，可不传，默认false
     *
     * @var bool
     */
    public $canManageRole;
    protected $_name = [
        'opUserId'      => 'opUserId',
        'roleName'      => 'roleName',
        'canManageRole' => 'canManageRole',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterCustomAppRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }

        return $model;
    }
}
