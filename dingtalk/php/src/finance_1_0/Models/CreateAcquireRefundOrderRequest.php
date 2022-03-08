<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateAcquireRefundOrderRequest\otherPayChannelDetailInfoList;
use AlibabaCloud\Tea\Model;

class CreateAcquireRefundOrderRequest extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description 原支付单外部流水号
     *
     * @var string
     */
    public $originOutTradeNo;

    /**
     * @description 其他资金渠道退款明细
     *
     * @var otherPayChannelDetailInfoList[]
     */
    public $otherPayChannelDetailInfoList;

    /**
     * @description 外部退款订单号
     *
     * @var string
     */
    public $outRefundNo;

    /**
     * @description 退款金额，支持部分退款
     *
     * @var string
     */
    public $refundAmount;

    /**
     * @description 退款备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 代扣标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'instId'                        => 'instId',
        'operatorUserId'                => 'operatorUserId',
        'originOutTradeNo'              => 'originOutTradeNo',
        'otherPayChannelDetailInfoList' => 'otherPayChannelDetailInfoList',
        'outRefundNo'                   => 'outRefundNo',
        'refundAmount'                  => 'refundAmount',
        'remark'                        => 'remark',
        'subInstId'                     => 'subInstId',
        'title'                         => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->originOutTradeNo) {
            $res['originOutTradeNo'] = $this->originOutTradeNo;
        }
        if (null !== $this->otherPayChannelDetailInfoList) {
            $res['otherPayChannelDetailInfoList'] = [];
            if (null !== $this->otherPayChannelDetailInfoList && \is_array($this->otherPayChannelDetailInfoList)) {
                $n = 0;
                foreach ($this->otherPayChannelDetailInfoList as $item) {
                    $res['otherPayChannelDetailInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outRefundNo) {
            $res['outRefundNo'] = $this->outRefundNo;
        }
        if (null !== $this->refundAmount) {
            $res['refundAmount'] = $this->refundAmount;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAcquireRefundOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['originOutTradeNo'])) {
            $model->originOutTradeNo = $map['originOutTradeNo'];
        }
        if (isset($map['otherPayChannelDetailInfoList'])) {
            if (!empty($map['otherPayChannelDetailInfoList'])) {
                $model->otherPayChannelDetailInfoList = [];
                $n                                    = 0;
                foreach ($map['otherPayChannelDetailInfoList'] as $item) {
                    $model->otherPayChannelDetailInfoList[$n++] = null !== $item ? otherPayChannelDetailInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outRefundNo'])) {
            $model->outRefundNo = $map['outRefundNo'];
        }
        if (isset($map['refundAmount'])) {
            $model->refundAmount = $map['refundAmount'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
