<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyBatchPayRequest extends Model
{
    /**
     * @description 支付账号唯一id
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 钉钉订单号(和商户批次号一一对应)
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数
     *
     * @var mixed[]
     */
    public $passBackParams;

    /**
     * @description 支付终端
     *
     * @var string
     */
    public $payTerminal;

    /**
     * @description 回调url
     *
     * @var string
     */
    public $returnUrl;

    /**
     * @description 支付发起人staffId
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 订单总金额（必填）, 单位为：元
     *
     * @var string
     */
    public $transAmount;

    /**
     * @description 转账过期时间
     *
     * @var string
     */
    public $transExpireTime;
    protected $_name = [
        'accountId'       => 'accountId',
        'orderNo'         => 'orderNo',
        'passBackParams'  => 'passBackParams',
        'payTerminal'     => 'payTerminal',
        'returnUrl'       => 'returnUrl',
        'staffId'         => 'staffId',
        'transAmount'     => 'transAmount',
        'transExpireTime' => 'transExpireTime',
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
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->passBackParams) {
            $res['passBackParams'] = $this->passBackParams;
        }
        if (null !== $this->payTerminal) {
            $res['payTerminal'] = $this->payTerminal;
        }
        if (null !== $this->returnUrl) {
            $res['returnUrl'] = $this->returnUrl;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->transAmount) {
            $res['transAmount'] = $this->transAmount;
        }
        if (null !== $this->transExpireTime) {
            $res['transExpireTime'] = $this->transExpireTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApplyBatchPayRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['passBackParams'])) {
            $model->passBackParams = $map['passBackParams'];
        }
        if (isset($map['payTerminal'])) {
            $model->payTerminal = $map['payTerminal'];
        }
        if (isset($map['returnUrl'])) {
            $model->returnUrl = $map['returnUrl'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['transAmount'])) {
            $model->transAmount = $map['transAmount'];
        }
        if (isset($map['transExpireTime'])) {
            $model->transExpireTime = $map['transExpireTime'];
        }

        return $model;
    }
}
