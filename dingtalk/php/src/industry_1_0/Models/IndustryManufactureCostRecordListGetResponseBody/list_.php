<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetResponseBody;

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
    public $materialCostRecordNo;

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
     * @var string
     */
    public $type;

    /**
     * @var float
     */
    public $price;

    /**
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $productionTaskNo;

    /**
     * @var string
     */
    public $isDeleted;

    /**
     * @var string
     */
    public $ext;

    /**
     * @var string
     */
    public $memo;

    /**
     * @var float
     */
    public $realCount;

    /**
     * @var float
     */
    public $realPrice;

    /**
     * @var string
     */
    public $processCode;
    protected $_name = [
        'gmtCreate'            => 'gmtCreate',
        'gmtModified'          => 'gmtModified',
        'corpId'               => 'corpId',
        'materialCostRecordNo' => 'materialCostRecordNo',
        'instanceId'           => 'instanceId',
        'materialNo'           => 'materialNo',
        'materialName'         => 'materialName',
        'unit'                 => 'unit',
        'count'                => 'count',
        'type'                 => 'type',
        'price'                => 'price',
        'orderNo'              => 'orderNo',
        'productionTaskNo'     => 'productionTaskNo',
        'isDeleted'            => 'isDeleted',
        'ext'                  => 'ext',
        'memo'                 => 'memo',
        'realCount'            => 'realCount',
        'realPrice'            => 'realPrice',
        'processCode'          => 'processCode',
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
        if (null !== $this->materialCostRecordNo) {
            $res['materialCostRecordNo'] = $this->materialCostRecordNo;
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
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->productionTaskNo) {
            $res['productionTaskNo'] = $this->productionTaskNo;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->realCount) {
            $res['realCount'] = $this->realCount;
        }
        if (null !== $this->realPrice) {
            $res['realPrice'] = $this->realPrice;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
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
        if (isset($map['materialCostRecordNo'])) {
            $model->materialCostRecordNo = $map['materialCostRecordNo'];
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['productionTaskNo'])) {
            $model->productionTaskNo = $map['productionTaskNo'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['realCount'])) {
            $model->realCount = $map['realCount'];
        }
        if (isset($map['realPrice'])) {
            $model->realPrice = $map['realPrice'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
