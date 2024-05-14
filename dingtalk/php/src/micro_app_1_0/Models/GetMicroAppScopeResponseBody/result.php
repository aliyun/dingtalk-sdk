<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetMicroAppScopeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $onlyAdminVisible;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $roleIds;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'deptIds'          => 'deptIds',
        'onlyAdminVisible' => 'onlyAdminVisible',
        'roleIds'          => 'roleIds',
        'userIds'          => 'userIds',
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
        if (null !== $this->onlyAdminVisible) {
            $res['onlyAdminVisible'] = $this->onlyAdminVisible;
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['onlyAdminVisible'])) {
            $model->onlyAdminVisible = $map['onlyAdminVisible'];
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
