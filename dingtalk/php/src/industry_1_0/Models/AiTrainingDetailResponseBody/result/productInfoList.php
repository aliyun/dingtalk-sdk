<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class productInfoList extends Model
{
    /**
     * @var string
     */
    public $attribute;

    /**
     * @var string
     */
    public $brand;

    /**
     * @var string
     */
    public $category;

    /**
     * @var string
     */
    public $currency;

    /**
     * @var string[]
     */
    public $imageUrls;

    /**
     * @var int
     */
    public $price;

    /**
     * @var string
     */
    public $productCode;

    /**
     * @var string
     */
    public $productFab;

    /**
     * @var int
     */
    public $productId;

    /**
     * @var string
     */
    public $productInfo;

    /**
     * @var string
     */
    public $productName;

    /**
     * @var string
     */
    public $relatedType;
    protected $_name = [
        'attribute' => 'attribute',
        'brand' => 'brand',
        'category' => 'category',
        'currency' => 'currency',
        'imageUrls' => 'imageUrls',
        'price' => 'price',
        'productCode' => 'productCode',
        'productFab' => 'productFab',
        'productId' => 'productId',
        'productInfo' => 'productInfo',
        'productName' => 'productName',
        'relatedType' => 'relatedType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attribute) {
            $res['attribute'] = $this->attribute;
        }
        if (null !== $this->brand) {
            $res['brand'] = $this->brand;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->currency) {
            $res['currency'] = $this->currency;
        }
        if (null !== $this->imageUrls) {
            $res['imageUrls'] = $this->imageUrls;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productFab) {
            $res['productFab'] = $this->productFab;
        }
        if (null !== $this->productId) {
            $res['productId'] = $this->productId;
        }
        if (null !== $this->productInfo) {
            $res['productInfo'] = $this->productInfo;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->relatedType) {
            $res['relatedType'] = $this->relatedType;
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
        if (isset($map['attribute'])) {
            $model->attribute = $map['attribute'];
        }
        if (isset($map['brand'])) {
            $model->brand = $map['brand'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['currency'])) {
            $model->currency = $map['currency'];
        }
        if (isset($map['imageUrls'])) {
            if (!empty($map['imageUrls'])) {
                $model->imageUrls = $map['imageUrls'];
            }
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productFab'])) {
            $model->productFab = $map['productFab'];
        }
        if (isset($map['productId'])) {
            $model->productId = $map['productId'];
        }
        if (isset($map['productInfo'])) {
            $model->productInfo = $map['productInfo'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['relatedType'])) {
            $model->relatedType = $map['relatedType'];
        }

        return $model;
    }
}
