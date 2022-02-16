<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcquireRefundOrderResponseBody extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 退款人userId
     *
     * @var string
     */
    public $payerUserId;

    /**
     * @description 支付渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 代扣金额（元）
     *
     * @var string
     */
    public $amount;

    /**
     * @description 外部退款订单号
     *
     * @var string
     */
    public $outRefundNo;

    /**
     * @description 代扣标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 代扣备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 钉钉订单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 退款完成日期
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @description 支付渠道支付账号（脱敏后返回）
     *
     * @var string
     */
    public $payChannelAccountNo;

    /**
     * @description 订单创建日期
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 原支付单外部流水号
     *
     * @var string
     */
    public $originOutTradeNo;
    protected $_name = [
        'instId'              => 'instId',
        'subInstId'           => 'subInstId',
        'payerUserId'         => 'payerUserId',
        'payChannel'          => 'payChannel',
        'amount'              => 'amount',
        'outRefundNo'         => 'outRefundNo',
        'title'               => 'title',
        'remark'              => 'remark',
        'status'              => 'status',
        'orderNo'             => 'orderNo',
        'gmtRefund'           => 'gmtRefund',
        'payChannelAccountNo' => 'payChannelAccountNo',
        'gmtCreate'           => 'gmtCreate',
        'originOutTradeNo'    => 'originOutTradeNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->payerUserId) {
            $res['payerUserId'] = $this->payerUserId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->outRefundNo) {
            $res['outRefundNo'] = $this->outRefundNo;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->gmtRefund) {
            $res['gmtRefund'] = $this->gmtRefund;
        }
        if (null !== $this->payChannelAccountNo) {
            $res['payChannelAccountNo'] = $this->payChannelAccountNo;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->originOutTradeNo) {
            $res['originOutTradeNo'] = $this->originOutTradeNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAcquireRefundOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['payerUserId'])) {
            $model->payerUserId = $map['payerUserId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['outRefundNo'])) {
            $model->outRefundNo = $map['outRefundNo'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['gmtRefund'])) {
            $model->gmtRefund = $map['gmtRefund'];
        }
        if (isset($map['payChannelAccountNo'])) {
            $model->payChannelAccountNo = $map['payChannelAccountNo'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['originOutTradeNo'])) {
            $model->originOutTradeNo = $map['originOutTradeNo'];
        }

        return $model;
    }
}
