<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $materialCostNo;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var string
     */
    public $materialName;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var float
     */
    public $count;

    /**
     * @var float
     */
    public $price;

    /**
     * @var float
     */
    public $actPrice;

    /**
     * @var string
     */
    public $ext;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $memo;
    protected $_name = [
        'gmtCreate'      => 'gmtCreate',
        'gmtModified'    => 'gmtModified',
        'corpId'         => 'corpId',
        'materialCostNo' => 'materialCostNo',
        'instanceId'     => 'instanceId',
        'materialNo'     => 'materialNo',
        'materialName'   => 'materialName',
        'unit'           => 'unit',
        'count'          => 'count',
        'price'          => 'price',
        'actPrice'       => 'actPrice',
        'ext'            => 'ext',
        'processCode'    => 'processCode',
        'memo'           => 'memo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->materialCostNo) {
            $res['materialCostNo'] = $this->materialCostNo;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->actPrice) {
            $res['actPrice'] = $this->actPrice;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
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
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['materialCostNo'])) {
            $model->materialCostNo = $map['materialCostNo'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['actPrice'])) {
            $model->actPrice = $map['actPrice'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }

        return $model;
    }
}
