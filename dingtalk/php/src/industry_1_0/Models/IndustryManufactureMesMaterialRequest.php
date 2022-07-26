<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesMaterialRequest\extendData;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesMaterialRequest extends Model
{
    /**
     * @description 本次操作的行为
     *
     * @var string
     */
    public $action;

    /**
     * @description 生态唯一标识
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 主数据名称
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description 物料品类
     *
     * @var string
     */
    public $category;

    /**
     * @description 扩展字段
     *
     * @var extendData[]
     */
    public $extendData;

    /**
     * @description 物料编号
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 物料名称
     *
     * @var string
     */
    public $productName;

    /**
     * @description 物料规格
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @description 物料属性，如原材料/成品/半成品
     *
     * @var string
     */
    public $prop;

    /**
     * @description 物料单位
     *
     * @var string
     */
    public $unit;

    /**
     * @description 物料唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'               => 'action',
        'appKey'               => 'appKey',
        'baseDataName'         => 'baseDataName',
        'category'             => 'category',
        'extendData'           => 'extendData',
        'productCode'          => 'productCode',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'prop'                 => 'prop',
        'unit'                 => 'unit',
        'uuid'                 => 'uuid',
    ];

    public function validate()
    {
    }

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
                $n                 = 0;
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
