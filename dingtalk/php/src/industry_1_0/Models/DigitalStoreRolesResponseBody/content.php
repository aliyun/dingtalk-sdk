<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRolesResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 优先级
     *
     * @var int
     */
    public $level;

    /**
     * @description 角色Code
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 角色Id
     *
     * @var int
     */
    public $roleId;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'level'    => 'level',
        'roleCode' => 'roleCode',
        'roleId'   => 'roleId',
        'roleName' => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
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
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
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
