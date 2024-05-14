<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetShiftRequest extends Model
{
    /**
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $shiftId;
    protected $_name = [
        'opUserId' => 'opUserId',
        'shiftId'  => 'shiftId',
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
        if (null !== $this->shiftId) {
            $res['shiftId'] = $this->shiftId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetShiftRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['shiftId'])) {
            $model->shiftId = $map['shiftId'];
        }

        return $model;
    }
}
