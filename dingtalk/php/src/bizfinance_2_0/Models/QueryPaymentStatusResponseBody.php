<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponseBody\payeeAccountInfo;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponseBody\payerAccountInfo;
use AlibabaCloud\Tea\Model;

class QueryPaymentStatusResponseBody extends Model
{
    /**
     * @example dingXXX
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 收款账户错误
     *
     * @var string
     */
    public $failReason;

    /**
     * @example ABC
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example 20241112
     *
     * @var string
     */
    public $orderNo;

    /**
     * @var payeeAccountInfo
     */
    public $payeeAccountInfo;

    /**
     * @var payerAccountInfo
     */
    public $payerAccountInfo;

    /**
     * @example SUCCESS
     *
     * @var string
     */
    public $paymentStatus;

    /**
     * @example 2024-11-11 00:00:00
     *
     * @var string
     */
    public $paymentTime;

    /**
     * @example ABC
     *
     * @var string
     */
    public $remark;

    /**
     * @example 报销
     *
     * @var string
     */
    public $usage;

    /**
     * @example 504
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'           => 'corpId',
        'failReason'       => 'failReason',
        'instanceId'       => 'instanceId',
        'orderNo'          => 'orderNo',
        'payeeAccountInfo' => 'payeeAccountInfo',
        'payerAccountInfo' => 'payerAccountInfo',
        'paymentStatus'    => 'paymentStatus',
        'paymentTime'      => 'paymentTime',
        'remark'           => 'remark',
        'usage'            => 'usage',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->payeeAccountInfo) {
            $res['payeeAccountInfo'] = null !== $this->payeeAccountInfo ? $this->payeeAccountInfo->toMap() : null;
        }
        if (null !== $this->payerAccountInfo) {
            $res['payerAccountInfo'] = null !== $this->payerAccountInfo ? $this->payerAccountInfo->toMap() : null;
        }
        if (null !== $this->paymentStatus) {
            $res['paymentStatus'] = $this->paymentStatus;
        }
        if (null !== $this->paymentTime) {
            $res['paymentTime'] = $this->paymentTime;
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
     * @return QueryPaymentStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['payeeAccountInfo'])) {
            $model->payeeAccountInfo = payeeAccountInfo::fromMap($map['payeeAccountInfo']);
        }
        if (isset($map['payerAccountInfo'])) {
            $model->payerAccountInfo = payerAccountInfo::fromMap($map['payerAccountInfo']);
        }
        if (isset($map['paymentStatus'])) {
            $model->paymentStatus = $map['paymentStatus'];
        }
        if (isset($map['paymentTime'])) {
            $model->paymentTime = $map['paymentTime'];
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
