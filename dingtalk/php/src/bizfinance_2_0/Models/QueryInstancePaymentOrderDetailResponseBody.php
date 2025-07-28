<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponseBody\payeeAccountDTO;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponseBody\payerAccountDTO;
use AlibabaCloud\Tea\Model;

class QueryInstancePaymentOrderDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $amount;

    /**
     * @var string
     */
    public $instanceId;

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
    public $usage;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'amount' => 'amount',
        'instanceId' => 'instanceId',
        'payeeAccountDTO' => 'payeeAccountDTO',
        'payerAccountDTO' => 'payerAccountDTO',
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
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
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
     * @return QueryInstancePaymentOrderDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
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
        if (isset($map['usage'])) {
            $model->usage = $map['usage'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
