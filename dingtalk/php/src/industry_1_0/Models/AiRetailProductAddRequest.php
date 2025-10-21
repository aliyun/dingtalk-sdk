<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class AiRetailProductAddRequest extends Model
{
    /**
     * @var string[]
     */
    public $attribute;

    /**
     * @var string[]
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
    public $currecy;

    /**
     * @example 1
     *
     * @var int
     */
    public $enable;

    /**
     * @var string[]
     */
    public $imageFileIds;

    /**
     * @var string[]
     */
    public $itemNumbers;

    /**
     * @var float
     */
    public $price;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $productCode;

    /**
     * @example 办公室的电话是：13222333232
     *
     * @var string
     */
    public $productFab;

    /**
     * @example https://xxxxxxx.com/xxxxxx
     *
     * @var string
     */
    public $productInfo;

    /**
     * @description This parameter is required.
     *
     * @example 办公室的电话是多少
     *
     * @var string
     */
    public $productName;
    protected $_name = [
        'attribute' => 'attribute',
        'barcodes' => 'barcodes',
        'brand' => 'brand',
        'category' => 'category',
        'currecy' => 'currecy',
        'enable' => 'enable',
        'imageFileIds' => 'imageFileIds',
        'itemNumbers' => 'itemNumbers',
        'price' => 'price',
        'productCode' => 'productCode',
        'productFab' => 'productFab',
        'productInfo' => 'productInfo',
        'productName' => 'productName',
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
        if (null !== $this->currecy) {
            $res['currecy'] = $this->currecy;
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
        if (null !== $this->productInfo) {
            $res['productInfo'] = $this->productInfo;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AiRetailProductAddRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attribute'])) {
            $model->attribute = $map['attribute'];
        }
        if (isset($map['barcodes'])) {
            if (!empty($map['barcodes'])) {
                $model->barcodes = $map['barcodes'];
            }
        }
        if (isset($map['brand'])) {
            $model->brand = $map['brand'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['currecy'])) {
            $model->currecy = $map['currecy'];
        }
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['imageFileIds'])) {
            if (!empty($map['imageFileIds'])) {
                $model->imageFileIds = $map['imageFileIds'];
            }
        }
        if (isset($map['itemNumbers'])) {
            if (!empty($map['itemNumbers'])) {
                $model->itemNumbers = $map['itemNumbers'];
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
        if (isset($map['productInfo'])) {
            $model->productInfo = $map['productInfo'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }

        return $model;
    }
}
