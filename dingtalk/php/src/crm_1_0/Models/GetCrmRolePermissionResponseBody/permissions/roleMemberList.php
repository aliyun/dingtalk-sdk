<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class roleMemberList extends Model
{
    /**
     * @description 角色名
     *
     * @var string
     */
    public $name;

    /**
     * @description 角色的userId
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 角色类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 角色值
     *
     * @var string
     */
    public $memberId;
    protected $_name = [
        'name'     => 'name',
        'staffId'  => 'staffId',
        'type'     => 'type',
        'memberId' => 'memberId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }

        return $model;
    }
}
