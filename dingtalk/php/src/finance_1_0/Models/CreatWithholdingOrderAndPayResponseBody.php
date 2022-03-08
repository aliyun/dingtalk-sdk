<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatWithholdingOrderAndPayResponseBody extends Model
{
    /**
     * @description 代扣金额（元）
     *
     * @var string
     */
    public $amount;

    /**
     * @description 付款完成日期
     *
     * @var string
     */
    public $gmtPay;

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
     * @description 外部订单号
     *
     * @var string
     */
    public $outTradeNo;

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
     * @description 付款人staffId
     *
     * @var string
     */
    public $payerStaffId;

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
        'gmtPay'              => 'gmtPay',
        'instId'              => 'instId',
        'orderNo'             => 'orderNo',
        'outTradeNo'          => 'outTradeNo',
        'payChannel'          => 'payChannel',
        'payChannelAccountNo' => 'payChannelAccountNo',
        'payerStaffId'        => 'payerStaffId',
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
        if (null !== $this->gmtPay) {
            $res['gmtPay'] = $this->gmtPay;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->payChannelAccountNo) {
            $res['payChannelAccountNo'] = $this->payChannelAccountNo;
        }
        if (null !== $this->payerStaffId) {
            $res['payerStaffId'] = $this->payerStaffId;
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
     * @return CreatWithholdingOrderAndPayResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['gmtPay'])) {
            $model->gmtPay = $map['gmtPay'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['payChannelAccountNo'])) {
            $model->payChannelAccountNo = $map['payChannelAccountNo'];
        }
        if (isset($map['payerStaffId'])) {
            $model->payerStaffId = $map['payerStaffId'];
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
