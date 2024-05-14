<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $faceId;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=
     *
     * @var string
     */
    public $signature;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $sn;

    /**
     * @example 1644413947909
     *
     * @var int
     */
    public $timestamp;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'faceId'    => 'faceId',
        'orderNo'   => 'orderNo',
        'signature' => 'signature',
        'sn'        => 'sn',
        'timestamp' => 'timestamp',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
