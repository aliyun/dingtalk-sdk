<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSnsAppOrderResponseBody extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @example 1234
     *
     * @var string
     */
    public $alipayAppId;

    /**
     * @example alipay_sdk=alipay-sdk-java-dynamicVersionNo&version=1.0
     *
     * @var string
     */
    public $body;

    /**
     * @example 10000
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example M00001
     *
     * @var string
     */
    public $merchantOrderNo;

    /**
     * @example CM0001
     *
     * @var string
     */
    public $orderNo;
    protected $_name = [
        'actualAmount' => 'actualAmount',
        'alipayAppId' => 'alipayAppId',
        'body' => 'body',
        'merchantId' => 'merchantId',
        'merchantOrderNo' => 'merchantOrderNo',
        'orderNo' => 'orderNo',
    ];

    public function validate() {}

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
     * @return CreateSnsAppOrderResponseBody
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
