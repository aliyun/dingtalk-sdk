<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAppRoleScopeByRoleIdResponseBody extends Model
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

    /**
     * @description 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
     *
     * @var string
     */
    public $scopeType;

    /**
     * @description 部门id列表
     *
     * @var int[]
     */
    public $deptIdList;

    /**
     * @description 员工userId列表
     *
     * @var string[]
     */
    public $userIdList;

    /**
     * @description 角色范围版本号
     *
     * @var string
     */
    public $scopeVersion;
    protected $_name = [
        'roleName'     => 'roleName',
        'roleId'       => 'roleId',
        'scopeType'    => 'scopeType',
        'deptIdList'   => 'deptIdList',
        'userIdList'   => 'userIdList',
        'scopeVersion' => 'scopeVersion',
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
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->scopeVersion) {
            $res['scopeVersion'] = $this->scopeVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppRoleScopeByRoleIdResponseBody
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
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }
        if (isset($map['scopeVersion'])) {
            $model->scopeVersion = $map['scopeVersion'];
        }

        return $model;
    }
}
