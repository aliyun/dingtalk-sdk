<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePaymentOrderRequest\payeeAccountDTO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePaymentOrderRequest\payerAccountDTO;
use AlibabaCloud\Tea\Model;

class CreatePaymentOrderRequest extends Model
{
    /**
     * @example 100
     *
     * @var string
     */
    public $amount;

    /**
     * @example 1741941518884
     *
     * @var int
     */
    public $expireTime;

    /**
     * @example xxxxabc
     *
     * @var string
     */
    public $outBizNo;

    /**
     * @var payeeAccountDTO
     */
    public $payeeAccountDTO;

    /**
     * @var payerAccountDTO
     */
    public $payerAccountDTO;

    /**
     * @example 日常报销
     *
     * @var string
     */
    public $paymentOrderTitle;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example 付款用途
     *
     * @var string
     */
    public $usage;

    /**
     * @example 5046195764756652
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'amount' => 'amount',
        'expireTime' => 'expireTime',
        'outBizNo' => 'outBizNo',
        'payeeAccountDTO' => 'payeeAccountDTO',
        'payerAccountDTO' => 'payerAccountDTO',
        'paymentOrderTitle' => 'paymentOrderTitle',
        'remark' => 'remark',
        'usage' => 'usage',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->outBizNo) {
            $res['outBizNo'] = $this->outBizNo;
        }
        if (null !== $this->payeeAccountDTO) {
            $res['payeeAccountDTO'] = null !== $this->payeeAccountDTO ? $this->payeeAccountDTO->toMap() : null;
        }
        if (null !== $this->payerAccountDTO) {
            $res['payerAccountDTO'] = null !== $this->payerAccountDTO ? $this->payerAccountDTO->toMap() : null;
        }
        if (null !== $this->paymentOrderTitle) {
            $res['paymentOrderTitle'] = $this->paymentOrderTitle;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->usage) {
            $res['usage'] = $this->usage;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePaymentOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['outBizNo'])) {
            $model->outBizNo = $map['outBizNo'];
        }
        if (isset($map['payeeAccountDTO'])) {
            $model->payeeAccountDTO = payeeAccountDTO::fromMap($map['payeeAccountDTO']);
        }
        if (isset($map['payerAccountDTO'])) {
            $model->payerAccountDTO = payerAccountDTO::fromMap($map['payerAccountDTO']);
        }
        if (isset($map['paymentOrderTitle'])) {
            $model->paymentOrderTitle = $map['paymentOrderTitle'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['usage'])) {
            $model->usage = $map['usage'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
