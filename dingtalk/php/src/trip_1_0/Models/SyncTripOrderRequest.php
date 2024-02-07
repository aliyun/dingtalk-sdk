<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\event;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails;
use AlibabaCloud\Tea\Model;

class SyncTripOrderRequest extends Model
{
    /**
     * @var string
     */
    public $bizExtension;

    /**
     * @example BUSSINESS
     *
     * @var string
     */
    public $channelType;

    /**
     * @example CNY
     *
     * @var string
     */
    public $currency;

    /**
     * @example 20881001829000
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @example 0
     *
     * @var string
     */
    public $discountAmount;

    /**
     * @var bool
     */
    public $endorseFlag;

    /**
     * @var event
     */
    public $event;

    /**
     * @example 2022-05-15 10:10:10
     *
     * @var string
     */
    public $gmtOrder;

    /**
     * @example 2022-05-15 10:10:10
     *
     * @var string
     */
    public $gmtPay;

    /**
     * @example 2022-05-15 10:10:10
     *
     * @var string
     */
    public $gmtRefund;

    /**
     * @var string
     */
    public $invoiceApplyUrl;

    /**
     * @example 20220510170058192311
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @var orderDetails[]
     */
    public $orderDetails;

    /**
     * @example 20881001829000
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example https:dingtalk.com/tripOrder/20220510170058192311
     *
     * @var string
     */
    public $orderUrl;

    /**
     * @var string
     */
    public $processId;

    /**
     * @example 100.00
     *
     * @var string
     */
    public $realAmount;

    /**
     * @example 0
     *
     * @var string
     */
    public $refundAmount;

    /**
     * @example 20881001829000
     *
     * @var string
     */
    public $relativeOrderNo;

    /**
     * @var string
     */
    public $source;

    /**
     * @var string
     */
    public $supplyLogo;

    /**
     * @var string
     */
    public $supplyName;

    /**
     * @example ding32fff839a3e0105d
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @var string
     */
    public $tmcCorpId;

    /**
     * @example 100.00
     *
     * @var string
     */
    public $totalAmount;

    /**
     * @example FLIGHT
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'bizExtension'    => 'bizExtension',
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
        'processId'       => 'processId',
        'realAmount'      => 'realAmount',
        'refundAmount'    => 'refundAmount',
        'relativeOrderNo' => 'relativeOrderNo',
        'source'          => 'source',
        'supplyLogo'      => 'supplyLogo',
        'supplyName'      => 'supplyName',
        'targetCorpId'    => 'targetCorpId',
        'tmcCorpId'       => 'tmcCorpId',
        'totalAmount'     => 'totalAmount',
        'type'            => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizExtension) {
            $res['bizExtension'] = $this->bizExtension;
        }
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
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
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
        if (null !== $this->supplyLogo) {
            $res['supplyLogo'] = $this->supplyLogo;
        }
        if (null !== $this->supplyName) {
            $res['supplyName'] = $this->supplyName;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->tmcCorpId) {
            $res['tmcCorpId'] = $this->tmcCorpId;
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
        if (isset($map['bizExtension'])) {
            $model->bizExtension = $map['bizExtension'];
        }
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
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
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
        if (isset($map['supplyLogo'])) {
            $model->supplyLogo = $map['supplyLogo'];
        }
        if (isset($map['supplyName'])) {
            $model->supplyName = $map['supplyName'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['tmcCorpId'])) {
            $model->tmcCorpId = $map['tmcCorpId'];
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
