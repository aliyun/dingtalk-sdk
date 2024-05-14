<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelUserOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123400
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @description This parameter is required.
     *
     * @example 10000
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description This parameter is required.
     *
     * @example CM000001
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description This parameter is required.
     *
     * @example WWrhziOLF/XuRd3IyKwLkLeSFgKnUfeg2yLEVD9Bw+8
     *
     * @var string
     */
    public $signature;

    /**
     * @description This parameter is required.
     *
     * @example 100000
     *
     * @var int
     */
    public $timestamp;
    protected $_name = [
        'alipayAppId' => 'alipayAppId',
        'merchantId'  => 'merchantId',
        'orderNo'     => 'orderNo',
        'signature'   => 'signature',
        'timestamp'   => 'timestamp',
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
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelUserOrderRequest
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
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }

        return $model;
    }
}
