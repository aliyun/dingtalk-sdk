<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesDispatchTaskRequest extends Model
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
     * @example task
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @example 3
     *
     * @var string
     */
    public $defectsAmount;

    /**
     * @example 张三
     *
     * @var string
     */
    public $dispatchStaffName;

    /**
     * @example 170000000332
     *
     * @var string
     */
    public $dispatchStaffNo;

    /**
     * @example 20
     *
     * @var string
     */
    public $fineAmount;

    /**
     * @example 1
     *
     * @var int
     */
    public $overdue;

    /**
     * @example 321
     *
     * @var int
     */
    public $planQuantity;

    /**
     * @example 1
     *
     * @var int
     */
    public $priority;

    /**
     * @example 打磨
     *
     * @var string
     */
    public $processName;

    /**
     * @example fsdfs3fsd2234wds
     *
     * @var string
     */
    public $processUuid;

    /**
     * @example dingfsdfs3fsd2234wds
     *
     * @var string
     */
    public $productCode;

    /**
     * @example 毛坯KM50二级盖
     *
     * @var string
     */
    public $productName;

    /**
     * @example 20*20*3
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @example dingfsdfs3fsd2234wds
     *
     * @var string
     */
    public $projectCode;

    /**
     * @example 0220423001
     *
     * @var string
     */
    public $projectId;

    /**
     * @example WORKING
     *
     * @var string
     */
    public $projectStatus;

    /**
     * @example [{"userId":"123","name":"汉俊","planQuantity":30}]
     *
     * @var string
     */
    public $taskOperators;

    /**
     * @example 2021-03-12 23:59:59
     *
     * @var string
     */
    public $taskPlanEndTime;

    /**
     * @example 2021-03-12 23:59:59
     *
     * @var string
     */
    public $taskPlanStartTime;

    /**
     * @example WORKING
     *
     * @var string
     */
    public $taskStatus;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $taskType;

    /**
     * @example dfsdfs3fsd2234wds
     *
     * @var string
     */
    public $teamId;

    /**
     * @description This parameter is required.
     *
     * @example fsdfs3fsd2234wds
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action' => 'action',
        'appKey' => 'appKey',
        'baseDataName' => 'baseDataName',
        'defectsAmount' => 'defectsAmount',
        'dispatchStaffName' => 'dispatchStaffName',
        'dispatchStaffNo' => 'dispatchStaffNo',
        'fineAmount' => 'fineAmount',
        'overdue' => 'overdue',
        'planQuantity' => 'planQuantity',
        'priority' => 'priority',
        'processName' => 'processName',
        'processUuid' => 'processUuid',
        'productCode' => 'productCode',
        'productName' => 'productName',
        'productSpecification' => 'productSpecification',
        'projectCode' => 'projectCode',
        'projectId' => 'projectId',
        'projectStatus' => 'projectStatus',
        'taskOperators' => 'taskOperators',
        'taskPlanEndTime' => 'taskPlanEndTime',
        'taskPlanStartTime' => 'taskPlanStartTime',
        'taskStatus' => 'taskStatus',
        'taskType' => 'taskType',
        'teamId' => 'teamId',
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
        if (null !== $this->defectsAmount) {
            $res['defectsAmount'] = $this->defectsAmount;
        }
        if (null !== $this->dispatchStaffName) {
            $res['dispatchStaffName'] = $this->dispatchStaffName;
        }
        if (null !== $this->dispatchStaffNo) {
            $res['dispatchStaffNo'] = $this->dispatchStaffNo;
        }
        if (null !== $this->fineAmount) {
            $res['fineAmount'] = $this->fineAmount;
        }
        if (null !== $this->overdue) {
            $res['overdue'] = $this->overdue;
        }
        if (null !== $this->planQuantity) {
            $res['planQuantity'] = $this->planQuantity;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->processUuid) {
            $res['processUuid'] = $this->processUuid;
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
        if (null !== $this->projectStatus) {
            $res['projectStatus'] = $this->projectStatus;
        }
        if (null !== $this->taskOperators) {
            $res['taskOperators'] = $this->taskOperators;
        }
        if (null !== $this->taskPlanEndTime) {
            $res['taskPlanEndTime'] = $this->taskPlanEndTime;
        }
        if (null !== $this->taskPlanStartTime) {
            $res['taskPlanStartTime'] = $this->taskPlanStartTime;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesDispatchTaskRequest
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
        if (isset($map['defectsAmount'])) {
            $model->defectsAmount = $map['defectsAmount'];
        }
        if (isset($map['dispatchStaffName'])) {
            $model->dispatchStaffName = $map['dispatchStaffName'];
        }
        if (isset($map['dispatchStaffNo'])) {
            $model->dispatchStaffNo = $map['dispatchStaffNo'];
        }
        if (isset($map['fineAmount'])) {
            $model->fineAmount = $map['fineAmount'];
        }
        if (isset($map['overdue'])) {
            $model->overdue = $map['overdue'];
        }
        if (isset($map['planQuantity'])) {
            $model->planQuantity = $map['planQuantity'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['processUuid'])) {
            $model->processUuid = $map['processUuid'];
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
        if (isset($map['projectStatus'])) {
            $model->projectStatus = $map['projectStatus'];
        }
        if (isset($map['taskOperators'])) {
            $model->taskOperators = $map['taskOperators'];
        }
        if (isset($map['taskPlanEndTime'])) {
            $model->taskPlanEndTime = $map['taskPlanEndTime'];
        }
        if (isset($map['taskPlanStartTime'])) {
            $model->taskPlanStartTime = $map['taskPlanStartTime'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
