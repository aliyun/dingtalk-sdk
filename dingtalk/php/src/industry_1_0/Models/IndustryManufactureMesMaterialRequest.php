<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesMaterialRequest\extendData;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesMaterialRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @example opsoft
     *
     * @var string
     */
    public $appKey;

    /**
     * @example material
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @example 紧压白茶,白茶,红茶
     *
     * @var string
     */
    public $category;

    /**
     * @var extendData[]
     */
    public $extendData;

    /**
     * @example 20220509028
     *
     * @var string
     */
    public $productCode;

    /**
     * @example 毛坯SNR47端盖
     *
     * @var string
     */
    public $productName;

    /**
     * @example KM63
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @example 原材料
     *
     * @var string
     */
    public $prop;

    /**
     * @example 件
     *
     * @var string
     */
    public $unit;

    /**
     * @description This parameter is required.
     *
     * @example 39C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action' => 'action',
        'appKey' => 'appKey',
        'baseDataName' => 'baseDataName',
        'category' => 'category',
        'extendData' => 'extendData',
        'productCode' => 'productCode',
        'productName' => 'productName',
        'productSpecification' => 'productSpecification',
        'prop' => 'prop',
        'unit' => 'unit',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = [];
            if (null !== $this->extendData && \is_array($this->extendData)) {
                $n = 0;
                foreach ($this->extendData as $item) {
                    $res['extendData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->productSpecification) {
            $res['productSpecification'] = $this->productSpecification;
        }
        if (null !== $this->prop) {
            $res['prop'] = $this->prop;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesMaterialRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['extendData'])) {
            if (!empty($map['extendData'])) {
                $model->extendData = [];
                $n = 0;
                foreach ($map['extendData'] as $item) {
                    $model->extendData[$n++] = null !== $item ? extendData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['productSpecification'])) {
            $model->productSpecification = $map['productSpecification'];
        }
        if (isset($map['prop'])) {
            $model->prop = $map['prop'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
