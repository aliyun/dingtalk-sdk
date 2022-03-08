<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRegisterOrderRequest extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 申请单号，和外部流水号至少一个必填
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 外部流水号，和申请单编号至少一个必填
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;
    protected $_name = [
        'instId'     => 'instId',
        'orderId'    => 'orderId',
        'outTradeNo' => 'outTradeNo',
        'subInstId'  => 'subInstId',
    ];

    public function validate()
    {
    }

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
