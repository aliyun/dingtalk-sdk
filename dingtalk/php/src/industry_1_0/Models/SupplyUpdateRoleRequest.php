<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyUpdateRoleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isRoleGroup;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $roleId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'isRoleGroup' => 'isRoleGroup',
        'roleId'      => 'roleId',
        'roleName'    => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isRoleGroup) {
            $res['isRoleGroup'] = $this->isRoleGroup;
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
     * @return SupplyUpdateRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isRoleGroup'])) {
            $model->isRoleGroup = $map['isRoleGroup'];
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
