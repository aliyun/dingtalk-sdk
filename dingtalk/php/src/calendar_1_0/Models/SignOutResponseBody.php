<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class SignOutResponseBody extends Model
{
    /**
     * @description 签退时间戳
     *
     * @var int
     */
    public $checkOutTime;
    protected $_name = [
        'checkOutTime' => 'checkOutTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkOutTime) {
            $res['checkOutTime'] = $this->checkOutTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SignOutResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkOutTime'])) {
            $model->checkOutTime = $map['checkOutTime'];
        }

        return $model;
    }
}
