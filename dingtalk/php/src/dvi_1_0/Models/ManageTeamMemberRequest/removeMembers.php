<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberRequest;

use AlibabaCloud\Tea\Model;

class removeMembers extends Model
{
    /**
     * @var string[]
     */
    public $adminUserIds;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'adminUserIds' => 'adminUserIds',
        'deptIds' => 'deptIds',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminUserIds) {
            $res['adminUserIds'] = $this->adminUserIds;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return removeMembers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminUserIds'])) {
            if (!empty($map['adminUserIds'])) {
                $model->adminUserIds = $map['adminUserIds'];
            }
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
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
