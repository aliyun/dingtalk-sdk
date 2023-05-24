<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplAddRoleRequest extends Model
{
    /**
     * @var string
     */
    public $parentRoleGroupId;

    /**
     * @var string
     */
    public $roleName;
    protected $_name = [
        'parentRoleGroupId' => 'parentRoleGroupId',
        'roleName'          => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->parentRoleGroupId) {
            $res['parentRoleGroupId'] = $this->parentRoleGroupId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplAddRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['parentRoleGroupId'])) {
            $model->parentRoleGroupId = $map['parentRoleGroupId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
