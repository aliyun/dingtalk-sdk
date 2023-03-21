<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryUserRoleListResponseBody;

use AlibabaCloud\Tea\Model;

class roleVOList extends Model
{
    /**
     * @description 角色Code
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 角色名字
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'roleCode' => 'roleCode',
        'roleName' => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
