<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class roleMemberList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 可以是员工 uid，可以是部门 ID 等，根据 type 确定
     *
     * @var string
     */
    public $memberId;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example user：组织成员   dept：部门   tag：标签  org：组织     org_res_admin：组织管理员
     *
     * @var string
     */
    public $type;

    /**
     * @example manager1234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'memberId' => 'memberId',
        'name'     => 'name',
        'type'     => 'type',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleMemberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
