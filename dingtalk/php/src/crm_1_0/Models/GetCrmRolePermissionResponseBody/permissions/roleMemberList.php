<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class roleMemberList extends Model
{
    /**
     * @description 角色值
     *
     * @var string
     */
    public $memberId;

    /**
     * @description 角色名
     *
     * @var string
     */
    public $name;

    /**
     * @description 角色类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 角色的userId
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
