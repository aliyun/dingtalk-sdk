<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAppRoleInfoRequest extends Model
{
    /**
     * @description 执行用户userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 变更角色名称，可不传，不传则不变
     *
     * @var string
     */
    public $newRoleName;

    /**
     * @description 变更角色管理权限，可不传，不传则不变
     *
     * @var bool
     */
    public $canManageRole;
    protected $_name = [
        'opUserId'      => 'opUserId',
        'newRoleName'   => 'newRoleName',
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
        if (null !== $this->newRoleName) {
            $res['newRoleName'] = $this->newRoleName;
        }
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAppRoleInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['newRoleName'])) {
            $model->newRoleName = $map['newRoleName'];
        }
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }

        return $model;
    }
}
