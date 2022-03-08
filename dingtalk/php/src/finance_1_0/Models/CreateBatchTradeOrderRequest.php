<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest\batchTradeDetails;
use AlibabaCloud\Tea\Model;

class CreateBatchTradeOrderRequest extends Model
{
    /**
     * @description 付款账号唯一id
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 付款账号(注意：用户上送的是脱敏数据)
     *
     * @var string
     */
    public $accountNo;

    /**
     * @description 批次备注
     *
     * @var string
     */
    public $batchRemark;

    /**
     * @description 交易明细列表
     *
     * @var batchTradeDetails[]
     */
    public $batchTradeDetails;

    /**
     * @description 外部商户批次号
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description 员工staffId
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 总金额（必填，单位：元）
     *
     * @var string
     */
    public $totalAmount;

    /**
     * @description 总笔数（必填）
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description 交易抬头
     *
     * @var string
     */
    public $tradeTitle;
    protected $_name = [
        'accountId'         => 'accountId',
        'accountNo'         => 'accountNo',
        'batchRemark'       => 'batchRemark',
        'batchTradeDetails' => 'batchTradeDetails',
        'outBatchNo'        => 'outBatchNo',
        'staffId'           => 'staffId',
        'totalAmount'       => 'totalAmount',
        'totalCount'        => 'totalCount',
        'tradeTitle'        => 'tradeTitle',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountNo) {
            $res['accountNo'] = $this->accountNo;
        }
        if (null !== $this->batchRemark) {
            $res['batchRemark'] = $this->batchRemark;
        }
        if (null !== $this->batchTradeDetails) {
            $res['batchTradeDetails'] = [];
            if (null !== $this->batchTradeDetails && \is_array($this->batchTradeDetails)) {
                $n = 0;
                foreach ($this->batchTradeDetails as $item) {
                    $res['batchTradeDetails'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->tradeTitle) {
            $res['tradeTitle'] = $this->tradeTitle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBatchTradeOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountNo'])) {
            $model->accountNo = $map['accountNo'];
        }
        if (isset($map['batchRemark'])) {
            $model->batchRemark = $map['batchRemark'];
        }
        if (isset($map['batchTradeDetails'])) {
            if (!empty($map['batchTradeDetails'])) {
                $model->batchTradeDetails = [];
                $n                        = 0;
                foreach ($map['batchTradeDetails'] as $item) {
                    $model->batchTradeDetails[$n++] = null !== $item ? batchTradeDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['tradeTitle'])) {
            $model->tradeTitle = $map['tradeTitle'];
        }

        return $model;
    }
}
