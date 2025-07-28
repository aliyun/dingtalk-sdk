<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteTrustedDeviceRequest extends Model
{
    /**
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $kickOff;

    /**
     * @example 88:92:5a:1f:e8:24
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description This parameter is required.
     *
     * @example 0119194439361061403
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'id' => 'id',
        'kickOff' => 'kickOff',
        'macAddress' => 'macAddress',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
