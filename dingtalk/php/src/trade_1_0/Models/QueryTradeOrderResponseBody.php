<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTradeOrderResponseBody extends Model
{
    /**
     * @description 商品编码
     *
     * @var string
     */
    public $articleCode;

    /**
     * @description 规格编码
     *
     * @var string
     */
    public $articleItemCode;

    /**
     * @description 规格名称
     *
     * @var string
     */
    public $articleItemName;

    /**
     * @description 商品名称
     *
     * @var string
     */
    public $articleName;

    /**
     * @description 订单关闭时间（单位：ms）
     *
     * @var int
     */
    public $closeTime;

    /**
     * @description 订单创建时间（单位：ms）
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 原价（单位：分）
     *
     * @var int
     */
    public $fee;

    /**
     * @description ISV的组织ID
     *
     * @var string
     */
    public $isvCropId;

    /**
     * @description 内部订单号
     *
     * @var int
     */
    public $orderId;

    /**
     * @description 外部订单号
     *
     * @var string
     */
    public $outerOrderId;

    /**
     * @description 实际支付的价格（单位：分）
     *
     * @var int
     */
    public $payFee;

    /**
     * @description 订单支付时间（单位：ms）
     *
     * @var int
     */
    public $payTime;

    /**
     * @description 商品数量
     *
     * @var int
     */
    public $quantity;

    /**
     * @description 订单退款时间（单位：ms）
     *
     * @var int
     */
    public $refundTime;

    /**
     * @description 订单状态：-1表示已关闭、0表示未支付、1表示已支付、2表示已退款
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'articleCode'     => 'articleCode',
        'articleItemCode' => 'articleItemCode',
        'articleItemName' => 'articleItemName',
        'articleName'     => 'articleName',
        'closeTime'       => 'closeTime',
        'createTime'      => 'createTime',
        'fee'             => 'fee',
        'isvCropId'       => 'isvCropId',
        'orderId'         => 'orderId',
        'outerOrderId'    => 'outerOrderId',
        'payFee'          => 'payFee',
        'payTime'         => 'payTime',
        'quantity'        => 'quantity',
        'refundTime'      => 'refundTime',
        'status'          => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->articleCode) {
            $res['articleCode'] = $this->articleCode;
        }
        if (null !== $this->articleItemCode) {
            $res['articleItemCode'] = $this->articleItemCode;
        }
        if (null !== $this->articleItemName) {
            $res['articleItemName'] = $this->articleItemName;
        }
        if (null !== $this->articleName) {
            $res['articleName'] = $this->articleName;
        }
        if (null !== $this->closeTime) {
            $res['closeTime'] = $this->closeTime;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->fee) {
            $res['fee'] = $this->fee;
        }
        if (null !== $this->isvCropId) {
            $res['isvCropId'] = $this->isvCropId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->outerOrderId) {
            $res['outerOrderId'] = $this->outerOrderId;
        }
        if (null !== $this->payFee) {
            $res['payFee'] = $this->payFee;
        }
        if (null !== $this->payTime) {
            $res['payTime'] = $this->payTime;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->refundTime) {
            $res['refundTime'] = $this->refundTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTradeOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['articleCode'])) {
            $model->articleCode = $map['articleCode'];
        }
        if (isset($map['articleItemCode'])) {
            $model->articleItemCode = $map['articleItemCode'];
        }
        if (isset($map['articleItemName'])) {
            $model->articleItemName = $map['articleItemName'];
        }
        if (isset($map['articleName'])) {
            $model->articleName = $map['articleName'];
        }
        if (isset($map['closeTime'])) {
            $model->closeTime = $map['closeTime'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['fee'])) {
            $model->fee = $map['fee'];
        }
        if (isset($map['isvCropId'])) {
            $model->isvCropId = $map['isvCropId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['outerOrderId'])) {
            $model->outerOrderId = $map['outerOrderId'];
        }
        if (isset($map['payFee'])) {
            $model->payFee = $map['payFee'];
        }
        if (isset($map['payTime'])) {
            $model->payTime = $map['payTime'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['refundTime'])) {
            $model->refundTime = $map['refundTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
