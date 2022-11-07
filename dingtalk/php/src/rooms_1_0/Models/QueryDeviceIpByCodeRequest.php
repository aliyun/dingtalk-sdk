<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDeviceIpByCodeRequest extends Model
{
    /**
     * @description 设备sn号
     *
     * @var string
     */
    public $deviceSn;
    protected $_name = [
        'deviceSn' => 'deviceSn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDeviceIpByCodeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }

        return $model;
    }
}
