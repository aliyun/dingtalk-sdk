<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcquireRefundOrderResponseBody extends Model
{
    /**
     * @description 代扣金额（元）
     *
     * @var string
     */
    public $amount;

    /**
     * @description 订单创建日期
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 退款完成日期
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 钉钉订单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 原支付单外部流水号
     *
     * @var string
     */
    public $originOutTradeNo;

    /**
     * @description 外部退款订单号
     *
     * @var string
     */
    public $outRefundNo;

    /**
     * @description 支付渠道
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description 支付渠道支付账号（脱敏后返回）
     *
     * @var string
     */
    public $payChannelAccountNo;

    /**
     * @description 退款人userId
     *
     * @var string
     */
    public $payerUserId;

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
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 代扣标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'amount'              => 'amount',
        'gmtCreate'           => 'gmtCreate',
        'gmtRefund'           => 'gmtRefund',
        'instId'              => 'instId',
        'orderNo'             => 'orderNo',
        'originOutTradeNo'    => 'originOutTradeNo',
        'outRefundNo'         => 'outRefundNo',
        'payChannel'          => 'payChannel',
        'payChannelAccountNo' => 'payChannelAccountNo',
        'payerUserId'         => 'payerUserId',
        'remark'              => 'remark',
        'status'              => 'status',
        'subInstId'           => 'subInstId',
        'title'               => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtRefund) {
            $res['gmtRefund'] = $this->gmtRefund;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->originOutTradeNo) {
            $res['originOutTradeNo'] = $this->originOutTradeNo;
        }
        if (null !== $this->outRefundNo) {
            $res['outRefundNo'] = $this->outRefundNo;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->payChannelAccountNo) {
            $res['payChannelAccountNo'] = $this->payChannelAccountNo;
        }
        if (null !== $this->payerUserId) {
            $res['payerUserId'] = $this->payerUserId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtRefund'])) {
            $model->gmtRefund = $map['gmtRefund'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['originOutTradeNo'])) {
            $model->originOutTradeNo = $map['originOutTradeNo'];
        }
        if (isset($map['outRefundNo'])) {
            $model->outRefundNo = $map['outRefundNo'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['payChannelAccountNo'])) {
            $model->payChannelAccountNo = $map['payChannelAccountNo'];
        }
        if (isset($map['payerUserId'])) {
            $model->payerUserId = $map['payerUserId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
