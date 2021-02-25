<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrderResaleRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $serviceStartTime;

    /**
     * @var int
     */
    public $serviceStopTime;

    /**
     * @var int
     */
    public $orderCreateTime;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var int
     */
    public $quantity;

    /**
     * @var string
     */
    public $dingIsvAccessToken;

    /**
     * @var string
     */
    public $dingSuiteKey;
    protected $_name = [
        'dingCorpId'         => 'dingCorpId',
        'serviceStartTime'   => 'serviceStartTime',
        'serviceStopTime'    => 'serviceStopTime',
        'orderCreateTime'    => 'orderCreateTime',
        'orderId'            => 'orderId',
        'quantity'           => 'quantity',
        'dingIsvAccessToken' => 'dingIsvAccessToken',
        'dingSuiteKey'       => 'dingSuiteKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->serviceStartTime) {
            $res['serviceStartTime'] = $this->serviceStartTime;
        }
        if (null !== $this->serviceStopTime) {
            $res['serviceStopTime'] = $this->serviceStopTime;
        }
        if (null !== $this->orderCreateTime) {
            $res['orderCreateTime'] = $this->orderCreateTime;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->dingIsvAccessToken) {
            $res['dingIsvAccessToken'] = $this->dingIsvAccessToken;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrderResaleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['serviceStartTime'])) {
            $model->serviceStartTime = $map['serviceStartTime'];
        }
        if (isset($map['serviceStopTime'])) {
            $model->serviceStopTime = $map['serviceStopTime'];
        }
        if (isset($map['orderCreateTime'])) {
            $model->orderCreateTime = $map['orderCreateTime'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['dingIsvAccessToken'])) {
            $model->dingIsvAccessToken = $map['dingIsvAccessToken'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }

        return $model;
    }
}
