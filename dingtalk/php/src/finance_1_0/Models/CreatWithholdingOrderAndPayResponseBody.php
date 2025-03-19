<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatWithholdingOrderAndPayResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10.01
     *
     * @var string
     */
    public $amount;

    /**
     * @example 2021-11-15 10:10:10
     *
     * @var string
     */
    public $gmtPay;

    /**
     * @description This parameter is required.
     *
     * @example 202111010001
     *
     * @var string
     */
    public $instId;

    /**
     * @description This parameter is required.
     *
     * @example 202121241343151
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description This parameter is required.
     *
     * @example 202111020001
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @description This parameter is required.
     *
     * @example ALIPAY
     *
     * @var string
     */
    public $payChannel;

    /**
     * @description This parameter is required.
     *
     * @example 13****09
     *
     * @var string
     */
    public $payChannelAccountNo;

    /**
     * @description This parameter is required.
     *
     * @example 123124
     *
     * @var string
     */
    public $payerStaffId;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example SUCCESS
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description This parameter is required.
     *
     * @example 餐费
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'amount' => 'amount',
        'gmtPay' => 'gmtPay',
        'instId' => 'instId',
        'orderNo' => 'orderNo',
        'outTradeNo' => 'outTradeNo',
        'payChannel' => 'payChannel',
        'payChannelAccountNo' => 'payChannelAccountNo',
        'payerStaffId' => 'payerStaffId',
        'remark' => 'remark',
        'status' => 'status',
        'subInstId' => 'subInstId',
        'title' => 'title',
    ];

    public function validate() {}

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
