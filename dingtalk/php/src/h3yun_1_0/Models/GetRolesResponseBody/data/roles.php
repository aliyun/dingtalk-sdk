<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @description 所属企业id
     *
     * @var string
     */
    public $companyId;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 所属的角色组id
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 角色编码
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 角色id
     *
     * @var string
     */
    public $roleId;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $roleName;

    /**
     * @description 状态。Active=激活、Inactive=未激活，Unspecified=未指定状态
     *
     * @var string
     */
    public $state;

    /**
     * @description 可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'companyId'   => 'companyId',
        'description' => 'description',
        'groupId'     => 'groupId',
        'roleCode'    => 'roleCode',
        'roleId'      => 'roleId',
        'roleName'    => 'roleName',
        'state'       => 'state',
        'visibility'  => 'visibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyId) {
            $res['companyId'] = $this->companyId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
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
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyId'])) {
            $model->companyId = $map['companyId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
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
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
