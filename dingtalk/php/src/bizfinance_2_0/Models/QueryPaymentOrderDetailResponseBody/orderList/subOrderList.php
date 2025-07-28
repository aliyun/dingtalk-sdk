<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList\subOrderList\payeeAccountDTO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList\subOrderList\payerAccountDTO;
use AlibabaCloud\Tea\Model;

class subOrderList extends Model
{
    /**
     * @var string
     */
    public $amount;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $orderNo;

    /**
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
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $usage;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'amount' => 'amount',
        'corpId' => 'corpId',
        'orderNo' => 'orderNo',
        'outBizNo' => 'outBizNo',
        'payeeAccountDTO' => 'payeeAccountDTO',
        'payerAccountDTO' => 'payerAccountDTO',
        'remark' => 'remark',
        'status' => 'status',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
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
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
     * @return subOrderList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
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
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
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
