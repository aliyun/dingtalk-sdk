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
     * @example 123400
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @example 2022-11-04T17:15Z
     *
     * @var string
     */
    public $closeTime;

    /**
     * @example 1672973971107
     *
     * @var int
     */
    public $closeTimestamp;

    /**
     * @example 2022-11-04T17:15Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 1672973971107
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @var int
     */
    public $labelAmount;

    /**
     * @example 10000
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example M20000100
     *
     * @var string
     */
    public $merchantMergeOrderNo;

    /**
     * @example M20000100
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @example CM0001
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example 1
     *
     * @var string
     */
    public $orderType;

    /**
     * @example fagweefdsdgfa
     *
     * @var string
     */
    public $outerUserId;

    /**
     * @example 138***
     *
     * @var string
     */
    public $payLogonId;

    /**
     * @var int
     */
    public $payStatus;

    /**
     * @example 2022-11-04T17:15Z
     *
     * @var string
     */
    public $payTime;

    /**
     * @example 1672973971107
     *
     * @var int
     */
    public $payTimestamp;

    /**
     * @example 1
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
     * @example 2022-11-04T17:15Z
     *
     * @var string
     */
    public $refundTime;

    /**
     * @example 1672973971107
     *
     * @var int
     */
    public $refundTimestamp;

    /**
     * @example 教育产品
     *
     * @var string
     */
    public $subject;

    /**
     * @example 2022080311111
     *
     * @var string
     */
    public $tradeNo;
    protected $_name = [
        'actualAmount' => 'actualAmount',
        'alipayAppId' => 'alipayAppId',
        'closeTime' => 'closeTime',
        'closeTimestamp' => 'closeTimestamp',
        'createTime' => 'createTime',
        'createTimestamp' => 'createTimestamp',
        'labelAmount' => 'labelAmount',
        'merchantId' => 'merchantId',
        'merchantMergeOrderNo' => 'merchantMergeOrderNo',
        'merchantOrderNo' => 'merchantOrderNo',
        'orderNo' => 'orderNo',
        'orderType' => 'orderType',
        'outerUserId' => 'outerUserId',
        'payLogonId' => 'payLogonId',
        'payStatus' => 'payStatus',
        'payTime' => 'payTime',
        'payTimestamp' => 'payTimestamp',
        'payType' => 'payType',
        'refundAmount' => 'refundAmount',
        'refundStatus' => 'refundStatus',
        'refundTime' => 'refundTime',
        'refundTimestamp' => 'refundTimestamp',
        'subject' => 'subject',
        'tradeNo' => 'tradeNo',
    ];

    public function validate() {}

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
