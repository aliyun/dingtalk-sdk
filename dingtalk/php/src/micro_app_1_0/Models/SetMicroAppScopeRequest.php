<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetMicroAppScopeRequest extends Model
{
    /**
     * @var int[]
     */
    public $addDeptIds;

    /**
     * @var int[]
     */
    public $addRoleIds;

    /**
     * @var string[]
     */
    public $addUserIds;

    /**
     * @var int[]
     */
    public $delDeptIds;

    /**
     * @var int[]
     */
    public $delRoleIds;

    /**
     * @var string[]
     */
    public $delUserIds;

    /**
     * @var bool
     */
    public $onlyAdminVisible;
    protected $_name = [
        'addDeptIds'       => 'addDeptIds',
        'addRoleIds'       => 'addRoleIds',
        'addUserIds'       => 'addUserIds',
        'delDeptIds'       => 'delDeptIds',
        'delRoleIds'       => 'delRoleIds',
        'delUserIds'       => 'delUserIds',
        'onlyAdminVisible' => 'onlyAdminVisible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->addDeptIds) {
            $res['addDeptIds'] = $this->addDeptIds;
        }
        if (null !== $this->addRoleIds) {
            $res['addRoleIds'] = $this->addRoleIds;
        }
        if (null !== $this->addUserIds) {
            $res['addUserIds'] = $this->addUserIds;
        }
        if (null !== $this->delDeptIds) {
            $res['delDeptIds'] = $this->delDeptIds;
        }
        if (null !== $this->delRoleIds) {
            $res['delRoleIds'] = $this->delRoleIds;
        }
        if (null !== $this->delUserIds) {
            $res['delUserIds'] = $this->delUserIds;
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
        if (isset($map['addDeptIds'])) {
            if (!empty($map['addDeptIds'])) {
                $model->addDeptIds = $map['addDeptIds'];
            }
        }
        if (isset($map['addRoleIds'])) {
            if (!empty($map['addRoleIds'])) {
                $model->addRoleIds = $map['addRoleIds'];
            }
        }
        if (isset($map['addUserIds'])) {
            if (!empty($map['addUserIds'])) {
                $model->addUserIds = $map['addUserIds'];
            }
        }
        if (isset($map['delDeptIds'])) {
            if (!empty($map['delDeptIds'])) {
                $model->delDeptIds = $map['delDeptIds'];
            }
        }
        if (isset($map['delRoleIds'])) {
            if (!empty($map['delRoleIds'])) {
                $model->delRoleIds = $map['delRoleIds'];
            }
        }
        if (isset($map['delUserIds'])) {
            if (!empty($map['delUserIds'])) {
                $model->delUserIds = $map['delUserIds'];
            }
        }
        if (isset($map['onlyAdminVisible'])) {
            $model->onlyAdminVisible = $map['onlyAdminVisible'];
        }

        return $model;
    }
}
