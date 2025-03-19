<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterCustomAppRoleRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $canManageRole;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'canManageRole' => 'canManageRole',
        'opUserId' => 'opUserId',
        'roleName' => 'roleName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
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
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
