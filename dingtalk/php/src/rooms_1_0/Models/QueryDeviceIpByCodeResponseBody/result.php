<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 设备内网ip
     *
     * @var string
     */
    public $deviceIp;
    protected $_name = [
        'deviceIp' => 'deviceIp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceIp) {
            $res['deviceIp'] = $this->deviceIp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceIp'])) {
            $model->deviceIp = $map['deviceIp'];
        }

        return $model;
    }
}
