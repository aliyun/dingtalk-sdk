<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateStsTokenRequest extends Model
{
    /**
     * @description 设备sn码
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @description sts类型: oss/sls
     *
     * @var string
     */
    public $stsType;
    protected $_name = [
        'deviceSn' => 'deviceSn',
        'stsType'  => 'stsType',
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
        if (null !== $this->stsType) {
            $res['stsType'] = $this->stsType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateStsTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['stsType'])) {
            $model->stsType = $map['stsType'];
        }

        return $model;
    }
}
