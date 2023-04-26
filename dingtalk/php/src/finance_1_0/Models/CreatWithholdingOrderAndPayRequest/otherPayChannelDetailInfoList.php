<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayRequest;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreatWithholdingOrderAndPayRequest\otherPayChannelDetailInfoList\fundToolDetailInfoList;
use AlibabaCloud\Tea\Model;

class otherPayChannelDetailInfoList extends Model
{
    /**
     * @example 5.00
     *
     * @var string
     */
    public $amount;

    /**
     * @var fundToolDetailInfoList[]
     */
    public $fundToolDetailInfoList;

    /**
     * @example 支付宝
     *
     * @var string
     */
    public $payChannelName;

    /**
     * @example 2021110100001
     *
     * @var string
     */
    public $payChannelOrderNo;

    /**
     * @example ALIPAY
     *
     * @var string
     */
    public $payChannelType;

    /**
     * @example 4.00
     *
     * @var string
     */
    public $promotionAmount;
    protected $_name = [
        'amount'                 => 'amount',
        'fundToolDetailInfoList' => 'fundToolDetailInfoList',
        'payChannelName'         => 'payChannelName',
        'payChannelOrderNo'      => 'payChannelOrderNo',
        'payChannelType'         => 'payChannelType',
        'promotionAmount'        => 'promotionAmount',
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
        if (null !== $this->fundToolDetailInfoList) {
            $res['fundToolDetailInfoList'] = [];
            if (null !== $this->fundToolDetailInfoList && \is_array($this->fundToolDetailInfoList)) {
                $n = 0;
                foreach ($this->fundToolDetailInfoList as $item) {
                    $res['fundToolDetailInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->payChannelName) {
            $res['payChannelName'] = $this->payChannelName;
        }
        if (null !== $this->payChannelOrderNo) {
            $res['payChannelOrderNo'] = $this->payChannelOrderNo;
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
     * @return otherPayChannelDetailInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['fundToolDetailInfoList'])) {
            if (!empty($map['fundToolDetailInfoList'])) {
                $model->fundToolDetailInfoList = [];
                $n                             = 0;
                foreach ($map['fundToolDetailInfoList'] as $item) {
                    $model->fundToolDetailInfoList[$n++] = null !== $item ? fundToolDetailInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['payChannelName'])) {
            $model->payChannelName = $map['payChannelName'];
        }
        if (isset($map['payChannelOrderNo'])) {
            $model->payChannelOrderNo = $map['payChannelOrderNo'];
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
