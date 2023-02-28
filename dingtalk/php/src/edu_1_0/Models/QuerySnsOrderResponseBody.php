<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySnsOrderResponseBody extends Model
{
    /**
     * @var int
     */
    public $actualAmount;

    /**
     * @description 支付宝应用id。
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @description 订单关闭时间
     *
     * @var string
     */
    public $closeTime;

    /**
     * @description 订单关闭时间戳
     *
     * @var int
     */
    public $closeTimestamp;

    /**
     * @description 订单创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 订单创建时间戳
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @var int
     */
    public $labelAmount;

    /**
     * @description 商户id。
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 商户聚合支付订单号。
     *
     * @var string
     */
    public $merchantMergeOrderNo;

    /**
     * @description 商户订单号。
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @description 订单号。
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 订单类型。
     *
     * @var string
     */
    public $orderType;

    /**
     * @description 用户唯一id。
     *
     * @var string
     */
    public $outerUserId;

    /**
     * @description 买家支付id。
     *
     * @var string
     */
    public $payId;

    /**
     * @description 买家支付登陆id。
     *
     * @var string
     */
    public $payLogonId;

    /**
     * @var int
     */
    public $payStatus;

    /**
     * @description 订单支付时间
     *
     * @var string
     */
    public $payTime;

    /**
     * @description 订单支付时间戳
     *
     * @var int
     */
    public $payTimestamp;

    /**
     * @description 买家支付渠道类型。
     *
     * @var string
     */
    public $payType;

    /**
     * @var int
     */
    public $refundAmount;

    /**
     * @var int
     */
    public $refundStatus;

    /**
     * @description 订单退款时间
     *
     * @var string
     */
    public $refundTime;

    /**
     * @description 订单退款时间戳
     *
     * @var int
     */
    public $refundTimestamp;

    /**
     * @description 订单标题。
     *
     * @var string
     */
    public $subject;

    /**
     * @description 交易流水号。
     *
     * @var string
     */
    public $tradeNo;
    protected $_name = [
        'actualAmount'         => 'actualAmount',
        'alipayAppId'          => 'alipayAppId',
        'closeTime'            => 'closeTime',
        'closeTimestamp'       => 'closeTimestamp',
        'createTime'           => 'createTime',
        'createTimestamp'      => 'createTimestamp',
        'labelAmount'          => 'labelAmount',
        'merchantId'           => 'merchantId',
        'merchantMergeOrderNo' => 'merchantMergeOrderNo',
        'merchantOrderNo'      => 'merchantOrderNo',
        'orderNo'              => 'orderNo',
        'orderType'            => 'orderType',
        'outerUserId'          => 'outerUserId',
        'payId'                => 'payId',
        'payLogonId'           => 'payLogonId',
        'payStatus'            => 'payStatus',
        'payTime'              => 'payTime',
        'payTimestamp'         => 'payTimestamp',
        'payType'              => 'payType',
        'refundAmount'         => 'refundAmount',
        'refundStatus'         => 'refundStatus',
        'refundTime'           => 'refundTime',
        'refundTimestamp'      => 'refundTimestamp',
        'subject'              => 'subject',
        'tradeNo'              => 'tradeNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->alipayAppId) {
            $res['alipayAppId'] = $this->alipayAppId;
        }
        if (null !== $this->closeTime) {
            $res['closeTime'] = $this->closeTime;
        }
        if (null !== $this->closeTimestamp) {
            $res['closeTimestamp'] = $this->closeTimestamp;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->createTimestamp) {
            $res['createTimestamp'] = $this->createTimestamp;
        }
        if (null !== $this->labelAmount) {
            $res['labelAmount'] = $this->labelAmount;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->merchantMergeOrderNo) {
            $res['merchantMergeOrderNo'] = $this->merchantMergeOrderNo;
        }
        if (null !== $this->merchantOrderNo) {
            $res['merchantOrderNo'] = $this->merchantOrderNo;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->outerUserId) {
            $res['outerUserId'] = $this->outerUserId;
        }
        if (null !== $this->payId) {
            $res['payId'] = $this->payId;
        }
        if (null !== $this->payLogonId) {
            $res['payLogonId'] = $this->payLogonId;
        }
        if (null !== $this->payStatus) {
            $res['payStatus'] = $this->payStatus;
        }
        if (null !== $this->payTime) {
            $res['payTime'] = $this->payTime;
        }
        if (null !== $this->payTimestamp) {
            $res['payTimestamp'] = $this->payTimestamp;
        }
        if (null !== $this->payType) {
            $res['payType'] = $this->payType;
        }
        if (null !== $this->refundAmount) {
            $res['refundAmount'] = $this->refundAmount;
        }
        if (null !== $this->refundStatus) {
            $res['refundStatus'] = $this->refundStatus;
        }
        if (null !== $this->refundTime) {
            $res['refundTime'] = $this->refundTime;
        }
        if (null !== $this->refundTimestamp) {
            $res['refundTimestamp'] = $this->refundTimestamp;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySnsOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['alipayAppId'])) {
            $model->alipayAppId = $map['alipayAppId'];
        }
        if (isset($map['closeTime'])) {
            $model->closeTime = $map['closeTime'];
        }
        if (isset($map['closeTimestamp'])) {
            $model->closeTimestamp = $map['closeTimestamp'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['createTimestamp'])) {
            $model->createTimestamp = $map['createTimestamp'];
        }
        if (isset($map['labelAmount'])) {
            $model->labelAmount = $map['labelAmount'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['merchantMergeOrderNo'])) {
            $model->merchantMergeOrderNo = $map['merchantMergeOrderNo'];
        }
        if (isset($map['merchantOrderNo'])) {
            $model->merchantOrderNo = $map['merchantOrderNo'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['outerUserId'])) {
            $model->outerUserId = $map['outerUserId'];
        }
        if (isset($map['payId'])) {
            $model->payId = $map['payId'];
        }
        if (isset($map['payLogonId'])) {
            $model->payLogonId = $map['payLogonId'];
        }
        if (isset($map['payStatus'])) {
            $model->payStatus = $map['payStatus'];
        }
        if (isset($map['payTime'])) {
            $model->payTime = $map['payTime'];
        }
        if (isset($map['payTimestamp'])) {
            $model->payTimestamp = $map['payTimestamp'];
        }
        if (isset($map['payType'])) {
            $model->payType = $map['payType'];
        }
        if (isset($map['refundAmount'])) {
            $model->refundAmount = $map['refundAmount'];
        }
        if (isset($map['refundStatus'])) {
            $model->refundStatus = $map['refundStatus'];
        }
        if (isset($map['refundTime'])) {
            $model->refundTime = $map['refundTime'];
        }
        if (isset($map['refundTimestamp'])) {
            $model->refundTimestamp = $map['refundTimestamp'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }

        return $model;
    }
}
