<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAppRoleInfoRequest extends Model
{
    /**
     * @description 变更角色管理权限，可不传，不传则不变
     *
     * @var bool
     */
    public $canManageRole;

    /**
     * @description 变更角色名称，可不传，不传则不变
     *
     * @var string
     */
    public $newRoleName;

    /**
     * @description 执行用户userId
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'canManageRole' => 'canManageRole',
        'newRoleName'   => 'newRoleName',
        'opUserId'      => 'opUserId',
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
        if (null !== $this->newRoleName) {
            $res['newRoleName'] = $this->newRoleName;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
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
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }
        if (isset($map['newRoleName'])) {
            $model->newRoleName = $map['newRoleName'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
