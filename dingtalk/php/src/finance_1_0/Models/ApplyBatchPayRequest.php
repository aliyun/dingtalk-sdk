<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyBatchPayRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2021070712440326300185114
     *
     * @var string
     */
    public $accountId;

    /**
     * @description This parameter is required.
     *
     * @example 20210909153300000002734753314700
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example map
     *
     * @var mixed[]
     */
    public $passBackParams;

    /**
     * @description This parameter is required.
     *
     * @example PC
     *
     * @var string
     */
    public $payTerminal;

    /**
     * @example http://xx
     *
     * @var string
     */
    public $returnUrl;

    /**
     * @description This parameter is required.
     *
     * @example 8754214873
     *
     * @var string
     */
    public $staffId;

    /**
     * @description This parameter is required.
     *
     * @example 10.00
     *
     * @var string
     */
    public $transAmount;

    /**
     * @example yyyy-MM-dd HH:mm:ss
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
