<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAppOrderResponseBody extends Model
{
    /**
     * @description 实际金额，单位分。
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description 支付宝应用id。
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @description 订单信息。
     *
     * @var string
     */
    public $body;

    /**
     * @description 商户id。
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 商户订单号。
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @description 订单号。
     *
     * @var string
     */
    public $orderNo;
    protected $_name = [
        'actualAmount'    => 'actualAmount',
        'alipayAppId'     => 'alipayAppId',
        'body'            => 'body',
        'merchantId'      => 'merchantId',
        'merchantOrderNo' => 'merchantOrderNo',
        'orderNo'         => 'orderNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->alipayAppId) {
            $res['alipayAppId'] = $this->alipayAppId;
        }
        if (null !== $this->body) {
            $res['body'] = $this->body;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAppOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['alipayAppId'])) {
            $model->alipayAppId = $map['alipayAppId'];
        }
        if (isset($map['body'])) {
            $model->body = $map['body'];
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

        return $model;
    }
}
