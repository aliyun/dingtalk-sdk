<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionRequest\rolePermissionItemList\permissionList;
use AlibabaCloud\Tea\Model;

class rolePermissionItemList extends Model
{
    /**
     * @var permissionList[]
     */
    public $permissionList;

    /**
     * @example financeManager
     *
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'permissionList' => 'permissionList',
        'roleCode'       => 'roleCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionList) {
            $res['permissionList'] = [];
            if (null !== $this->permissionList && \is_array($this->permissionList)) {
                $n = 0;
                foreach ($this->permissionList as $item) {
                    $res['permissionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rolePermissionItemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionList'])) {
            if (!empty($map['permissionList'])) {
                $model->permissionList = [];
                $n                     = 0;
                foreach ($map['permissionList'] as $item) {
                    $model->permissionList[$n++] = null !== $item ? permissionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
