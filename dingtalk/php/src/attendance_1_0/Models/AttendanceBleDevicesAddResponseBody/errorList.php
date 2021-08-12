<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponseBody\errorList\failureList;
use AlibabaCloud\Tea\Model;

class errorList extends Model
{
    /**
     * @description 错误code
     *
     * @var string
     */
    public $code;

    /**
     * @description 失败蓝牙设备列表
     *
     * @var failureList[]
     */
    public $failureList;

    /**
     * @description errorMsg
     *
     * @var string
     */
    public $msg;
    protected $_name = [
        'code'        => 'code',
        'failureList' => 'failureList',
        'msg'         => 'msg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->failureList) {
            $res['failureList'] = [];
            if (null !== $this->failureList && \is_array($this->failureList)) {
                $n = 0;
                foreach ($this->failureList as $item) {
                    $res['failureList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return errorList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['failureList'])) {
            if (!empty($map['failureList'])) {
                $model->failureList = [];
                $n                  = 0;
                foreach ($map['failureList'] as $item) {
                    $model->failureList[$n++] = null !== $item ? failureList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }

        return $model;
    }
}
