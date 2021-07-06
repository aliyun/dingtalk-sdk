<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 角色编码
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 角色名称
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
     * @return content
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
