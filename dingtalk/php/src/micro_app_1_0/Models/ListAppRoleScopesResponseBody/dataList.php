<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListAppRoleScopesResponseBody;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $canManageRole;

    /**
     * @var int[]
     */
    public $deptIdList;

    /**
     * @example 123
     *
     * @var int
     */
    public $roleId;

    /**
     * @example 财务
     *
     * @var string
     */
    public $roleName;

    /**
     * @example PART_VISIBLE
     *
     * @var string
     */
    public $scopeType;

    /**
     * @example 123
     *
     * @var int
     */
    public $scopeVersion;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'canManageRole' => 'canManageRole',
        'deptIdList' => 'deptIdList',
        'roleId' => 'roleId',
        'roleName' => 'roleName',
        'scopeType' => 'scopeType',
        'scopeVersion' => 'scopeVersion',
        'userIdList' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->scopeVersion) {
            $res['scopeVersion'] = $this->scopeVersion;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['scopeVersion'])) {
            $model->scopeVersion = $map['scopeVersion'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
