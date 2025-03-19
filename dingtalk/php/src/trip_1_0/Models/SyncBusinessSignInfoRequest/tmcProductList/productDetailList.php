<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest\tmcProductList;

use AlibabaCloud\Tea\Model;

class productDetailList extends Model
{
    /**
     * @var string
     */
    public $categoryType;

    /**
     * @example 1661927020219
     *
     * @var string
     */
    public $gmtOrgPay;

    /**
     * @var bool
     */
    public $openStatus;

    /**
     * @var string
     */
    public $payType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $product;
    protected $_name = [
        'categoryType' => 'categoryType',
        'gmtOrgPay' => 'gmtOrgPay',
        'openStatus' => 'openStatus',
        'payType' => 'payType',
        'product' => 'product',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryType) {
            $res['categoryType'] = $this->categoryType;
        }
        if (null !== $this->gmtOrgPay) {
            $res['gmtOrgPay'] = $this->gmtOrgPay;
        }
        if (null !== $this->openStatus) {
            $res['openStatus'] = $this->openStatus;
        }
        if (null !== $this->payType) {
            $res['payType'] = $this->payType;
        }
        if (null !== $this->product) {
            $res['product'] = $this->product;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return productDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryType'])) {
            $model->categoryType = $map['categoryType'];
        }
        if (isset($map['gmtOrgPay'])) {
            $model->gmtOrgPay = $map['gmtOrgPay'];
        }
        if (isset($map['openStatus'])) {
            $model->openStatus = $map['openStatus'];
        }
        if (isset($map['payType'])) {
            $model->payType = $map['payType'];
        }
        if (isset($map['product'])) {
            $model->product = $map['product'];
        }

        return $model;
    }
}
