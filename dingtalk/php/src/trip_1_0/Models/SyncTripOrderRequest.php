<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\event;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails;
use AlibabaCloud\Tea\Model;

class SyncTripOrderRequest extends Model
{
    /**
     * @description 订单渠道，枚举值：BUSINESS、CUSTOMER
     *
     * @var string
     */
    public $channelType;

    /**
     * @description 币种
     *
     * @var string
     */
    public $currency;

    /**
     * @description 钉钉用户id
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @description 优惠金额
     *
     * @var string
     */
    public $discountAmount;

    /**
     * @description 是否是改签单
     *
     * @var bool
     */
    public $endorseFlag;

    /**
     * @var event
     */
    public $event;

    /**
     * @description 下单时间
     *
     * @var string
     */
    public $gmtOrder;

    /**
     * @description 付款时间
     *
     * @var string
     */
    public $gmtPay;

    /**
     * @description 退款时间
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @description 发票申请链接
     *
     * @var string
     */
    public $invoiceApplyUrl;

    /**
     * @description 行程单号
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @description 订单详情列表
     *
     * @var orderDetails[]
     */
    public $orderDetails;

    /**
     * @description 供应商订单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 订单详情链接
     *
     * @var string
     */
    public $orderUrl;

    /**
     * @description 实付金额
     *
     * @var string
     */
    public $realAmount;

    /**
     * @description 退款金额
     *
     * @var string
     */
    public $refundAmount;

    /**
     * @description 供应商关联订单号
     *
     * @var string
     */
    public $relativeOrderNo;

    /**
     * @description 来源埋点
     *
     * @var string
     */
    public $source;

    /**
     * @description 用户组织id
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @description 总金额
     *
     * @var string
     */
    public $totalAmount;

    /**
     * @description 订单类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'channelType'     => 'channelType',
        'currency'        => 'currency',
        'dingUserId'      => 'dingUserId',
        'discountAmount'  => 'discountAmount',
        'endorseFlag'     => 'endorseFlag',
        'event'           => 'event',
        'gmtOrder'        => 'gmtOrder',
        'gmtPay'          => 'gmtPay',
        'gmtRefund'       => 'gmtRefund',
        'invoiceApplyUrl' => 'invoiceApplyUrl',
        'journeyBizNo'    => 'journeyBizNo',
        'orderDetails'    => 'orderDetails',
        'orderNo'         => 'orderNo',
        'orderUrl'        => 'orderUrl',
        'realAmount'      => 'realAmount',
        'refundAmount'    => 'refundAmount',
        'relativeOrderNo' => 'relativeOrderNo',
        'source'          => 'source',
        'targetCorpId'    => 'targetCorpId',
        'totalAmount'     => 'totalAmount',
        'type'            => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelType) {
            $res['channelType'] = $this->channelType;
        }
        if (null !== $this->currency) {
            $res['currency'] = $this->currency;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->discountAmount) {
            $res['discountAmount'] = $this->discountAmount;
        }
        if (null !== $this->endorseFlag) {
            $res['endorseFlag'] = $this->endorseFlag;
        }
        if (null !== $this->event) {
            $res['event'] = null !== $this->event ? $this->event->toMap() : null;
        }
        if (null !== $this->gmtOrder) {
            $res['gmtOrder'] = $this->gmtOrder;
        }
        if (null !== $this->gmtPay) {
            $res['gmtPay'] = $this->gmtPay;
        }
        if (null !== $this->gmtRefund) {
            $res['gmtRefund'] = $this->gmtRefund;
        }
        if (null !== $this->invoiceApplyUrl) {
            $res['invoiceApplyUrl'] = $this->invoiceApplyUrl;
        }
        if (null !== $this->journeyBizNo) {
            $res['journeyBizNo'] = $this->journeyBizNo;
        }
        if (null !== $this->orderDetails) {
            $res['orderDetails'] = [];
            if (null !== $this->orderDetails && \is_array($this->orderDetails)) {
                $n = 0;
                foreach ($this->orderDetails as $item) {
                    $res['orderDetails'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->orderUrl) {
            $res['orderUrl'] = $this->orderUrl;
        }
        if (null !== $this->realAmount) {
            $res['realAmount'] = $this->realAmount;
        }
        if (null !== $this->refundAmount) {
            $res['refundAmount'] = $this->refundAmount;
        }
        if (null !== $this->relativeOrderNo) {
            $res['relativeOrderNo'] = $this->relativeOrderNo;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncTripOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelType'])) {
            $model->channelType = $map['channelType'];
        }
        if (isset($map['currency'])) {
            $model->currency = $map['currency'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['discountAmount'])) {
            $model->discountAmount = $map['discountAmount'];
        }
        if (isset($map['endorseFlag'])) {
            $model->endorseFlag = $map['endorseFlag'];
        }
        if (isset($map['event'])) {
            $model->event = event::fromMap($map['event']);
        }
        if (isset($map['gmtOrder'])) {
            $model->gmtOrder = $map['gmtOrder'];
        }
        if (isset($map['gmtPay'])) {
            $model->gmtPay = $map['gmtPay'];
        }
        if (isset($map['gmtRefund'])) {
            $model->gmtRefund = $map['gmtRefund'];
        }
        if (isset($map['invoiceApplyUrl'])) {
            $model->invoiceApplyUrl = $map['invoiceApplyUrl'];
        }
        if (isset($map['journeyBizNo'])) {
            $model->journeyBizNo = $map['journeyBizNo'];
        }
        if (isset($map['orderDetails'])) {
            if (!empty($map['orderDetails'])) {
                $model->orderDetails = [];
                $n                   = 0;
                foreach ($map['orderDetails'] as $item) {
                    $model->orderDetails[$n++] = null !== $item ? orderDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['orderUrl'])) {
            $model->orderUrl = $map['orderUrl'];
        }
        if (isset($map['realAmount'])) {
            $model->realAmount = $map['realAmount'];
        }
        if (isset($map['refundAmount'])) {
            $model->refundAmount = $map['refundAmount'];
        }
        if (isset($map['relativeOrderNo'])) {
            $model->relativeOrderNo = $map['relativeOrderNo'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
