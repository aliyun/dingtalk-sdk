<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateDingPortalPageScopeRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $allVisible;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @var int[]
     */
    public $roleIds;

    /**
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
