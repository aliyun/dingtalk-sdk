<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListRoleInfoByUserResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 角色名称
     *
     * @var string
     */
    public $roleName;

    /**
     * @description 角色id
     *
     * @var int
     */
    public $roleId;
    protected $_name = [
        'roleName' => 'roleName',
        'roleId'   => 'roleId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
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
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }

        return $model;
    }
}
