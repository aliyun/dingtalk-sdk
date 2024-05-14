<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesOutPlanRequest extends Model
{
    /**
     * @example APPROVING
     *
     * @var string
     */
    public $approvalStatus;

    /**
     * @example [{"userId":"123","name":"汉俊"}]
     *
     * @var string
     */
    public $approver;

    /**
     * @description This parameter is required.
     *
     * @example wwPlan
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description This parameter is required.
     *
     * @example WWJH-20220728
     *
     * @var string
     */
    public $outSourceProjectCode;

    /**
     * @example cid34444
     *
     * @var string
     */
    public $outSourceTeamId;

    /**
     * @example 321
     *
     * @var string
     */
    public $price;

    /**
     * @example 20220728_OP20
     *
     * @var string
     */
    public $processIdentificationCode;

    /**
     * @example [{       "uuid": "1543878029936459777",       "name": "YF-盐雾",       "preProcess": "1470231820594245633"     }]
     *
     * @var string
     */
    public $processUuids;

    /**
     * @example WL12345
     *
     * @var string
     */
    public $productCode;

    /**
     * @example 毛坯KM63三级盖
     *
     * @var string
     */
    public $productName;

    /**
     * @example 5/16*13.5
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @example 20220728_001
     *
     * @var string
     */
    public $projectCode;

    /**
     * @example 20220728_001
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 321
     *
     * @var string
     */
    public $sendPlanQuantity;

    /**
     * @example GX002
     *
     * @var string
     */
    public $supplierCode;

    /**
     * @example 北京供应
     *
     * @var string
     */
    public $supplierName;

    /**
     * @example 20
     *
     * @var string
     */
    public $totalWage;

    /**
     * @description This parameter is required.
     *
     * @example C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'approvalStatus'            => 'approvalStatus',
        'approver'                  => 'approver',
        'baseDataName'              => 'baseDataName',
        'outSourceProjectCode'      => 'outSourceProjectCode',
        'outSourceTeamId'           => 'outSourceTeamId',
        'price'                     => 'price',
        'processIdentificationCode' => 'processIdentificationCode',
        'processUuids'              => 'processUuids',
        'productCode'               => 'productCode',
        'productName'               => 'productName',
        'productSpecification'      => 'productSpecification',
        'projectCode'               => 'projectCode',
        'projectId'                 => 'projectId',
        'sendPlanQuantity'          => 'sendPlanQuantity',
        'supplierCode'              => 'supplierCode',
        'supplierName'              => 'supplierName',
        'totalWage'                 => 'totalWage',
        'uuid'                      => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvalStatus) {
            $res['approvalStatus'] = $this->approvalStatus;
        }
        if (null !== $this->approver) {
            $res['approver'] = $this->approver;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->outSourceProjectCode) {
            $res['outSourceProjectCode'] = $this->outSourceProjectCode;
        }
        if (null !== $this->outSourceTeamId) {
            $res['outSourceTeamId'] = $this->outSourceTeamId;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->processIdentificationCode) {
            $res['processIdentificationCode'] = $this->processIdentificationCode;
        }
        if (null !== $this->processUuids) {
            $res['processUuids'] = $this->processUuids;
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
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->sendPlanQuantity) {
            $res['sendPlanQuantity'] = $this->sendPlanQuantity;
        }
        if (null !== $this->supplierCode) {
            $res['supplierCode'] = $this->supplierCode;
        }
        if (null !== $this->supplierName) {
            $res['supplierName'] = $this->supplierName;
        }
        if (null !== $this->totalWage) {
            $res['totalWage'] = $this->totalWage;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesOutPlanRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvalStatus'])) {
            $model->approvalStatus = $map['approvalStatus'];
        }
        if (isset($map['approver'])) {
            $model->approver = $map['approver'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['outSourceProjectCode'])) {
            $model->outSourceProjectCode = $map['outSourceProjectCode'];
        }
        if (isset($map['outSourceTeamId'])) {
            $model->outSourceTeamId = $map['outSourceTeamId'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['processIdentificationCode'])) {
            $model->processIdentificationCode = $map['processIdentificationCode'];
        }
        if (isset($map['processUuids'])) {
            $model->processUuids = $map['processUuids'];
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
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['sendPlanQuantity'])) {
            $model->sendPlanQuantity = $map['sendPlanQuantity'];
        }
        if (isset($map['supplierCode'])) {
            $model->supplierCode = $map['supplierCode'];
        }
        if (isset($map['supplierName'])) {
            $model->supplierName = $map['supplierName'];
        }
        if (isset($map['totalWage'])) {
            $model->totalWage = $map['totalWage'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
