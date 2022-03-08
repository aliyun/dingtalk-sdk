<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultRequest;

use AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodeRefundResultRequest\payChannelDetailList\fundToolDetailList;
use AlibabaCloud\Tea\Model;

class payChannelDetailList extends Model
{
    /**
     * @description 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 支付资金列表
     *
     * @var fundToolDetailList[]
     */
    public $fundToolDetailList;

    /**
     * @description 支付渠道名称
     *
     * @var string
     */
    public $payChannelName;

    /**
     * @description 支付渠道号
     *
     * @var string
     */
    public $payChannelOrderNo;

    /**
     * @description 支付渠道退款号
     *
     * @var string
     */
    public $payChannelRefundOrderNo;

    /**
     * @description 支付渠道类型
     *
     * @var string
     */
    public $payChannelType;

    /**
     * @description 优惠金额
     *
     * @var string
     */
    public $promotionAmount;
    protected $_name = [
        'amount'                  => 'amount',
        'fundToolDetailList'      => 'fundToolDetailList',
        'payChannelName'          => 'payChannelName',
        'payChannelOrderNo'       => 'payChannelOrderNo',
        'payChannelRefundOrderNo' => 'payChannelRefundOrderNo',
        'payChannelType'          => 'payChannelType',
        'promotionAmount'         => 'promotionAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->fundToolDetailList) {
            $res['fundToolDetailList'] = [];
            if (null !== $this->fundToolDetailList && \is_array($this->fundToolDetailList)) {
                $n = 0;
                foreach ($this->fundToolDetailList as $item) {
                    $res['fundToolDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->payChannelName) {
            $res['payChannelName'] = $this->payChannelName;
        }
        if (null !== $this->payChannelOrderNo) {
            $res['payChannelOrderNo'] = $this->payChannelOrderNo;
        }
        if (null !== $this->payChannelRefundOrderNo) {
            $res['payChannelRefundOrderNo'] = $this->payChannelRefundOrderNo;
        }
        if (null !== $this->payChannelType) {
            $res['payChannelType'] = $this->payChannelType;
        }
        if (null !== $this->promotionAmount) {
            $res['promotionAmount'] = $this->promotionAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payChannelDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['fundToolDetailList'])) {
            if (!empty($map['fundToolDetailList'])) {
                $model->fundToolDetailList = [];
                $n                         = 0;
                foreach ($map['fundToolDetailList'] as $item) {
                    $model->fundToolDetailList[$n++] = null !== $item ? fundToolDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['payChannelName'])) {
            $model->payChannelName = $map['payChannelName'];
        }
        if (isset($map['payChannelOrderNo'])) {
            $model->payChannelOrderNo = $map['payChannelOrderNo'];
        }
        if (isset($map['payChannelRefundOrderNo'])) {
            $model->payChannelRefundOrderNo = $map['payChannelRefundOrderNo'];
        }
        if (isset($map['payChannelType'])) {
            $model->payChannelType = $map['payChannelType'];
        }
        if (isset($map['promotionAmount'])) {
            $model->promotionAmount = $map['promotionAmount'];
        }

        return $model;
    }
}
