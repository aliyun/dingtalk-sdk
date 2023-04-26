<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class MachineUsersUpdateRequest extends Model
{
    /**
     * @var int[]
     */
    public $addDeptIds;

    /**
     * @var string[]
     */
    public $addUserIds;

    /**
     * @var int[]
     */
    public $delDeptIds;

    /**
     * @var string[]
     */
    public $delUserIds;

    /**
     * @var int[]
     */
    public $devIds;

    /**
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
