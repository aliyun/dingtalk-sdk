<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetMicroAppScopeRequest extends Model
{
    /**
     * @description 增加的可见用户
     *
     * @var string[]
     */
    public $addUserIds;

    /**
     * @description 删除的可见用户
     *
     * @var string[]
     */
    public $delUserIds;

    /**
     * @description 增加的可见部门
     *
     * @var int[]
     */
    public $addDeptIds;

    /**
     * @description 删除的可见部门
     *
     * @var int[]
     */
    public $delDeptIds;

    /**
     * @description 增加的可见角色
     *
     * @var int[]
     */
    public $addRoleIds;

    /**
     * @description 删除的可见角色
     *
     * @var int[]
     */
    public $ddUserIds;

    /**
     * @description 是否管理员可见
     *
     * @var bool
     */
    public $onlyAdminVisible;
    protected $_name = [
        'addUserIds'       => 'addUserIds',
        'delUserIds'       => 'delUserIds',
        'addDeptIds'       => 'addDeptIds',
        'delDeptIds'       => 'delDeptIds',
        'addRoleIds'       => 'addRoleIds',
        'ddUserIds'        => 'ddUserIds',
        'onlyAdminVisible' => 'onlyAdminVisible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->addUserIds) {
            $res['addUserIds'] = $this->addUserIds;
        }
        if (null !== $this->delUserIds) {
            $res['delUserIds'] = $this->delUserIds;
        }
        if (null !== $this->addDeptIds) {
            $res['addDeptIds'] = $this->addDeptIds;
        }
        if (null !== $this->delDeptIds) {
            $res['delDeptIds'] = $this->delDeptIds;
        }
        if (null !== $this->addRoleIds) {
            $res['addRoleIds'] = $this->addRoleIds;
        }
        if (null !== $this->ddUserIds) {
            $res['ddUserIds'] = $this->ddUserIds;
        }
        if (null !== $this->onlyAdminVisible) {
            $res['onlyAdminVisible'] = $this->onlyAdminVisible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetMicroAppScopeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['addUserIds'])) {
            if (!empty($map['addUserIds'])) {
                $model->addUserIds = $map['addUserIds'];
            }
        }
        if (isset($map['delUserIds'])) {
            if (!empty($map['delUserIds'])) {
                $model->delUserIds = $map['delUserIds'];
            }
        }
        if (isset($map['addDeptIds'])) {
            if (!empty($map['addDeptIds'])) {
                $model->addDeptIds = $map['addDeptIds'];
            }
        }
        if (isset($map['delDeptIds'])) {
            if (!empty($map['delDeptIds'])) {
                $model->delDeptIds = $map['delDeptIds'];
            }
        }
        if (isset($map['addRoleIds'])) {
            if (!empty($map['addRoleIds'])) {
                $model->addRoleIds = $map['addRoleIds'];
            }
        }
        if (isset($map['ddUserIds'])) {
            if (!empty($map['ddUserIds'])) {
                $model->ddUserIds = $map['ddUserIds'];
            }
        }
        if (isset($map['onlyAdminVisible'])) {
            $model->onlyAdminVisible = $map['onlyAdminVisible'];
        }

        return $model;
    }
}
