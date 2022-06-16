<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateRequest;

use AlibabaCloud\Tea\Model;

class taskScopeVO extends Model
{
    /**
     * @description 按照部门圈人
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @description 按照职位圈人
     *
     * @var string[]
     */
    public $positionIds;

    /**
     * @description 按照角色圈人
     *
     * @var string[]
     */
    public $roleIds;

    /**
     * @description 按照员工userId圈人
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'deptIds'     => 'deptIds',
        'positionIds' => 'positionIds',
        'roleIds'     => 'roleIds',
        'userIds'     => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->positionIds) {
            $res['positionIds'] = $this->positionIds;
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return taskScopeVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['positionIds'])) {
            if (!empty($map['positionIds'])) {
                $model->positionIds = $map['positionIds'];
            }
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
