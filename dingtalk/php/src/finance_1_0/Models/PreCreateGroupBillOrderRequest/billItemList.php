<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderRequest;

use AlibabaCloud\Tea\Model;

class billItemList extends Model
{
    /**
     * @example 5.12
     *
     * @var string
     */
    public $amount;

    /**
     * @example cshadbikahdksnajhada
     *
     * @var string
     */
    public $payerUnionId;
    protected $_name = [
        'amount'       => 'amount',
        'payerUnionId' => 'payerUnionId',
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
        if (null !== $this->payerUnionId) {
            $res['payerUnionId'] = $this->payerUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return billItemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['payerUnionId'])) {
            $model->payerUnionId = $map['payerUnionId'];
        }

        return $model;
    }
}
