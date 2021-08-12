<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponseBody\errorList;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponseBody\successList;
use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesAddResponseBody extends Model
{
    /**
     * @description 添加错误列表
     *
     * @var errorList[]
     */
    public $errorList;

    /**
     * @description 添加成功蓝牙设备列表
     *
     * @var successList[]
     */
    public $successList;
    protected $_name = [
        'errorList'   => 'errorList',
        'successList' => 'successList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorList) {
            $res['errorList'] = [];
            if (null !== $this->errorList && \is_array($this->errorList)) {
                $n = 0;
                foreach ($this->errorList as $item) {
                    $res['errorList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->successList) {
            $res['successList'] = [];
            if (null !== $this->successList && \is_array($this->successList)) {
                $n = 0;
                foreach ($this->successList as $item) {
                    $res['successList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttendanceBleDevicesAddResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorList'])) {
            if (!empty($map['errorList'])) {
                $model->errorList = [];
                $n                = 0;
                foreach ($map['errorList'] as $item) {
                    $model->errorList[$n++] = null !== $item ? errorList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['successList'])) {
            if (!empty($map['successList'])) {
                $model->successList = [];
                $n                  = 0;
                foreach ($map['successList'] as $item) {
                    $model->successList[$n++] = null !== $item ? successList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
