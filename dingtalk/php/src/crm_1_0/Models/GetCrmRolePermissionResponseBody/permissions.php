<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\fieldScopes;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\managingScopeList;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\operateScopes;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\roleMemberList;
use AlibabaCloud\Tea\Model;

class permissions extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $defaultRole;

    /**
     * @description This parameter is required.
     *
     * @var fieldScopes[]
     */
    public $fieldScopes;

    /**
     * @description This parameter is required.
     *
     * @var managingScopeList[]
     */
    public $managingScopeList;

    /**
     * @description This parameter is required.
     *
     * @var operateScopes[]
     */
    public $operateScopes;

    /**
     * @description This parameter is required.
     *
     * @example PROC-478E50CA-856C-4C08-B806-E664D4CEC8C4
     *
     * @var string
     */
    public $resourceId;

    /**
     * @description This parameter is required.
     *
     * @example 12821738
     *
     * @var float
     */
    public $roleId;

    /**
     * @description This parameter is required.
     *
     * @var roleMemberList[]
     */
    public $roleMemberList;

    /**
     * @description This parameter is required.
     *
     * @example 销售权限组
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'defaultRole'       => 'defaultRole',
        'fieldScopes'       => 'fieldScopes',
        'managingScopeList' => 'managingScopeList',
        'operateScopes'     => 'operateScopes',
        'resourceId'        => 'resourceId',
        'roleId'            => 'roleId',
        'roleMemberList'    => 'roleMemberList',
        'roleName'          => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultRole) {
            $res['defaultRole'] = $this->defaultRole;
        }
        if (null !== $this->fieldScopes) {
            $res['fieldScopes'] = [];
            if (null !== $this->fieldScopes && \is_array($this->fieldScopes)) {
                $n = 0;
                foreach ($this->fieldScopes as $item) {
                    $res['fieldScopes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->managingScopeList) {
            $res['managingScopeList'] = [];
            if (null !== $this->managingScopeList && \is_array($this->managingScopeList)) {
                $n = 0;
                foreach ($this->managingScopeList as $item) {
                    $res['managingScopeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operateScopes) {
            $res['operateScopes'] = [];
            if (null !== $this->operateScopes && \is_array($this->operateScopes)) {
                $n = 0;
                foreach ($this->operateScopes as $item) {
                    $res['operateScopes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->resourceId) {
            $res['resourceId'] = $this->resourceId;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->roleMemberList) {
            $res['roleMemberList'] = [];
            if (null !== $this->roleMemberList && \is_array($this->roleMemberList)) {
                $n = 0;
                foreach ($this->roleMemberList as $item) {
                    $res['roleMemberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permissions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultRole'])) {
            $model->defaultRole = $map['defaultRole'];
        }
        if (isset($map['fieldScopes'])) {
            if (!empty($map['fieldScopes'])) {
                $model->fieldScopes = [];
                $n                  = 0;
                foreach ($map['fieldScopes'] as $item) {
                    $model->fieldScopes[$n++] = null !== $item ? fieldScopes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['managingScopeList'])) {
            if (!empty($map['managingScopeList'])) {
                $model->managingScopeList = [];
                $n                        = 0;
                foreach ($map['managingScopeList'] as $item) {
                    $model->managingScopeList[$n++] = null !== $item ? managingScopeList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operateScopes'])) {
            if (!empty($map['operateScopes'])) {
                $model->operateScopes = [];
                $n                    = 0;
                foreach ($map['operateScopes'] as $item) {
                    $model->operateScopes[$n++] = null !== $item ? operateScopes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resourceId'])) {
            $model->resourceId = $map['resourceId'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['roleMemberList'])) {
            if (!empty($map['roleMemberList'])) {
                $model->roleMemberList = [];
                $n                     = 0;
                foreach ($map['roleMemberList'] as $item) {
                    $model->roleMemberList[$n++] = null !== $item ? roleMemberList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
