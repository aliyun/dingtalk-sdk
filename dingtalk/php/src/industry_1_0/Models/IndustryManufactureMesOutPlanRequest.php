<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesOutPlanRequest extends Model
{
    /**
     * @description 审批状态
     *
     * @var string
     */
    public $approvalStatus;

    /**
     * @description 审批人
     *
     * @var string
     */
    public $approver;

    /**
     * @description 主数据名称
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description 委外计划单号
     *
     * @var string
     */
    public $outSourceProjectCode;

    /**
     * @description 委外群
     *
     * @var string
     */
    public $outSourceTeamId;

    /**
     * @description 单价（元）
     *
     * @var string
     */
    public $price;

    /**
     * @description 工序识别码
     *
     * @var string
     */
    public $processIdentificationCode;

    /**
     * @description 委外的工序列表(多个)
     *
     * @var string
     */
    public $processUuids;

    /**
     * @description 产品代码(物料编号)
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 产品名称
     *
     * @var string
     */
    public $productName;

    /**
     * @description 规格型号
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @description 工单编号(生产任务单)
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 工单(生产计划单)ID
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 委外计划数
     *
     * @var string
     */
    public $sendPlanQuantity;

    /**
     * @description 供应商代码
     *
     * @var string
     */
    public $supplierCode;

    /**
     * @description 供应商名称
     *
     * @var string
     */
    public $supplierName;

    /**
     * @description 金额（元）
     *
     * @var string
     */
    public $totalWage;

    /**
     * @description 记录唯一标识
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
