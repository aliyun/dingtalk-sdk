<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions\managingScopeList;

use AlibabaCloud\Tea\Model;

class ext extends Model
{
    /**
     * @description 管理部门列表
     *
     * @var float[]
     */
    public $deptIdList;

    /**
     * @description 管理员工列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'deptIdList' => 'deptIdList',
        'userIdList' => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
