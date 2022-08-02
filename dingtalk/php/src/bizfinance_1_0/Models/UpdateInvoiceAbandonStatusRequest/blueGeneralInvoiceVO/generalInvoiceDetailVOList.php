<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\blueGeneralInvoiceVO;

use AlibabaCloud\Tea\Model;

class generalInvoiceDetailVOList extends Model
{
    /**
     * @description 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 商品名称
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 数量
     *
     * @var string
     */
    public $quantity;

    /**
     * @description 税收分类编码
     *
     * @var string
     */
    public $revenueCode;

    /**
     * @description 行号
     *
     * @var string
     */
    public $rowNo;

    /**
     * @description 规格型号
     *
     * @var string
     */
    public $specification;

    /**
     * @description 税额
     *
     * @var string
     */
    public $taxAmount;

    /**
     * @description 是否享受税收优惠：0-不享受，1-享受
     *
     * @var string
     */
    public $taxPre;

    /**
     * @description 优惠政策类型
     *
     * @var string
     */
    public $taxPreType;

    /**
     * @description 税率
     *
     * @var string
     */
    public $taxRate;

    /**
     * @description 单位
     *
     * @var string
     */
    public $unit;

    /**
     * @description 单价
     *
     * @var string
     */
    public $unitPrice;
    protected $_name = [
        'amount'        => 'amount',
        'goodsName'     => 'goodsName',
        'quantity'      => 'quantity',
        'revenueCode'   => 'revenueCode',
        'rowNo'         => 'rowNo',
        'specification' => 'specification',
        'taxAmount'     => 'taxAmount',
        'taxPre'        => 'taxPre',
        'taxPreType'    => 'taxPreType',
        'taxRate'       => 'taxRate',
        'unit'          => 'unit',
        'unitPrice'     => 'unitPrice',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->revenueCode) {
            $res['revenueCode'] = $this->revenueCode;
        }
        if (null !== $this->rowNo) {
            $res['rowNo'] = $this->rowNo;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
        }
        if (null !== $this->taxPre) {
            $res['taxPre'] = $this->taxPre;
        }
        if (null !== $this->taxPreType) {
            $res['taxPreType'] = $this->taxPreType;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return generalInvoiceDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['revenueCode'])) {
            $model->revenueCode = $map['revenueCode'];
        }
        if (isset($map['rowNo'])) {
            $model->rowNo = $map['rowNo'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
        }
        if (isset($map['taxPre'])) {
            $model->taxPre = $map['taxPre'];
        }
        if (isset($map['taxPreType'])) {
            $model->taxPreType = $map['taxPreType'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }

        return $model;
    }
}
