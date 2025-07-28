<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesRemoveResponseBody;

use AlibabaCloud\Tea\Model;

class errorList extends Model
{
    /**
     * @example 400001
     *
     * @var string
     */
    public $code;

    /**
     * @var int[]
     */
    public $failureList;

    /**
     * @example error
     *
     * @var string
     */
    public $msg;
    protected $_name = [
        'code' => 'code',
        'failureList' => 'failureList',
        'msg' => 'msg',
    ];

    public function validate() {}

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
