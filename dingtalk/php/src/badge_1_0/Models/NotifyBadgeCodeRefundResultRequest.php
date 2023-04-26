<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultRequest\payChannelDetailList;
use AlibabaCloud\Tea\Model;

class NotifyBadgeCodeRefundResultRequest extends Model
{
    /**
     * @example ding1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2021-11-11 11:11:11
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @var payChannelDetailList[]
     */
    public $payChannelDetailList;

    /**
     * @example payCode
     *
     * @var string
     */
    public $payCode;

    /**
     * @example 1.00
     *
     * @var string
     */
    public $refundAmount;

    /**
     * @example refundOrderNo
     *
     * @var string
     */
    public $refundOrderNo;

    /**
     * @example 0.00
     *
     * @var string
     */
    public $refundPromotionAmount;

    /**
     * @example 晚餐退款
     *
     * @var string
     */
    public $remark;

    /**
     * @example tradeNo
     *
     * @var string
     */
    public $tradeNo;

    /**
     * @example userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'                => 'corpId',
        'gmtRefund'             => 'gmtRefund',
        'payChannelDetailList'  => 'payChannelDetailList',
        'payCode'               => 'payCode',
        'refundAmount'          => 'refundAmount',
        'refundOrderNo'         => 'refundOrderNo',
        'refundPromotionAmount' => 'refundPromotionAmount',
        'remark'                => 'remark',
        'tradeNo'               => 'tradeNo',
        'userId'                => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->gmtRefund) {
            $res['gmtRefund'] = $this->gmtRefund;
        }
        if (null !== $this->payChannelDetailList) {
            $res['payChannelDetailList'] = [];
            if (null !== $this->payChannelDetailList && \is_array($this->payChannelDetailList)) {
                $n = 0;
                foreach ($this->payChannelDetailList as $item) {
                    $res['payChannelDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
        }
        if (null !== $this->refundAmount) {
            $res['refundAmount'] = $this->refundAmount;
        }
        if (null !== $this->refundOrderNo) {
            $res['refundOrderNo'] = $this->refundOrderNo;
        }
        if (null !== $this->refundPromotionAmount) {
            $res['refundPromotionAmount'] = $this->refundPromotionAmount;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NotifyBadgeCodeRefundResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gmtRefund'])) {
            $model->gmtRefund = $map['gmtRefund'];
        }
        if (isset($map['payChannelDetailList'])) {
            if (!empty($map['payChannelDetailList'])) {
                $model->payChannelDetailList = [];
                $n                           = 0;
                foreach ($map['payChannelDetailList'] as $item) {
                    $model->payChannelDetailList[$n++] = null !== $item ? payChannelDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }
        if (isset($map['refundAmount'])) {
            $model->refundAmount = $map['refundAmount'];
        }
        if (isset($map['refundOrderNo'])) {
            $model->refundOrderNo = $map['refundOrderNo'];
        }
        if (isset($map['refundPromotionAmount'])) {
            $model->refundPromotionAmount = $map['refundPromotionAmount'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
