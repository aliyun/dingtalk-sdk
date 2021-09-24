<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultRequest\payChannelDetailList;
use AlibabaCloud\Tea\Model;

class NotifyBadgeCodeRefundResultRequest extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 交易订单号
     *
     * @var string
     */
    public $tradeNo;

    /**
     * @description 本次退款订单号
     *
     * @var string
     */
    public $refundOrderNo;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 退款金额
     *
     * @var string
     */
    public $refundAmount;

    /**
     * @description 退款的优惠金额
     *
     * @var string
     */
    public $refundPromotionAmount;

    /**
     * @description 退款时间
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @description 支付渠道信息
     *
     * @var payChannelDetailList[]
     */
    public $payChannelDetailList;

    /**
     * @description ISV组织ID
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 组织ID
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 支付时使用的付款码
     *
     * @var string
     */
    public $payCode;
    protected $_name = [
        'corpId'                => 'corpId',
        'userId'                => 'userId',
        'tradeNo'               => 'tradeNo',
        'refundOrderNo'         => 'refundOrderNo',
        'remark'                => 'remark',
        'refundAmount'          => 'refundAmount',
        'refundPromotionAmount' => 'refundPromotionAmount',
        'gmtRefund'             => 'gmtRefund',
        'payChannelDetailList'  => 'payChannelDetailList',
        'dingIsvOrgId'          => 'dingIsvOrgId',
        'dingOrgId'             => 'dingOrgId',
        'payCode'               => 'payCode',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->refundOrderNo) {
            $res['refundOrderNo'] = $this->refundOrderNo;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->refundAmount) {
            $res['refundAmount'] = $this->refundAmount;
        }
        if (null !== $this->refundPromotionAmount) {
            $res['refundPromotionAmount'] = $this->refundPromotionAmount;
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
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['refundOrderNo'])) {
            $model->refundOrderNo = $map['refundOrderNo'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['refundAmount'])) {
            $model->refundAmount = $map['refundAmount'];
        }
        if (isset($map['refundPromotionAmount'])) {
            $model->refundPromotionAmount = $map['refundPromotionAmount'];
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }

        return $model;
    }
}
