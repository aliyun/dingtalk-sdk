<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderResponseBody;

use AlibabaCloud\Tea\Model;

class batchTradeOrderVOs extends Model
{
    /**
     * @description 批次号
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description 支付宝批次订单号
     *
     * @var string
     */
    public $alipayTransId;

    /**
     * @description 状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 成功笔数
     *
     * @var int
     */
    public $successCount;

    /**
     * @description 成功金额（元）
     *
     * @var string
     */
    public $successAmount;

    /**
     * @description 失败笔数
     *
     * @var int
     */
    public $failCount;

    /**
     * @description 明细处理失败的支付汇总金额
     *
     * @var string
     */
    public $failAmount;

    /**
     * @description 批次的总金额（元）
     *
     * @var string
     */
    public $totalAmount;

    /**
     * @description 批次完成交易时间
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description 批次受理交易时间
     *
     * @var string
     */
    public $gmtSubmit;

    /**
     * @description 失败原因
     *
     * @var string
     */
    public $failReason;

    /**
     * @description 付款方需要支付的金额（元）
     *
     * @var string
     */
    public $paymentAmount;

    /**
     * @description 支付币种
     *
     * @var string
     */
    public $paymentCurrency;

    /**
     * @description 付款人staffId
     *
     * @var string
     */
    public $payerStaffId;
    protected $_name = [
        'outBatchNo'      => 'outBatchNo',
        'alipayTransId'   => 'alipayTransId',
        'status'          => 'status',
        'successCount'    => 'successCount',
        'successAmount'   => 'successAmount',
        'failCount'       => 'failCount',
        'failAmount'      => 'failAmount',
        'totalAmount'     => 'totalAmount',
        'gmtFinish'       => 'gmtFinish',
        'gmtSubmit'       => 'gmtSubmit',
        'failReason'      => 'failReason',
        'paymentAmount'   => 'paymentAmount',
        'paymentCurrency' => 'paymentCurrency',
        'payerStaffId'    => 'payerStaffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->alipayTransId) {
            $res['alipayTransId'] = $this->alipayTransId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->successCount) {
            $res['successCount'] = $this->successCount;
        }
        if (null !== $this->successAmount) {
            $res['successAmount'] = $this->successAmount;
        }
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->failAmount) {
            $res['failAmount'] = $this->failAmount;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->gmtFinish) {
            $res['gmtFinish'] = $this->gmtFinish;
        }
        if (null !== $this->gmtSubmit) {
            $res['gmtSubmit'] = $this->gmtSubmit;
        }
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->paymentAmount) {
            $res['paymentAmount'] = $this->paymentAmount;
        }
        if (null !== $this->paymentCurrency) {
            $res['paymentCurrency'] = $this->paymentCurrency;
        }
        if (null !== $this->payerStaffId) {
            $res['payerStaffId'] = $this->payerStaffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return batchTradeOrderVOs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['alipayTransId'])) {
            $model->alipayTransId = $map['alipayTransId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['successCount'])) {
            $model->successCount = $map['successCount'];
        }
        if (isset($map['successAmount'])) {
            $model->successAmount = $map['successAmount'];
        }
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['failAmount'])) {
            $model->failAmount = $map['failAmount'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['gmtFinish'])) {
            $model->gmtFinish = $map['gmtFinish'];
        }
        if (isset($map['gmtSubmit'])) {
            $model->gmtSubmit = $map['gmtSubmit'];
        }
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['paymentAmount'])) {
            $model->paymentAmount = $map['paymentAmount'];
        }
        if (isset($map['paymentCurrency'])) {
            $model->paymentCurrency = $map['paymentCurrency'];
        }
        if (isset($map['payerStaffId'])) {
            $model->payerStaffId = $map['payerStaffId'];
        }

        return $model;
    }
}
