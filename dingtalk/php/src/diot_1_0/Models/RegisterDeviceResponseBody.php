<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterDeviceResponseBody extends Model
{
    /**
     * @description 设备id
     *
     * @var string
     */
    public $deviceId;
    protected $_name = [
        'deviceId' => 'deviceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterDeviceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }

        return $model;
    }
}
