<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMarketOrderResponseBody extends Model
{
    /**
     * @example 2092310001312
     *
     * @var int
     */
    public $bizOrderId;

    /**
     * @example ding23219001
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 10003298001
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @var int
     */
    public $endTimestamp;

    /**
     * @example FW_GOODS_12319001
     *
     * @var string
     */
    public $goodsCode;

    /**
     * @example 测试商品001
     *
     * @var string
     */
    public $goodsName;

    /**
     * @var bool
     */
    public $inAppOrder;

    /**
     * @example FW_GOODS_31001
     *
     * @var string
     */
    public $itemCode;

    /**
     * @example 测试规格001
     *
     * @var string
     */
    public $itemName;

    /**
     * @example 10003299001
     *
     * @var int
     */
    public $paidTimestamp;

    /**
     * @example 1
     *
     * @var int
     */
    public $quantity;

    /**
     * @example 10003298003
     *
     * @var int
     */
    public $startTimestamp;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 100
     *
     * @var int
     */
    public $totalActualPayFee;
    protected $_name = [
        'bizOrderId'        => 'bizOrderId',
        'corpId'            => 'corpId',
        'createTimestamp'   => 'createTimestamp',
        'endTimestamp'      => 'endTimestamp',
        'goodsCode'         => 'goodsCode',
        'goodsName'         => 'goodsName',
        'inAppOrder'        => 'inAppOrder',
        'itemCode'          => 'itemCode',
        'itemName'          => 'itemName',
        'paidTimestamp'     => 'paidTimestamp',
        'quantity'          => 'quantity',
        'startTimestamp'    => 'startTimestamp',
        'status'            => 'status',
        'totalActualPayFee' => 'totalActualPayFee',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizOrderId) {
            $res['bizOrderId'] = $this->bizOrderId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTimestamp) {
            $res['createTimestamp'] = $this->createTimestamp;
        }
        if (null !== $this->endTimestamp) {
            $res['endTimestamp'] = $this->endTimestamp;
        }
        if (null !== $this->goodsCode) {
            $res['goodsCode'] = $this->goodsCode;
        }
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->inAppOrder) {
            $res['inAppOrder'] = $this->inAppOrder;
        }
        if (null !== $this->itemCode) {
            $res['itemCode'] = $this->itemCode;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->paidTimestamp) {
            $res['paidTimestamp'] = $this->paidTimestamp;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->startTimestamp) {
            $res['startTimestamp'] = $this->startTimestamp;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->totalActualPayFee) {
            $res['totalActualPayFee'] = $this->totalActualPayFee;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMarketOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizOrderId'])) {
            $model->bizOrderId = $map['bizOrderId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTimestamp'])) {
            $model->createTimestamp = $map['createTimestamp'];
        }
        if (isset($map['endTimestamp'])) {
            $model->endTimestamp = $map['endTimestamp'];
        }
        if (isset($map['goodsCode'])) {
            $model->goodsCode = $map['goodsCode'];
        }
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['inAppOrder'])) {
            $model->inAppOrder = $map['inAppOrder'];
        }
        if (isset($map['itemCode'])) {
            $model->itemCode = $map['itemCode'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['paidTimestamp'])) {
            $model->paidTimestamp = $map['paidTimestamp'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['startTimestamp'])) {
            $model->startTimestamp = $map['startTimestamp'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['totalActualPayFee'])) {
            $model->totalActualPayFee = $map['totalActualPayFee'];
        }

        return $model;
    }
}
