<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiRetailProductQueryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $attribute;

    /**
     * @var string
     */
    public $barcodes;

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
     * @var int
     */
    public $enable;

    /**
     * @var string
     */
    public $imageFileIds;

    /**
     * @var string
     */
    public $itemNumbers;

    /**
     * @var float
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
     * @example 热销
     *
     * @var string
     */
    public $tag1;

    /**
     * @example 新品
     *
     * @var string
     */
    public $tag2;

    /**
     * @example 尾款
     *
     * @var string
     */
    public $tag3;
    protected $_name = [
        'attribute' => 'attribute',
        'barcodes' => 'barcodes',
        'brand' => 'brand',
        'category' => 'category',
        'currency' => 'currency',
        'enable' => 'enable',
        'imageFileIds' => 'imageFileIds',
        'itemNumbers' => 'itemNumbers',
        'price' => 'price',
        'productCode' => 'productCode',
        'productFab' => 'productFab',
        'productId' => 'productId',
        'productInfo' => 'productInfo',
        'productName' => 'productName',
        'tag1' => 'tag1',
        'tag2' => 'tag2',
        'tag3' => 'tag3',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attribute) {
            $res['attribute'] = $this->attribute;
        }
        if (null !== $this->barcodes) {
            $res['barcodes'] = $this->barcodes;
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
        if (null !== $this->enable) {
            $res['enable'] = $this->enable;
        }
        if (null !== $this->imageFileIds) {
            $res['imageFileIds'] = $this->imageFileIds;
        }
        if (null !== $this->itemNumbers) {
            $res['itemNumbers'] = $this->itemNumbers;
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
        if (null !== $this->tag1) {
            $res['tag1'] = $this->tag1;
        }
        if (null !== $this->tag2) {
            $res['tag2'] = $this->tag2;
        }
        if (null !== $this->tag3) {
            $res['tag3'] = $this->tag3;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attribute'])) {
            $model->attribute = $map['attribute'];
        }
        if (isset($map['barcodes'])) {
            $model->barcodes = $map['barcodes'];
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
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['imageFileIds'])) {
            $model->imageFileIds = $map['imageFileIds'];
        }
        if (isset($map['itemNumbers'])) {
            $model->itemNumbers = $map['itemNumbers'];
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
        if (isset($map['tag1'])) {
            $model->tag1 = $map['tag1'];
        }
        if (isset($map['tag2'])) {
            $model->tag2 = $map['tag2'];
        }
        if (isset($map['tag3'])) {
            $model->tag3 = $map['tag3'];
        }

        return $model;
    }
}
