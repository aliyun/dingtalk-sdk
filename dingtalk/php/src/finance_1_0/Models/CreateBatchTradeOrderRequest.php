<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest\batchTradeDetails;
use AlibabaCloud\Tea\Model;

class CreateBatchTradeOrderRequest extends Model
{
    /**
     * @description ISV/企业自建应用suiteId
     *
     * @var string
     */
    public $suiteId;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 员工staffId
     *
     * @var string
     */
    public $staffId;

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
     * @description 交易抬头
     *
     * @var string
     */
    public $tradeTitle;

    /**
     * @description 外部商户批次号
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description 批次备注
     *
     * @var string
     */
    public $batchRemark;

    /**
     * @description 总笔数（必填）
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description 总金额（必填，单位：元）
     *
     * @var string
     */
    public $totalAmount;

    /**
     * @description 交易明细列表
     *
     * @var batchTradeDetails[]
     */
    public $batchTradeDetails;

    /**
     * @description Isv corpId
     *
     * @var string
     */
    public $isvCorpId;
    protected $_name = [
        'suiteId'           => 'suiteId',
        'corpId'            => 'corpId',
        'staffId'           => 'staffId',
        'accountId'         => 'accountId',
        'accountNo'         => 'accountNo',
        'tradeTitle'        => 'tradeTitle',
        'outBatchNo'        => 'outBatchNo',
        'batchRemark'       => 'batchRemark',
        'totalCount'        => 'totalCount',
        'totalAmount'       => 'totalAmount',
        'batchTradeDetails' => 'batchTradeDetails',
        'isvCorpId'         => 'isvCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountNo) {
            $res['accountNo'] = $this->accountNo;
        }
        if (null !== $this->tradeTitle) {
            $res['tradeTitle'] = $this->tradeTitle;
        }
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->batchRemark) {
            $res['batchRemark'] = $this->batchRemark;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
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
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
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
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountNo'])) {
            $model->accountNo = $map['accountNo'];
        }
        if (isset($map['tradeTitle'])) {
            $model->tradeTitle = $map['tradeTitle'];
        }
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['batchRemark'])) {
            $model->batchRemark = $map['batchRemark'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
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
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }

        return $model;
    }
}
