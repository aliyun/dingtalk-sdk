<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMarketOrderResponseBody extends Model
{
    /**
     * @description 订单ID
     *
     * @var int
     */
    public $bizOrderId;

    /**
     * @description 组织ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 创建时间戳
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @description 生效结束时间
     *
     * @var int
     */
    public $endTimestamp;

    /**
     * @description 商品Code
     *
     * @var string
     */
    public $goodsCode;

    /**
     * @description 商品名称
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 是否内购订单
     *
     * @var bool
     */
    public $inAppOrder;

    /**
     * @description 规格编码
     *
     * @var string
     */
    public $itemCode;

    /**
     * @description 规格名称
     *
     * @var string
     */
    public $itemName;

    /**
     * @description 支付时间戳
     *
     * @var int
     */
    public $paidTimestamp;

    /**
     * @description 购买数量
     *
     * @var int
     */
    public $quantity;

    /**
     * @description 开始生效时间
     *
     * @var int
     */
    public $startTimestamp;

    /**
     * @description 订单状态(0:订单关闭； 3：订单支付；4：订单创建)
     *
     * @var int
     */
    public $status;

    /**
     * @description 订单实付金额(单位分)
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
