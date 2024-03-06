<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInstanceOrderInfoShrinkRequest extends Model
{
    /**
     * @example xxx错误
     *
     * @var string
     */
    public $failReason;

    /**
     * @example abc
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example 123
     *
     * @var string
     */
    public $outOrderNo;

    /**
     * @var string
     */
    public $payerBankShrink;

    /**
     * @example 1709691000682
     *
     * @var int
     */
    public $paymentTime;

    /**
     * @example PAYING
     *
     * @var string
     */
    public $status;

    /**
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'failReason'      => 'failReason',
        'orderNo'         => 'orderNo',
        'outOrderNo'      => 'outOrderNo',
        'payerBankShrink' => 'payerBank',
        'paymentTime'     => 'paymentTime',
        'status'          => 'status',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->outOrderNo) {
            $res['outOrderNo'] = $this->outOrderNo;
        }
        if (null !== $this->payerBankShrink) {
            $res['payerBank'] = $this->payerBankShrink;
        }
        if (null !== $this->paymentTime) {
            $res['paymentTime'] = $this->paymentTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInstanceOrderInfoShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['outOrderNo'])) {
            $model->outOrderNo = $map['outOrderNo'];
        }
        if (isset($map['payerBank'])) {
            $model->payerBankShrink = $map['payerBank'];
        }
        if (isset($map['paymentTime'])) {
            $model->paymentTime = $map['paymentTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
