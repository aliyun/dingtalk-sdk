<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest\payChannelDetailList\fundToolDetailList;
use AlibabaCloud\Tea\Model;

class payChannelDetailList extends Model
{
    /**
     * @description 支付金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 资金工具明细
     *
     * @var fundToolDetailList[]
     */
    public $fundToolDetailList;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description 支付渠道名称
     *
     * @var string
     */
    public $payChannelName;

    /**
     * @description 支付渠道单号
     *
     * @var string
     */
    public $payChannelOrderNo;

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
        'amount'             => 'amount',
        'fundToolDetailList' => 'fundToolDetailList',
        'gmtCreate'          => 'gmtCreate',
        'gmtFinish'          => 'gmtFinish',
        'payChannelName'     => 'payChannelName',
        'payChannelOrderNo'  => 'payChannelOrderNo',
        'payChannelType'     => 'payChannelType',
        'promotionAmount'    => 'promotionAmount',
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
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtFinish) {
            $res['gmtFinish'] = $this->gmtFinish;
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
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtFinish'])) {
            $model->gmtFinish = $map['gmtFinish'];
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
