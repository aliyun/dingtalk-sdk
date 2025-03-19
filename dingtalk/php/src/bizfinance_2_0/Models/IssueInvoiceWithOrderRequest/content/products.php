<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest\content;

use AlibabaCloud\Tea\Model;

class products extends Model
{
    /**
     * @var string
     */
    public $amountIncludeTax;

    /**
     * @var string
     */
    public $productName;

    /**
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
    public $specs;

    /**
     * @var string
     */
    public $taxSign;

    /**
     * @var string
     */
    public $unit;
    protected $_name = [
        'amountIncludeTax' => 'amountIncludeTax',
        'productName' => 'productName',
        'quantity' => 'quantity',
        'revenueCode' => 'revenueCode',
        'specs' => 'specs',
        'taxSign' => 'taxSign',
        'unit' => 'unit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amountIncludeTax) {
            $res['amountIncludeTax'] = $this->amountIncludeTax;
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
        if (null !== $this->specs) {
            $res['specs'] = $this->specs;
        }
        if (null !== $this->taxSign) {
            $res['taxSign'] = $this->taxSign;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
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
        if (isset($map['amountIncludeTax'])) {
            $model->amountIncludeTax = $map['amountIncludeTax'];
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
        if (isset($map['specs'])) {
            $model->specs = $map['specs'];
        }
        if (isset($map['taxSign'])) {
            $model->taxSign = $map['taxSign'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
