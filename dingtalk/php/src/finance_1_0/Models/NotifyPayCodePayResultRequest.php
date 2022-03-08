<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest\payChannelDetailList;
use AlibabaCloud\Tea\Model;

class NotifyPayCodePayResultRequest extends Model
{
    /**
     * @description 订单金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 收费金额
     *
     * @var string
     */
    public $chargeAmount;

    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description 交易开始时间
     *
     * @var string
     */
    public $gmtTradeCreate;

    /**
     * @description 交易结束时间
     *
     * @var string
     */
    public $gmtTradeFinish;

    /**
     * @description merchantName
     *
     * @var string
     */
    public $merchantName;

    /**
     * @description 支付渠道明细信息
     *
     * @var payChannelDetailList[]
     */
    public $payChannelDetailList;

    /**
     * @description 付款码值
     *
     * @var string
     */
    public $payCode;

    /**
     * @description 订单优惠金额
     *
     * @var string
     */
    public $promotionAmount;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 订单标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 支付失败错误码
     *
     * @var string
     */
    public $tradeErrorCode;

    /**
     * @description 支付失败信息
     *
     * @var string
     */
    public $tradeErrorMsg;

    /**
     * @description 交易号
     *
     * @var string
     */
    public $tradeNo;

    /**
     * @description 交易状态
     *
     * @var string
     */
    public $tradeStatus;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'amount'               => 'amount',
        'chargeAmount'         => 'chargeAmount',
        'corpId'               => 'corpId',
        'extInfo'              => 'extInfo',
        'gmtTradeCreate'       => 'gmtTradeCreate',
        'gmtTradeFinish'       => 'gmtTradeFinish',
        'merchantName'         => 'merchantName',
        'payChannelDetailList' => 'payChannelDetailList',
        'payCode'              => 'payCode',
        'promotionAmount'      => 'promotionAmount',
        'remark'               => 'remark',
        'title'                => 'title',
        'tradeErrorCode'       => 'tradeErrorCode',
        'tradeErrorMsg'        => 'tradeErrorMsg',
        'tradeNo'              => 'tradeNo',
        'tradeStatus'          => 'tradeStatus',
        'userId'               => 'userId',
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
        if (null !== $this->chargeAmount) {
            $res['chargeAmount'] = $this->chargeAmount;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->gmtTradeCreate) {
            $res['gmtTradeCreate'] = $this->gmtTradeCreate;
        }
        if (null !== $this->gmtTradeFinish) {
            $res['gmtTradeFinish'] = $this->gmtTradeFinish;
        }
        if (null !== $this->merchantName) {
            $res['merchantName'] = $this->merchantName;
        }
        if (null !== $this->payChannelDetailList) {
            $res['payChannelDetailList'] = [];
            if (null !== $this->payChannelDetailList && \is_array($this->payChannelDetailList)) {
                $n = 0;
                foreach ($this->payChannelDetailList as $item) {
                    $res['payChannelDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->payCode) {
            $res['payCode'] = $this->payCode;
        }
        if (null !== $this->promotionAmount) {
            $res['promotionAmount'] = $this->promotionAmount;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->tradeErrorCode) {
            $res['tradeErrorCode'] = $this->tradeErrorCode;
        }
        if (null !== $this->tradeErrorMsg) {
            $res['tradeErrorMsg'] = $this->tradeErrorMsg;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->tradeStatus) {
            $res['tradeStatus'] = $this->tradeStatus;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NotifyPayCodePayResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['chargeAmount'])) {
            $model->chargeAmount = $map['chargeAmount'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['gmtTradeCreate'])) {
            $model->gmtTradeCreate = $map['gmtTradeCreate'];
        }
        if (isset($map['gmtTradeFinish'])) {
            $model->gmtTradeFinish = $map['gmtTradeFinish'];
        }
        if (isset($map['merchantName'])) {
            $model->merchantName = $map['merchantName'];
        }
        if (isset($map['payChannelDetailList'])) {
            if (!empty($map['payChannelDetailList'])) {
                $model->payChannelDetailList = [];
                $n                           = 0;
                foreach ($map['payChannelDetailList'] as $item) {
                    $model->payChannelDetailList[$n++] = null !== $item ? payChannelDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['payCode'])) {
            $model->payCode = $map['payCode'];
        }
        if (isset($map['promotionAmount'])) {
            $model->promotionAmount = $map['promotionAmount'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['tradeErrorCode'])) {
            $model->tradeErrorCode = $map['tradeErrorCode'];
        }
        if (isset($map['tradeErrorMsg'])) {
            $model->tradeErrorMsg = $map['tradeErrorMsg'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['tradeStatus'])) {
            $model->tradeStatus = $map['tradeStatus'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
