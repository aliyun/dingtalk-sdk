<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrderResponseBody extends Model
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
     * @description 订单关单时间。
     *
     * @var int
     */
    public $closeTime;

    /**
     * @description 订单创建时间。
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 扩展字段。
     *
     * @var string
     */
    public $feature;

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
     * @description 订单支付时间。
     *
     * @var int
     */
    public $payTime;

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
     * @description 订单退款时间。
     *
     * @var int
     */
    public $refundTime;

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

    /**
     * @description 用户唯一id。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'actualAmount'         => 'actualAmount',
        'alipayAppId'          => 'alipayAppId',
        'closeTime'            => 'closeTime',
        'createTime'           => 'createTime',
        'feature'              => 'feature',
        'labelAmount'          => 'labelAmount',
        'merchantId'           => 'merchantId',
        'merchantMergeOrderNo' => 'merchantMergeOrderNo',
        'merchantOrderNo'      => 'merchantOrderNo',
        'orderNo'              => 'orderNo',
        'orderType'            => 'orderType',
        'payId'                => 'payId',
        'payLogonId'           => 'payLogonId',
        'payStatus'            => 'payStatus',
        'payTime'              => 'payTime',
        'payType'              => 'payType',
        'refundAmount'         => 'refundAmount',
        'refundStatus'         => 'refundStatus',
        'refundTime'           => 'refundTime',
        'subject'              => 'subject',
        'tradeNo'              => 'tradeNo',
        'userId'               => 'userId',
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
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->feature) {
            $res['feature'] = $this->feature;
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
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrderResponseBody
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['feature'])) {
            $model->feature = $map['feature'];
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
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
