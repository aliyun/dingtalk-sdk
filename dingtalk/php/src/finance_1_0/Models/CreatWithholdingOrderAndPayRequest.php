<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayRequest\otherPayChannelDetailInfoList;
use AlibabaCloud\Tea\Model;

class CreatWithholdingOrderAndPayRequest extends Model
{
    /**
     * @description 扣款金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 其他资金渠道付款明细
     *
     * @var otherPayChannelDetailInfoList[]
     */
    public $otherPayChannelDetailInfoList;

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
     * @description 付款人staffId
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
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 代扣过期时间
     *
     * @var string
     */
    public $timeOutExpress;

    /**
     * @description 代扣标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'amount'                        => 'amount',
        'instId'                        => 'instId',
        'otherPayChannelDetailInfoList' => 'otherPayChannelDetailInfoList',
        'outTradeNo'                    => 'outTradeNo',
        'payChannel'                    => 'payChannel',
        'payerUserId'                   => 'payerUserId',
        'remark'                        => 'remark',
        'subInstId'                     => 'subInstId',
        'timeOutExpress'                => 'timeOutExpress',
        'title'                         => 'title',
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
                $n                                    = 0;
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
