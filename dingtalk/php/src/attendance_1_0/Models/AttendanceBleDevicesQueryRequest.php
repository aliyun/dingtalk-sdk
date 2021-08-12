<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesQueryRequest extends Model
{
    /**
     * @description 操作人Id
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 考勤组Id
     *
     * @var string
     */
    public $groupKey;
    protected $_name = [
        'opUserId' => 'opUserId',
        'groupKey' => 'groupKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->groupKey) {
            $res['groupKey'] = $this->groupKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttendanceBleDevicesQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['groupKey'])) {
            $model->groupKey = $map['groupKey'];
        }

        return $model;
    }
}
