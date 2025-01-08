<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTrustedDeviceRequest extends Model
{
    /**
     * @example CV11z5d2bdbb2260d1576000b4a9955fa
     *
     * @var string
     */
    public $did;

    /**
     * @example 88:92:5a:1f:e8:24
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description This parameter is required.
     *
     * @example Mac
     *
     * @var string
     */
    public $platform;

    /**
     * @example 2
     *
     * @var int
     */
    public $status;

    /**
     * @example 设备名称
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 65224157501039784
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'did'        => 'did',
        'macAddress' => 'macAddress',
        'platform'   => 'platform',
        'status'     => 'status',
        'title'      => 'title',
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
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
