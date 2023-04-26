<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest;

use AlibabaCloud\Tea\Model;

class batchTradeDetails extends Model
{
    /**
     * @example 1.00
     *
     * @var string
     */
    public $amount;

    /**
     * @example 工资
     *
     * @var string
     */
    public $memo;

    /**
     * @example 测试
     *
     * @var string
     */
    public $payeeAccountName;

    /**
     * @example 13000000000
     *
     * @var string
     */
    public $payeeAccountNo;

    /**
     * @example ALIPAY
     *
     * @var string
     */
    public $payeeAccountType;

    /**
     * @example 1
     *
     * @var int
     */
    public $serialNo;
    protected $_name = [
        'amount'           => 'amount',
        'memo'             => 'memo',
        'payeeAccountName' => 'payeeAccountName',
        'payeeAccountNo'   => 'payeeAccountNo',
        'payeeAccountType' => 'payeeAccountType',
        'serialNo'         => 'serialNo',
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
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->payeeAccountName) {
            $res['payeeAccountName'] = $this->payeeAccountName;
        }
        if (null !== $this->payeeAccountNo) {
            $res['payeeAccountNo'] = $this->payeeAccountNo;
        }
        if (null !== $this->payeeAccountType) {
            $res['payeeAccountType'] = $this->payeeAccountType;
        }
        if (null !== $this->serialNo) {
            $res['serialNo'] = $this->serialNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return batchTradeDetails
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['payeeAccountName'])) {
            $model->payeeAccountName = $map['payeeAccountName'];
        }
        if (isset($map['payeeAccountNo'])) {
            $model->payeeAccountNo = $map['payeeAccountNo'];
        }
        if (isset($map['payeeAccountType'])) {
            $model->payeeAccountType = $map['payeeAccountType'];
        }
        if (isset($map['serialNo'])) {
            $model->serialNo = $map['serialNo'];
        }

        return $model;
    }
}
