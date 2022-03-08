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
    public $staffIdList;
    protected $_name = [
        'deptIdList'  => 'deptIdList',
        'staffIdList' => 'staffIdList',
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
        if (null !== $this->staffIdList) {
            $res['staffIdList'] = $this->staffIdList;
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
        if (isset($map['staffIdList'])) {
            if (!empty($map['staffIdList'])) {
                $model->staffIdList = $map['staffIdList'];
            }
        }

        return $model;
    }
}
