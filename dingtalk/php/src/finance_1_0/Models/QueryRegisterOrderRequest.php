<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRegisterOrderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 202111090001
     *
     * @var string
     */
    public $instId;

    /**
     * @example 20211222000000001
     *
     * @var string
     */
    public $orderId;

    /**
     * @example 202112220001
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var string
     */
    public $subInstId;
    protected $_name = [
        'instId' => 'instId',
        'orderId' => 'orderId',
        'outTradeNo' => 'outTradeNo',
        'subInstId' => 'subInstId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRegisterOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }

        return $model;
    }
}
