<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRoleUsersRequest extends Model
{
    /**
     * @description 角色id
     *
     * @var string
     */
    public $roleId;
    protected $_name = [
        'roleId' => 'roleId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRoleUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }

        return $model;
    }
}
