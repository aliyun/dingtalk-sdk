<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTradeOrderRequest extends Model
{
    /**
     * @description 外部订单号
     *
     * @var string
     */
    public $outerOrderId;

    /**
     * @description 内部订单号
     *
     * @var int
     */
    public $orderId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;
    protected $_name = [
        'outerOrderId' => 'outerOrderId',
        'orderId'      => 'orderId',
        'dingIsvOrgId' => 'dingIsvOrgId',
        'dingSuiteKey' => 'dingSuiteKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outerOrderId) {
            $res['outerOrderId'] = $this->outerOrderId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTradeOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outerOrderId'])) {
            $model->outerOrderId = $map['outerOrderId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }

        return $model;
    }
}
