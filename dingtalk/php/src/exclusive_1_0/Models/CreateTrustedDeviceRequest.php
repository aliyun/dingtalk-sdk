<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTrustedDeviceRequest extends Model
{
    /**
     * @description 支持SDK集成的设备唯一标识。
     *
     * @var string
     */
    public $did;

    /**
     * @description mac地址
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description 平台类型
     *
     * @var string
     */
    public $platform;

    /**
     * @description 设备状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 员工userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'did'        => 'did',
        'macAddress' => 'macAddress',
        'platform'   => 'platform',
        'status'     => 'status',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->did) {
            $res['did'] = $this->did;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTrustedDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['did'])) {
            $model->did = $map['did'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
