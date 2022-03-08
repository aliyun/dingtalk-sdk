<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateBatchTradeOrderRequest;

use AlibabaCloud\Tea\Model;

class batchTradeDetails extends Model
{
    /**
     * @description 金额（必填，单位：元）
     *
     * @var string
     */
    public $amount;

    /**
     * @description 备注（选填）
     *
     * @var string
     */
    public $memo;

    /**
     * @description 收款方户名（必填）
     *
     * @var string
     */
    public $payeeAccountName;

    /**
     * @description 收款方账号（必填）
     *
     * @var string
     */
    public $payeeAccountNo;

    /**
     * @description 收款方账号类型（必填）
     *
     * @var string
     */
    public $payeeAccountType;

    /**
     * @description 序号（必填）
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
