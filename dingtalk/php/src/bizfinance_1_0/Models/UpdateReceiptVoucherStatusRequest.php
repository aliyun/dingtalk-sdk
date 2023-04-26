<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateReceiptVoucherStatusRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountPeriod;

    /**
     * @example add
     *
     * @var string
     */
    public $actionType;

    /**
     * @example 0021241
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example abc
     *
     * @var string
     */
    public $receiptId;

    /**
     * @example abc
     *
     * @var string
     */
    public $voucherCode;

    /**
     * @example abc
     *
     * @var string
     */
    public $voucherId;
    protected $_name = [
        'accountPeriod' => 'accountPeriod',
        'actionType'    => 'actionType',
        'operatorId'    => 'operatorId',
        'receiptId'     => 'receiptId',
        'voucherCode'   => 'voucherCode',
        'voucherId'     => 'voucherId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountPeriod) {
            $res['accountPeriod'] = $this->accountPeriod;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->receiptId) {
            $res['receiptId'] = $this->receiptId;
        }
        if (null !== $this->voucherCode) {
            $res['voucherCode'] = $this->voucherCode;
        }
        if (null !== $this->voucherId) {
            $res['voucherId'] = $this->voucherId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateReceiptVoucherStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountPeriod'])) {
            $model->accountPeriod = $map['accountPeriod'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['receiptId'])) {
            $model->receiptId = $map['receiptId'];
        }
        if (isset($map['voucherCode'])) {
            $model->voucherCode = $map['voucherCode'];
        }
        if (isset($map['voucherId'])) {
            $model->voucherId = $map['voucherId'];
        }

        return $model;
    }
}
