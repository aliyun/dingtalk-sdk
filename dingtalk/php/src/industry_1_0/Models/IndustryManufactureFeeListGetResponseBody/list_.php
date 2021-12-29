<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $id;

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
    public $productionTaskNo;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var string
     */
    public $materialName;

    /**
     * @var float
     */
    public $count;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $amount;

    /**
     * @var float
     */
    public $perAmount;

    /**
     * @var string
     */
    public $isDeleted;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $ext;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'id'               => 'id',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'corpId'           => 'corpId',
        'productionTaskNo' => 'productionTaskNo',
        'materialNo'       => 'materialNo',
        'materialName'     => 'materialName',
        'count'            => 'count',
        'unit'             => 'unit',
        'type'             => 'type',
        'amount'           => 'amount',
        'perAmount'        => 'perAmount',
        'isDeleted'        => 'isDeleted',
        'instanceId'       => 'instanceId',
        'processCode'      => 'processCode',
        'ext'              => 'ext',
        'title'            => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->productionTaskNo) {
            $res['productionTaskNo'] = $this->productionTaskNo;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->perAmount) {
            $res['perAmount'] = $this->perAmount;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['productionTaskNo'])) {
            $model->productionTaskNo = $map['productionTaskNo'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['perAmount'])) {
            $model->perAmount = $map['perAmount'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
