<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelUserOrderResponseBody extends Model
{
    /**
     * @example 123400
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @example 10000
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example M000001
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @example CM0001234
     *
     * @var string
     */
    public $orderNo;

    /**
     * @var int
     */
    public $payStatus;

    /**
     * @var int
     */
    public $refundStatus;

    /**
     * @var int
     */
    public $totalAmount;
    protected $_name = [
        'alipayAppId'     => 'alipayAppId',
        'merchantId'      => 'merchantId',
        'merchantOrderNo' => 'merchantOrderNo',
        'orderNo'         => 'orderNo',
        'payStatus'       => 'payStatus',
        'refundStatus'    => 'refundStatus',
        'totalAmount'     => 'totalAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayAppId) {
            $res['alipayAppId'] = $this->alipayAppId;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->merchantOrderNo) {
            $res['merchantOrderNo'] = $this->merchantOrderNo;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->payStatus) {
            $res['payStatus'] = $this->payStatus;
        }
        if (null !== $this->refundStatus) {
            $res['refundStatus'] = $this->refundStatus;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelUserOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayAppId'])) {
            $model->alipayAppId = $map['alipayAppId'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['merchantOrderNo'])) {
            $model->merchantOrderNo = $map['merchantOrderNo'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['payStatus'])) {
            $model->payStatus = $map['payStatus'];
        }
        if (isset($map['refundStatus'])) {
            $model->refundStatus = $map['refundStatus'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }

        return $model;
    }
}
