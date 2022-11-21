<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteTrustedDeviceRequest extends Model
{
    /**
     * @description DID设备唯一码：与mac地址任一必填一个
     *
     * @var string
     */
    public $did;

    /**
     * @description 是否踢下线
     *
     * @var bool
     */
    public $kickOff;

    /**
     * @description mac地址：与DID任一必填一个
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description 员工userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'did'        => 'did',
        'kickOff'    => 'kickOff',
        'macAddress' => 'macAddress',
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
        if (null !== $this->kickOff) {
            $res['kickOff'] = $this->kickOff;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteTrustedDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['did'])) {
            $model->did = $map['did'];
        }
        if (isset($map['kickOff'])) {
            $model->kickOff = $map['kickOff'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
