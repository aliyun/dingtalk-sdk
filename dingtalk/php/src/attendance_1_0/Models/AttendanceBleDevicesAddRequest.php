<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesAddRequest extends Model
{
    /**
     * @var int[]
     */
    public $deviceIdList;

    /**
     * @example 62001E1C5B9362D369D316DED25F3656
     *
     * @var string
     */
    public $groupKey;

    /**
     * @example userId001
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'deviceIdList' => 'deviceIdList',
        'groupKey'     => 'groupKey',
        'opUserId'     => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceIdList) {
            $res['deviceIdList'] = $this->deviceIdList;
        }
        if (null !== $this->groupKey) {
            $res['groupKey'] = $this->groupKey;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttendanceBleDevicesAddRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceIdList'])) {
            if (!empty($map['deviceIdList'])) {
                $model->deviceIdList = $map['deviceIdList'];
            }
        }
        if (isset($map['groupKey'])) {
            $model->groupKey = $map['groupKey'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
