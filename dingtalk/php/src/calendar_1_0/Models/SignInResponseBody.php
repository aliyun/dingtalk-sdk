<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class SignInResponseBody extends Model
{
    /**
     * @var int
     */
    public $checkInTime;
    protected $_name = [
        'checkInTime' => 'checkInTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkInTime) {
            $res['checkInTime'] = $this->checkInTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SignInResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }

        return $model;
    }
}
