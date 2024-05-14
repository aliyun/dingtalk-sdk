<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $amount;

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
     * @var int
     */
    public $id;

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
    public $isDeleted;

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
     * @var float
     */
    public $perAmount;

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
    public $productionTaskNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'amount'           => 'amount',
        'corpId'           => 'corpId',
        'count'            => 'count',
        'ext'              => 'ext',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'id'               => 'id',
        'instanceId'       => 'instanceId',
        'isDeleted'        => 'isDeleted',
        'materialName'     => 'materialName',
        'materialNo'       => 'materialNo',
        'perAmount'        => 'perAmount',
        'processCode'      => 'processCode',
        'productionTaskNo' => 'productionTaskNo',
        'title'            => 'title',
        'type'             => 'type',
        'unit'             => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->materialName) {
            $res['materialName'] = $this->materialName;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->perAmount) {
            $res['perAmount'] = $this->perAmount;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->productionTaskNo) {
            $res['productionTaskNo'] = $this->productionTaskNo;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['materialName'])) {
            $model->materialName = $map['materialName'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['perAmount'])) {
            $model->perAmount = $map['perAmount'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['productionTaskNo'])) {
            $model->productionTaskNo = $map['productionTaskNo'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
