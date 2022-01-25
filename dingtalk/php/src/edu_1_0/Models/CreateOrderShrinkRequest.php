<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrderShrinkRequest extends Model
{
    /**
     * @description 设备序列号
     *
     * @var string
     */
    public $sn;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 录脸token
     *
     * @var string
     */
    public $ftoken;

    /**
     * @description 交易加签
     *
     * @var string
     */
    public $terminalParams;

    /**
     * @description 应付价格
     *
     * @var int
     */
    public $totalAmount;

    /**
     * @description 实付金额（优惠计算后）
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description 订单明细信息，来源于商户系统或APP的商品信息。
     *
     * @var string
     */
    public $detailListShrink;
    protected $_name = [
        'sn'               => 'sn',
        'userId'           => 'userId',
        'ftoken'           => 'ftoken',
        'terminalParams'   => 'terminalParams',
        'totalAmount'      => 'totalAmount',
        'actualAmount'     => 'actualAmount',
        'detailListShrink' => 'detailList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->ftoken) {
            $res['ftoken'] = $this->ftoken;
        }
        if (null !== $this->terminalParams) {
            $res['terminalParams'] = $this->terminalParams;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->detailListShrink) {
            $res['detailList'] = $this->detailListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrderShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['ftoken'])) {
            $model->ftoken = $map['ftoken'];
        }
        if (isset($map['terminalParams'])) {
            $model->terminalParams = $map['terminalParams'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['detailList'])) {
            $model->detailListShrink = $map['detailList'];
        }

        return $model;
    }
}
