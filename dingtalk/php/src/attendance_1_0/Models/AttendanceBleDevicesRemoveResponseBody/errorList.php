<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveResponseBody;

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
     * @description 移除失败蓝牙设备Id列表
     *
     * @var int[]
     */
    public $failureList;

    /**
     * @description 错误信息
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
            $res['failureList'] = $this->failureList;
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
                $model->failureList = $map['failureList'];
            }
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }

        return $model;
    }
}
