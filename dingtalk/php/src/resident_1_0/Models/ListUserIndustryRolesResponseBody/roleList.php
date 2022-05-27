<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUserIndustryRolesResponseBody;

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
     * @description 角色名字
     *
     * @var string
     */
    public $roleName;

    /**
     * @description 行业角色编码
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'roleId'   => 'roleId',
        'roleName' => 'roleName',
        'tagCode'  => 'tagCode',
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
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
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
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
