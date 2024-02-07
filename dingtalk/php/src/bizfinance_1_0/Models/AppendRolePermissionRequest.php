<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionRequest\rolePermissionItemList;
use AlibabaCloud\Tea\Model;

class AppendRolePermissionRequest extends Model
{
    /**
     * @var rolePermissionItemList[]
     */
    public $rolePermissionItemList;

    /**
     * @example 5041234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'rolePermissionItemList' => 'rolePermissionItemList',
        'userId'                 => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->rolePermissionItemList) {
            $res['rolePermissionItemList'] = [];
            if (null !== $this->rolePermissionItemList && \is_array($this->rolePermissionItemList)) {
                $n = 0;
                foreach ($this->rolePermissionItemList as $item) {
                    $res['rolePermissionItemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppendRolePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['rolePermissionItemList'])) {
            if (!empty($map['rolePermissionItemList'])) {
                $model->rolePermissionItemList = [];
                $n                             = 0;
                foreach ($map['rolePermissionItemList'] as $item) {
                    $model->rolePermissionItemList[$n++] = null !== $item ? rolePermissionItemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
