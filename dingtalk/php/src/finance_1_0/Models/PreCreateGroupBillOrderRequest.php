<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderRequest\billItemList;
use AlibabaCloud\Tea\Model;

class PreCreateGroupBillOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var billItemList[]
     */
    public $billItemList;

    /**
     * @var string[]
     */
    public $extParams;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $headCount;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $isAverageAmount;

    /**
     * @description This parameter is required.
     *
     * @example dhqhadsnkj2qweqsw2
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example opemcesdjuwqw2uwnedj==
     *
     * @var string
     */
    public $openCid;

    /**
     * @description This parameter is required.
     *
     * @example 20230918291921929193911
     *
     * @var string
     */
    public $outBizNo;

    /**
     * @example ding32fff839a3e0105d
     *
     * @var string
     */
    public $payeeCorpId;

    /**
     * @description This parameter is required.
     *
     * @example ECEjwiiwenwnw2q2sdd
     *
     * @var string
     */
    public $payeeUnionId;

    /**
     * @example 饿了么拼单-测试
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 10.24
     *
     * @var string
     */
    public $totalAmount;
    protected $_name = [
        'billItemList' => 'billItemList',
        'extParams' => 'extParams',
        'headCount' => 'headCount',
        'isAverageAmount' => 'isAverageAmount',
        'merchantId' => 'merchantId',
        'openCid' => 'openCid',
        'outBizNo' => 'outBizNo',
        'payeeCorpId' => 'payeeCorpId',
        'payeeUnionId' => 'payeeUnionId',
        'remark' => 'remark',
        'totalAmount' => 'totalAmount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->billItemList) {
            $res['billItemList'] = [];
            if (null !== $this->billItemList && \is_array($this->billItemList)) {
                $n = 0;
                foreach ($this->billItemList as $item) {
                    $res['billItemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->extParams) {
            $res['extParams'] = $this->extParams;
        }
        if (null !== $this->headCount) {
            $res['headCount'] = $this->headCount;
        }
        if (null !== $this->isAverageAmount) {
            $res['isAverageAmount'] = $this->isAverageAmount;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->openCid) {
            $res['openCid'] = $this->openCid;
        }
        if (null !== $this->outBizNo) {
            $res['outBizNo'] = $this->outBizNo;
        }
        if (null !== $this->payeeCorpId) {
            $res['payeeCorpId'] = $this->payeeCorpId;
        }
        if (null !== $this->payeeUnionId) {
            $res['payeeUnionId'] = $this->payeeUnionId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PreCreateGroupBillOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['billItemList'])) {
            if (!empty($map['billItemList'])) {
                $model->billItemList = [];
                $n = 0;
                foreach ($map['billItemList'] as $item) {
                    $model->billItemList[$n++] = null !== $item ? billItemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['extParams'])) {
            $model->extParams = $map['extParams'];
        }
        if (isset($map['headCount'])) {
            $model->headCount = $map['headCount'];
        }
        if (isset($map['isAverageAmount'])) {
            $model->isAverageAmount = $map['isAverageAmount'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['openCid'])) {
            $model->openCid = $map['openCid'];
        }
        if (isset($map['outBizNo'])) {
            $model->outBizNo = $map['outBizNo'];
        }
        if (isset($map['payeeCorpId'])) {
            $model->payeeCorpId = $map['payeeCorpId'];
        }
        if (isset($map['payeeUnionId'])) {
            $model->payeeUnionId = $map['payeeUnionId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }

        return $model;
    }
}
