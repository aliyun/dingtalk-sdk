<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $actPrice;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $count;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $materialCostNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $materialName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $materialNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $memo;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $price;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $processCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'actPrice' => 'actPrice',
        'corpId' => 'corpId',
        'count' => 'count',
        'ext' => 'ext',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'instanceId' => 'instanceId',
        'materialCostNo' => 'materialCostNo',
        'materialName' => 'materialName',
        'materialNo' => 'materialNo',
        'memo' => 'memo',
        'price' => 'price',
        'processCode' => 'processCode',
        'unit' => 'unit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actPrice) {
            $res['actPrice'] = $this->actPrice;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialCostNo) {
            $res['materialCostNo'] = $this->materialCostNo;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actPrice'])) {
            $model->actPrice = $map['actPrice'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialCostNo'])) {
            $model->materialCostNo = $map['materialCostNo'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
