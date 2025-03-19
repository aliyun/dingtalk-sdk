<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $companyId;

    /**
     * @example 这是一个游客体验角色
     *
     * @var string
     */
    public $description;

    /**
     * @example 261befb8-728d-4b79-a0b4-7b6ddfb3f94e
     *
     * @var string
     */
    public $groupId;

    /**
     * @example 88cfc4a2-22ba-48e2-bc5e-8d475ce49d38
     *
     * @var string
     */
    public $roleCode;

    /**
     * @example 085b47cf-ab7b-417f-bb7a-b5ee3b32de16
     *
     * @var string
     */
    public $roleId;

    /**
     * @example 游客体验角色
     *
     * @var string
     */
    public $roleName;

    /**
     * @example Active
     *
     * @var string
     */
    public $state;

    /**
     * @example All
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'companyId' => 'companyId',
        'description' => 'description',
        'groupId' => 'groupId',
        'roleCode' => 'roleCode',
        'roleId' => 'roleId',
        'roleName' => 'roleName',
        'state' => 'state',
        'visibility' => 'visibility',
    ];

    public function validate() {}

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
