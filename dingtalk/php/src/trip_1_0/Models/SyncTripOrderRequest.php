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
     * @description This parameter is required.
     *
     * @example CNY
     *
     * @var string
     */
    public $currency;

    /**
     * @description This parameter is required.
     *
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
     * @example 100.00
     *
     * @var string
     */
    public $enterprisePayAmount;

    /**
     * @description This parameter is required.
     *
     * @var event
     */
    public $event;

    /**
     * @description This parameter is required.
     *
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
     * @var bool
     */
    public $hasInvoice;

    /**
     * @example 亚朵酒店
     *
     * @var string
     */
    public $invoiceApplyRole;

    /**
     * @example PLAIN
     *
     * @var string
     */
    public $invoiceApplyType;

    /**
     * @var string
     */
    public $invoiceApplyUrl;

    /**
     * @var int
     */
    public $invoiceParty;

    /**
     * @var int
     */
    public $invoiceType;

    /**
     * @example 20220510170058192311
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @example 0219514246531048123
     *
     * @var string
     */
    public $journeySubmitUserId;

    /**
     * @var orderDetails[]
     */
    public $orderDetails;

    /**
     * @description This parameter is required.
     *
     * @example 20881001829000
     *
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $orderPaymentType;

    /**
     * @description This parameter is required.
     *
     * @example https:dingtalk.com/tripOrder/20220510170058192311
     *
     * @var string
     */
    public $orderUrl;

    /**
     * @example 100.00
     *
     * @var string
     */
    public $personalPayAmount;

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
     * @description This parameter is required.
     *
     * @example FLIGHT
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'bizExtension' => 'bizExtension',
        'channelType' => 'channelType',
        'currency' => 'currency',
        'dingUserId' => 'dingUserId',
        'discountAmount' => 'discountAmount',
        'endorseFlag' => 'endorseFlag',
        'enterprisePayAmount' => 'enterprisePayAmount',
        'event' => 'event',
        'gmtOrder' => 'gmtOrder',
        'gmtPay' => 'gmtPay',
        'gmtRefund' => 'gmtRefund',
        'hasInvoice' => 'hasInvoice',
        'invoiceApplyRole' => 'invoiceApplyRole',
        'invoiceApplyType' => 'invoiceApplyType',
        'invoiceApplyUrl' => 'invoiceApplyUrl',
        'invoiceParty' => 'invoiceParty',
        'invoiceType' => 'invoiceType',
        'journeyBizNo' => 'journeyBizNo',
        'journeySubmitUserId' => 'journeySubmitUserId',
        'orderDetails' => 'orderDetails',
        'orderNo' => 'orderNo',
        'orderPaymentType' => 'orderPaymentType',
        'orderUrl' => 'orderUrl',
        'personalPayAmount' => 'personalPayAmount',
        'processId' => 'processId',
        'realAmount' => 'realAmount',
        'refundAmount' => 'refundAmount',
        'relativeOrderNo' => 'relativeOrderNo',
        'source' => 'source',
        'supplyLogo' => 'supplyLogo',
        'supplyName' => 'supplyName',
        'targetCorpId' => 'targetCorpId',
        'tmcCorpId' => 'tmcCorpId',
        'totalAmount' => 'totalAmount',
        'type' => 'type',
    ];

    public function validate() {}

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
        if (null !== $this->enterprisePayAmount) {
            $res['enterprisePayAmount'] = $this->enterprisePayAmount;
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
        if (null !== $this->hasInvoice) {
            $res['hasInvoice'] = $this->hasInvoice;
        }
        if (null !== $this->invoiceApplyRole) {
            $res['invoiceApplyRole'] = $this->invoiceApplyRole;
        }
        if (null !== $this->invoiceApplyType) {
            $res['invoiceApplyType'] = $this->invoiceApplyType;
        }
        if (null !== $this->invoiceApplyUrl) {
            $res['invoiceApplyUrl'] = $this->invoiceApplyUrl;
        }
        if (null !== $this->invoiceParty) {
            $res['invoiceParty'] = $this->invoiceParty;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->journeyBizNo) {
            $res['journeyBizNo'] = $this->journeyBizNo;
        }
        if (null !== $this->journeySubmitUserId) {
            $res['journeySubmitUserId'] = $this->journeySubmitUserId;
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
        if (null !== $this->orderPaymentType) {
            $res['orderPaymentType'] = $this->orderPaymentType;
        }
        if (null !== $this->orderUrl) {
            $res['orderUrl'] = $this->orderUrl;
        }
        if (null !== $this->personalPayAmount) {
            $res['personalPayAmount'] = $this->personalPayAmount;
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
        if (isset($map['enterprisePayAmount'])) {
            $model->enterprisePayAmount = $map['enterprisePayAmount'];
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
        if (isset($map['hasInvoice'])) {
            $model->hasInvoice = $map['hasInvoice'];
        }
        if (isset($map['invoiceApplyRole'])) {
            $model->invoiceApplyRole = $map['invoiceApplyRole'];
        }
        if (isset($map['invoiceApplyType'])) {
            $model->invoiceApplyType = $map['invoiceApplyType'];
        }
        if (isset($map['invoiceApplyUrl'])) {
            $model->invoiceApplyUrl = $map['invoiceApplyUrl'];
        }
        if (isset($map['invoiceParty'])) {
            $model->invoiceParty = $map['invoiceParty'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['journeyBizNo'])) {
            $model->journeyBizNo = $map['journeyBizNo'];
        }
        if (isset($map['journeySubmitUserId'])) {
            $model->journeySubmitUserId = $map['journeySubmitUserId'];
        }
        if (isset($map['orderDetails'])) {
            if (!empty($map['orderDetails'])) {
                $model->orderDetails = [];
                $n = 0;
                foreach ($map['orderDetails'] as $item) {
                    $model->orderDetails[$n++] = null !== $item ? orderDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['orderPaymentType'])) {
            $model->orderPaymentType = $map['orderPaymentType'];
        }
        if (isset($map['orderUrl'])) {
            $model->orderUrl = $map['orderUrl'];
        }
        if (isset($map['personalPayAmount'])) {
            $model->personalPayAmount = $map['personalPayAmount'];
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
