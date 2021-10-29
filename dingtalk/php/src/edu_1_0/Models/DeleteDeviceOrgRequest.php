<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteDeviceOrgRequest extends Model
{
    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $authCode;
    protected $_name = [
        'deviceCode' => 'deviceCode',
        'authCode'   => 'authCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDeviceOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }

        return $model;
    }
}
