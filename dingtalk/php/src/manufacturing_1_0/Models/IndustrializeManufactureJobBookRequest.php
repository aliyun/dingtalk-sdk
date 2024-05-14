<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustrializeManufactureJobBookRequest extends Model
{
    /**
     * @example ding2fff8349a3ae0105d
     *
     * @var string
     */
    public $corpId;

    /**
     * @example [     { 		"code": "equipmentName"， 		"name": "设备名称", 		"value": "8000", 		"valueType": "类型：字符串，数字等" 	}, { 		"code": "唯一标识"， 		"name": "自定义字段1", 		"value": "值", 		"valueType": "类型：字符串，数字等" 	}, { 		"code": "唯一标识"， 		"name": "自定义字段2", 		"value": "值", 		"valueType": "类型：字符串，数字等" 	}  ]
     *
     * @var string
     */
    public $extend;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $instNo;

    /**
     * @example n
     *
     * @var string
     */
    public $isBatchJob;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-05 08:00:21
     *
     * @var string
     */
    public $manufactureDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $mesAppKey;

    /**
     * @var string
     */
    public $processEnName;

    /**
     * @var string
     */
    public $processName;

    /**
     * @var string
     */
    public $productCode;

    /**
     * @var string
     */
    public $productEnName;

    /**
     * @var string
     */
    public $productName;

    /**
     * @var string
     */
    public $productSpecification;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @var string
     */
    public $reworkableQuantity;

    /**
     * @var string
     */
    public $scrappedQuantity;

    /**
     * @example 1.02
     *
     * @var string
     */
    public $unitPrice;

    /**
     * @example 1919442747879777, 1919442747879774
     *
     * @var string
     */
    public $userIdList;

    /**
     * @var string
     */
    public $userName;

    /**
     * @example 张三,李四
     *
     * @var string
     */
    public $userNameList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'corpId'               => 'corpId',
        'extend'               => 'extend',
        'instNo'               => 'instNo',
        'isBatchJob'           => 'isBatchJob',
        'manufactureDate'      => 'manufactureDate',
        'mesAppKey'            => 'mesAppKey',
        'processEnName'        => 'processEnName',
        'processName'          => 'processName',
        'productCode'          => 'productCode',
        'productEnName'        => 'productEnName',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'reworkableQuantity'   => 'reworkableQuantity',
        'scrappedQuantity'     => 'scrappedQuantity',
        'unitPrice'            => 'unitPrice',
        'userIdList'           => 'userIdList',
        'userName'             => 'userName',
        'userNameList'         => 'userNameList',
        'uuid'                 => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->isBatchJob) {
            $res['isBatchJob'] = $this->isBatchJob;
        }
        if (null !== $this->manufactureDate) {
            $res['manufactureDate'] = $this->manufactureDate;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->processEnName) {
            $res['processEnName'] = $this->processEnName;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productEnName) {
            $res['productEnName'] = $this->productEnName;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->productSpecification) {
            $res['productSpecification'] = $this->productSpecification;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->reworkableQuantity) {
            $res['reworkableQuantity'] = $this->reworkableQuantity;
        }
        if (null !== $this->scrappedQuantity) {
            $res['scrappedQuantity'] = $this->scrappedQuantity;
        }
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->userNameList) {
            $res['userNameList'] = $this->userNameList;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustrializeManufactureJobBookRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['isBatchJob'])) {
            $model->isBatchJob = $map['isBatchJob'];
        }
        if (isset($map['manufactureDate'])) {
            $model->manufactureDate = $map['manufactureDate'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['processEnName'])) {
            $model->processEnName = $map['processEnName'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productEnName'])) {
            $model->productEnName = $map['productEnName'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['productSpecification'])) {
            $model->productSpecification = $map['productSpecification'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['reworkableQuantity'])) {
            $model->reworkableQuantity = $map['reworkableQuantity'];
        }
        if (isset($map['scrappedQuantity'])) {
            $model->scrappedQuantity = $map['scrappedQuantity'];
        }
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }
        if (isset($map['userIdList'])) {
            $model->userIdList = $map['userIdList'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['userNameList'])) {
            $model->userNameList = $map['userNameList'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
