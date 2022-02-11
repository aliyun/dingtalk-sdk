<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveDeviceRequest extends Model
{
    /**
     * @description 设备sn
     *
     * @var string
     */
    public $sn;

    /**
     * @description 商户id
     *
     * @var string
     */
    public $merchantId;
    protected $_name = [
        'sn'         => 'sn',
        'merchantId' => 'merchantId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }

        return $model;
    }
}
