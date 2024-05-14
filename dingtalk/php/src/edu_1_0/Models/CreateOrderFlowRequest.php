<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateOrderFlowRequest extends Model
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
     * @example 2088112532248965
     *
     * @var string
     */
    public $alipayUid;

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
     * @example 123123
     *
     * @var string
     */
    public $faceId;

    /**
     * @example 123455
     *
     * @var string
     */
    public $guardianUserId;

    /**
     * @description This parameter is required.
     *
     * @example 2088821434894708
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description This parameter is required.
     *
     * @example 2022012717252021400100822002
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
     * @example QA62021121908E
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
    protected $_name = [
        'actualAmount'   => 'actualAmount',
        'alipayUid'      => 'alipayUid',
        'createTime'     => 'createTime',
        'detailList'     => 'detailList',
        'faceId'         => 'faceId',
        'guardianUserId' => 'guardianUserId',
        'merchantId'     => 'merchantId',
        'orderNo'        => 'orderNo',
        'signature'      => 'signature',
        'sn'             => 'sn',
        'timestamp'      => 'timestamp',
        'totalAmount'    => 'totalAmount',
        'userId'         => 'userId',
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
        if (null !== $this->alipayUid) {
            $res['alipayUid'] = $this->alipayUid;
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
        if (null !== $this->guardianUserId) {
            $res['guardianUserId'] = $this->guardianUserId;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
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
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrderFlowRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['alipayUid'])) {
            $model->alipayUid = $map['alipayUid'];
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
        if (isset($map['guardianUserId'])) {
            $model->guardianUserId = $map['guardianUserId'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
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
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
