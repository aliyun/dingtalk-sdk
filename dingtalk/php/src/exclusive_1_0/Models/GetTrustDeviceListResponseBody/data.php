<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 员工Id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 平台类型
     *
     * @var string
     */
    public $platform;

    /**
     * @description mac地址
     *
     * @var string
     */
    public $macAddress;
    protected $_name = [
        'userId'     => 'userId',
        'platform'   => 'platform',
        'macAddress' => 'macAddress',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }

        return $model;
    }
}
