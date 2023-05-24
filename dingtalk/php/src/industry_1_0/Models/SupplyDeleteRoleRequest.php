<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyDeleteRoleRequest extends Model
{
    /**
     * @var bool
     */
    public $isRoleGroup;

    /**
     * @var string
     */
    public $roleId;
    protected $_name = [
        'isRoleGroup' => 'isRoleGroup',
        'roleId'      => 'roleId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isRoleGroup) {
            $res['isRoleGroup'] = $this->isRoleGroup;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyDeleteRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isRoleGroup'])) {
            $model->isRoleGroup = $map['isRoleGroup'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }

        return $model;
    }
}
