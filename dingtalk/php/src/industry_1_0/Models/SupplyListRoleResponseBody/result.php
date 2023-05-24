<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListRoleResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $isRoleGroup;

    /**
     * @example 123
     *
     * @var string
     */
    public $roleId;

    /**
     * @example 老板
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
     * @return result
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
