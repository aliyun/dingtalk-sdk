<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\Tea\Model;

class roleList extends Model
{
    /**
     * @description 角色id
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

    /**
     * @description 角色组名称
     *
     * @var string
     */
    public $groupName;
    protected $_name = [
        'roleId'    => 'roleId',
        'roleName'  => 'roleName',
        'groupName' => 'groupName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}
