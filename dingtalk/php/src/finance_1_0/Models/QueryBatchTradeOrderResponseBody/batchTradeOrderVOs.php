<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderResponseBody;

use AlibabaCloud\Tea\Model;

class batchTradeOrderVOs extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2021090102102122200002121
     *
     * @var string
     */
    public $alipayTransId;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var string
     */
    public $failAmount;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $failCount;

    /**
     * @description This parameter is required.
     *
     * @example 收款人不存在
     *
     * @var string
     */
    public $failReason;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-01 12:00:00
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-01 11:00:00
     *
     * @var string
     */
    public $gmtSubmit;

    /**
     * @description This parameter is required.
     *
     * @example 20210901001
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description This parameter is required.
     *
     * @example 213654465
     *
     * @var string
     */
    public $payerStaffId;

    /**
     * @description This parameter is required.
     *
     * @example 1.00
     *
     * @var string
     */
    public $paymentAmount;

    /**
     * @description This parameter is required.
     *
     * @example CNY
     *
     * @var string
     */
    public $paymentCurrency;

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
     * @example 1.00
     *
     * @var string
     */
    public $successAmount;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $successCount;

    /**
     * @description This parameter is required.
     *
     * @example 1.00
     *
     * @var string
     */
    public $totalAmount;
    protected $_name = [
        'alipayTransId' => 'alipayTransId',
        'failAmount' => 'failAmount',
        'failCount' => 'failCount',
        'failReason' => 'failReason',
        'gmtFinish' => 'gmtFinish',
        'gmtSubmit' => 'gmtSubmit',
        'outBatchNo' => 'outBatchNo',
        'payerStaffId' => 'payerStaffId',
        'paymentAmount' => 'paymentAmount',
        'paymentCurrency' => 'paymentCurrency',
        'status' => 'status',
        'successAmount' => 'successAmount',
        'successCount' => 'successCount',
        'totalAmount' => 'totalAmount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayTransId) {
            $res['alipayTransId'] = $this->alipayTransId;
        }
        if (null !== $this->failAmount) {
            $res['failAmount'] = $this->failAmount;
        }
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->gmtFinish) {
            $res['gmtFinish'] = $this->gmtFinish;
        }
        if (null !== $this->gmtSubmit) {
            $res['gmtSubmit'] = $this->gmtSubmit;
        }
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->payerStaffId) {
            $res['payerStaffId'] = $this->payerStaffId;
        }
        if (null !== $this->paymentAmount) {
            $res['paymentAmount'] = $this->paymentAmount;
        }
        if (null !== $this->paymentCurrency) {
            $res['paymentCurrency'] = $this->paymentCurrency;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->successAmount) {
            $res['successAmount'] = $this->successAmount;
        }
        if (null !== $this->successCount) {
            $res['successCount'] = $this->successCount;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
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
        if (isset($map['alipayTransId'])) {
            $model->alipayTransId = $map['alipayTransId'];
        }
        if (isset($map['failAmount'])) {
            $model->failAmount = $map['failAmount'];
        }
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['gmtFinish'])) {
            $model->gmtFinish = $map['gmtFinish'];
        }
        if (isset($map['gmtSubmit'])) {
            $model->gmtSubmit = $map['gmtSubmit'];
        }
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['payerStaffId'])) {
            $model->payerStaffId = $map['payerStaffId'];
        }
        if (isset($map['paymentAmount'])) {
            $model->paymentAmount = $map['paymentAmount'];
        }
        if (isset($map['paymentCurrency'])) {
            $model->paymentCurrency = $map['paymentCurrency'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['successAmount'])) {
            $model->successAmount = $map['successAmount'];
        }
        if (isset($map['successCount'])) {
            $model->successCount = $map['successCount'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }

        return $model;
    }
}
