<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateDingPortalPageScopeRequest extends Model
{
    /**
     * @description 是否全员可见
     *
     * @var bool
     */
    public $allVisible;

    /**
     * @description 可见部门列表
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @description 可见角色列表
     *
     * @var int[]
     */
    public $roleIds;

    /**
     * @description 可见用户列表
     *
     * @var string[]
     */
    public $userids;
    protected $_name = [
        'allVisible' => 'allVisible',
        'deptIds'    => 'deptIds',
        'roleIds'    => 'roleIds',
        'userids'    => 'userids',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allVisible) {
            $res['allVisible'] = $this->allVisible;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->userids) {
            $res['userids'] = $this->userids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateDingPortalPageScopeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allVisible'])) {
            $model->allVisible = $map['allVisible'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['userids'])) {
            if (!empty($map['userids'])) {
                $model->userids = $map['userids'];
            }
        }

        return $model;
    }
}
