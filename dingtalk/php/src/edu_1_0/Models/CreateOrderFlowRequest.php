<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowRequest\detailList;
use AlibabaCloud\Tea\Model;

class CreateOrderFlowRequest extends Model
{
    /**
     * @description 实付金额，单位分（优惠计算后）
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description 支付宝用户id
     *
     * @var string
     */
    public $alipayUid;

    /**
     * @description 开单时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 订单明细信息，来源于商户系统或APP的商品信息。
     *
     * @var detailList[]
     */
    public $detailList;

    /**
     * @description 人脸id
     *
     * @var string
     */
    public $faceId;

    /**
     * @description 家长员工id
     *
     * @var string
     */
    public $guardianUserId;

    /**
     * @description 商户id
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 订单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 签名
     *
     * @var string
     */
    public $signature;

    /**
     * @description 设备号
     *
     * @var string
     */
    public $sn;

    /**
     * @description utc时间戳
     *
     * @var int
     */
    public $timestamp;

    /**
     * @description 应付价格，单位分
     *
     * @var int
     */
    public $totalAmount;

    /**
     * @description 员工id
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
