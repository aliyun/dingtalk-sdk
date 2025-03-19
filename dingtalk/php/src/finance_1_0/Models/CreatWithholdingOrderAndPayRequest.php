<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayRequest\otherPayChannelDetailInfoList;
use AlibabaCloud\Tea\Model;

class CreatWithholdingOrderAndPayRequest extends Model
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
     * @description This parameter is required.
     *
     * @example 202111090001
     *
     * @var string
     */
    public $instId;

    /**
     * @var otherPayChannelDetailInfoList[]
     */
    public $otherPayChannelDetailInfoList;

    /**
     * @description This parameter is required.
     *
     * @example 2021113000001
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
     * @example 2120493284
     *
     * @var string
     */
    public $payerUserId;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $subInstId;

    /**
     * @example 15m
     *
     * @var string
     */
    public $timeOutExpress;

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
        'instId' => 'instId',
        'otherPayChannelDetailInfoList' => 'otherPayChannelDetailInfoList',
        'outTradeNo' => 'outTradeNo',
        'payChannel' => 'payChannel',
        'payerUserId' => 'payerUserId',
        'remark' => 'remark',
        'subInstId' => 'subInstId',
        'timeOutExpress' => 'timeOutExpress',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->otherPayChannelDetailInfoList) {
            $res['otherPayChannelDetailInfoList'] = [];
            if (null !== $this->otherPayChannelDetailInfoList && \is_array($this->otherPayChannelDetailInfoList)) {
                $n = 0;
                foreach ($this->otherPayChannelDetailInfoList as $item) {
                    $res['otherPayChannelDetailInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->payerUserId) {
            $res['payerUserId'] = $this->payerUserId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->timeOutExpress) {
            $res['timeOutExpress'] = $this->timeOutExpress;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatWithholdingOrderAndPayRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['otherPayChannelDetailInfoList'])) {
            if (!empty($map['otherPayChannelDetailInfoList'])) {
                $model->otherPayChannelDetailInfoList = [];
                $n = 0;
                foreach ($map['otherPayChannelDetailInfoList'] as $item) {
                    $model->otherPayChannelDetailInfoList[$n++] = null !== $item ? otherPayChannelDetailInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['payerUserId'])) {
            $model->payerUserId = $map['payerUserId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['timeOutExpress'])) {
            $model->timeOutExpress = $map['timeOutExpress'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
