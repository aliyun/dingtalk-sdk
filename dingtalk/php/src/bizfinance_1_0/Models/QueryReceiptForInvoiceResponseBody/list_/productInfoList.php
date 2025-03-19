<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponseBody\list_;

use AlibabaCloud\Tea\Model;

class productInfoList extends Model
{
    /**
     * @example 12.3
     *
     * @var string
     */
    public $amountWithTax;

    /**
     * @example 100
     *
     * @var string
     */
    public $amountWithoutTax;

    /**
     * @example 10
     *
     * @var string
     */
    public $discountAmount;

    /**
     * @example 鱼
     *
     * @var string
     */
    public $name;

    /**
     * @example 2
     *
     * @var string
     */
    public $quantity;

    /**
     * @example 大型
     *
     * @var string
     */
    public $specification;

    /**
     * @example XXX
     *
     * @var string
     */
    public $taxClassificationCode;

    /**
     * @example 0.3
     *
     * @var string
     */
    public $taxRate;

    /**
     * @example 千克
     *
     * @var string
     */
    public $unit;

    /**
     * @example 12.3
     *
     * @var string
     */
    public $unitPriceWithTax;

    /**
     * @example 100
     *
     * @var string
     */
    public $unitPriceWithoutTax;

    /**
     * @var bool
     */
    public $withTax;
    protected $_name = [
        'amountWithTax' => 'amountWithTax',
        'amountWithoutTax' => 'amountWithoutTax',
        'discountAmount' => 'discountAmount',
        'name' => 'name',
        'quantity' => 'quantity',
        'specification' => 'specification',
        'taxClassificationCode' => 'taxClassificationCode',
        'taxRate' => 'taxRate',
        'unit' => 'unit',
        'unitPriceWithTax' => 'unitPriceWithTax',
        'unitPriceWithoutTax' => 'unitPriceWithoutTax',
        'withTax' => 'withTax',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amountWithTax) {
            $res['amountWithTax'] = $this->amountWithTax;
        }
        if (null !== $this->amountWithoutTax) {
            $res['amountWithoutTax'] = $this->amountWithoutTax;
        }
        if (null !== $this->discountAmount) {
            $res['discountAmount'] = $this->discountAmount;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
        }
        if (null !== $this->taxClassificationCode) {
            $res['taxClassificationCode'] = $this->taxClassificationCode;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->unitPriceWithTax) {
            $res['unitPriceWithTax'] = $this->unitPriceWithTax;
        }
        if (null !== $this->unitPriceWithoutTax) {
            $res['unitPriceWithoutTax'] = $this->unitPriceWithoutTax;
        }
        if (null !== $this->withTax) {
            $res['withTax'] = $this->withTax;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return productInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amountWithTax'])) {
            $model->amountWithTax = $map['amountWithTax'];
        }
        if (isset($map['amountWithoutTax'])) {
            $model->amountWithoutTax = $map['amountWithoutTax'];
        }
        if (isset($map['discountAmount'])) {
            $model->discountAmount = $map['discountAmount'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
        }
        if (isset($map['taxClassificationCode'])) {
            $model->taxClassificationCode = $map['taxClassificationCode'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['unitPriceWithTax'])) {
            $model->unitPriceWithTax = $map['unitPriceWithTax'];
        }
        if (isset($map['unitPriceWithoutTax'])) {
            $model->unitPriceWithoutTax = $map['unitPriceWithoutTax'];
        }
        if (isset($map['withTax'])) {
            $model->withTax = $map['withTax'];
        }

        return $model;
    }
}
