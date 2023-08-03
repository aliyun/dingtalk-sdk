<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReverseTrialAdvancedLeaveRequest extends Model
{
    /**
     * @example manager234
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example 1
     *
     * @var int
     */
    public $servCode;
    protected $_name = [
        'opUserId' => 'opUserId',
        'servCode' => 'servCode',
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
        if (null !== $this->servCode) {
            $res['servCode'] = $this->servCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReverseTrialAdvancedLeaveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['servCode'])) {
            $model->servCode = $map['servCode'];
        }

        return $model;
    }
}
