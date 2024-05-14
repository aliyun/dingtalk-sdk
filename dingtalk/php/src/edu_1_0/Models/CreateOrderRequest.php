<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @example 1644413947909
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @var detailList[]
     */
    public $detailList;

    /**
     * @description This parameter is required.
     *
     * @example 123123
     *
     * @var string
     */
    public $faceId;

    /**
     * @description This parameter is required.
     *
     * @example FACE_010100b0555Xczd4ePVLaB5V3cCzrONYpHWOENzRxDDqcnVjYXLso0U_1642665071746
     *
     * @var string
     */
    public $ftoken;

    /**
     * @example KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=
     *
     * @var string
     */
    public $signature;

    /**
     * @description This parameter is required.
     *
     * @example QA62021121908E
     *
     * @var string
     */
    public $sn;

    /**
     * @description This parameter is required.
     *
     * @example {\"terminalType\":\"IOT\"}
     *
     * @var string
     */
    public $terminalParams;

    /**
     * @example 1644413947909
     *
     * @var int
     */
    public $timestamp;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $totalAmount;

    /**
     * @description This parameter is required.
     *
     * @example 1643334234626
     *
     * @var string
     */
    public $userId;

    /**
     * @example 1.0
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'actualAmount'   => 'actualAmount',
        'createTime'     => 'createTime',
        'detailList'     => 'detailList',
        'faceId'         => 'faceId',
        'ftoken'         => 'ftoken',
        'signature'      => 'signature',
        'sn'             => 'sn',
        'terminalParams' => 'terminalParams',
        'timestamp'      => 'timestamp',
        'totalAmount'    => 'totalAmount',
        'userId'         => 'userId',
        'version'        => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->detailList) {
            $res['detailList'] = [];
            if (null !== $this->detailList && \is_array($this->detailList)) {
                $n = 0;
                foreach ($this->detailList as $item) {
                    $res['detailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }
        if (null !== $this->ftoken) {
            $res['ftoken'] = $this->ftoken;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->terminalParams) {
            $res['terminalParams'] = $this->terminalParams;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['detailList'])) {
            if (!empty($map['detailList'])) {
                $model->detailList = [];
                $n                 = 0;
                foreach ($map['detailList'] as $item) {
                    $model->detailList[$n++] = null !== $item ? detailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }
        if (isset($map['ftoken'])) {
            $model->ftoken = $map['ftoken'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['terminalParams'])) {
            $model->terminalParams = $map['terminalParams'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
