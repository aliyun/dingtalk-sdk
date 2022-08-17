<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelUserOrderRequest extends Model
{
    /**
     * @description 支付宝应用id。
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @description 商户id。
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 订单号。
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 签名。
     *
     * @var string
     */
    public $signature;

    /**
     * @description 时间戳。
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
