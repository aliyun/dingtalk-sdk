<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class AppendRolePermissionShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $rolePermissionItemListShrink;

    /**
     * @example 5041234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'rolePermissionItemListShrink' => 'rolePermissionItemList',
        'userId'                       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->rolePermissionItemListShrink) {
            $res['rolePermissionItemList'] = $this->rolePermissionItemListShrink;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppendRolePermissionShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['rolePermissionItemList'])) {
            $model->rolePermissionItemListShrink = $map['rolePermissionItemList'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
