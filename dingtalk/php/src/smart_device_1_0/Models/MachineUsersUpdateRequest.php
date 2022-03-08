<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class MachineUsersUpdateRequest extends Model
{
    /**
     * @description 新增的部门id列表
     *
     * @var int[]
     */
    public $addDeptIds;

    /**
     * @description 新增的员工id列表
     *
     * @var string[]
     */
    public $addUserIds;

    /**
     * @description 移除的部门id列表
     *
     * @var int[]
     */
    public $delDeptIds;

    /**
     * @description 移除的员工id列表
     *
     * @var string[]
     */
    public $delUserIds;

    /**
     * @description 设备唯一标识id列表，Long数组
     *
     * @var int[]
     */
    public $devIds;

    /**
     * @description 设备唯一标识id列表，字符串数组
     *
     * @var string[]
     */
    public $deviceIds;
    protected $_name = [
        'addDeptIds' => 'addDeptIds',
        'addUserIds' => 'addUserIds',
        'delDeptIds' => 'delDeptIds',
        'delUserIds' => 'delUserIds',
        'devIds'     => 'devIds',
        'deviceIds'  => 'deviceIds',
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
        if (null !== $this->addUserIds) {
            $res['addUserIds'] = $this->addUserIds;
        }
        if (null !== $this->delDeptIds) {
            $res['delDeptIds'] = $this->delDeptIds;
        }
        if (null !== $this->delUserIds) {
            $res['delUserIds'] = $this->delUserIds;
        }
        if (null !== $this->devIds) {
            $res['devIds'] = $this->devIds;
        }
        if (null !== $this->deviceIds) {
            $res['deviceIds'] = $this->deviceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MachineUsersUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['addDeptIds'])) {
            if (!empty($map['addDeptIds'])) {
                $model->addDeptIds = $map['addDeptIds'];
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
        if (isset($map['delUserIds'])) {
            if (!empty($map['delUserIds'])) {
                $model->delUserIds = $map['delUserIds'];
            }
        }
        if (isset($map['devIds'])) {
            if (!empty($map['devIds'])) {
                $model->devIds = $map['devIds'];
            }
        }
        if (isset($map['deviceIds'])) {
            if (!empty($map['deviceIds'])) {
                $model->deviceIds = $map['deviceIds'];
            }
        }

        return $model;
    }
}
