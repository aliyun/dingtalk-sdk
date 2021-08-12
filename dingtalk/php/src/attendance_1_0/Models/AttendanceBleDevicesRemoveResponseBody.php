<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveResponseBody\errorList;
use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesRemoveResponseBody extends Model
{
    /**
     * @description 移出错误列表
     *
     * @var errorList[]
     */
    public $errorList;

    /**
     * @description 移除成功蓝牙设备Id列表
     *
     * @var int[]
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
            $res['successList'] = $this->successList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttendanceBleDevicesRemoveResponseBody
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
                $model->successList = $map['successList'];
            }
        }

        return $model;
    }
}
