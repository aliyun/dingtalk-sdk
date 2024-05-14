<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRoleUsersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 34ddd46f-e6c4-4eb0-b63a-aac0dd9232b0
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
