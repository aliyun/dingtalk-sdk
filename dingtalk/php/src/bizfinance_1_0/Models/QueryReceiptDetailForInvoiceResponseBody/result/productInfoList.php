<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result;

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
    protected $_name = [
        'amountWithTax'    => 'amountWithTax',
        'name'             => 'name',
        'quantity'         => 'quantity',
        'specification'    => 'specification',
        'taxRate'          => 'taxRate',
        'unit'             => 'unit',
        'unitPriceWithTax' => 'unitPriceWithTax',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amountWithTax) {
            $res['amountWithTax'] = $this->amountWithTax;
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
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->unitPriceWithTax) {
            $res['unitPriceWithTax'] = $this->unitPriceWithTax;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
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

        return $model;
    }
}
