<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeviceDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $productKey;
    protected $_name = [
        'deviceName' => 'deviceName',
        'productKey' => 'productKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->productKey) {
            $res['productKey'] = $this->productKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeviceDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['productKey'])) {
            $model->productKey = $map['productKey'];
        }

        return $model;
    }
}
