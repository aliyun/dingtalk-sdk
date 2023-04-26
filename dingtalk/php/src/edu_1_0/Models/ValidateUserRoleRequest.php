<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ValidateUserRoleRequest extends Model
{
    /**
     * @example 1677600000000
     *
     * @var int
     */
    public $timeThreshold;

    /**
     * @example VYn5fYjORJMi
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'timeThreshold' => 'timeThreshold',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->timeThreshold) {
            $res['timeThreshold'] = $this->timeThreshold;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ValidateUserRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['timeThreshold'])) {
            $model->timeThreshold = $map['timeThreshold'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
