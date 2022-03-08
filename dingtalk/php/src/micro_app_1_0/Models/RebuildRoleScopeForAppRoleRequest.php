<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RebuildRoleScopeForAppRoleRequest extends Model
{
    /**
     * @description 部门id列表
     *
     * @var int[]
     */
    public $deptIdList;

    /**
     * @description 执行用户userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
     *
     * @var string
     */
    public $scopeType;

    /**
     * @description 角色范围最新版本号
     *
     * @var int
     */
    public $scopeVersion;

    /**
     * @description 员工userId列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'deptIdList'   => 'deptIdList',
        'opUserId'     => 'opUserId',
        'scopeType'    => 'scopeType',
        'scopeVersion' => 'scopeVersion',
        'userIdList'   => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
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
     * @return RebuildRoleScopeForAppRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
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
