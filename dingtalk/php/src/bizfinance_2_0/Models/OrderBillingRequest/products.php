<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingRequest;

use AlibabaCloud\Tea\Model;

class products extends Model
{
    /**
     * @example 12.55
     *
     * @var string
     */
    public $amountWithTax;

    /**
     * @example 面包
     *
     * @var string
     */
    public $productName;

    /**
     * @example 5
     *
     * @var string
     */
    public $quantity;

    /**
     * @var string
     */
    public $revenueCode;

    /**
     * @var string
     */
    public $specification;

    /**
     * @example 个
     *
     * @var string
     */
    public $unit;

    /**
     * @example 19.99
     *
     * @var string
     */
    public $unitPrice;
    protected $_name = [
        'amountWithTax' => 'amountWithTax',
        'productName'   => 'productName',
        'quantity'      => 'quantity',
        'revenueCode'   => 'revenueCode',
        'specification' => 'specification',
        'unit'          => 'unit',
        'unitPrice'     => 'unitPrice',
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
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->revenueCode) {
            $res['revenueCode'] = $this->revenueCode;
        }
        if (null !== $this->specification) {
            $res['specification'] = $this->specification;
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
     * @return products
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amountWithTax'])) {
            $model->amountWithTax = $map['amountWithTax'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['revenueCode'])) {
            $model->revenueCode = $map['revenueCode'];
        }
        if (isset($map['specification'])) {
            $model->specification = $map['specification'];
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
