<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesOutputRequest extends Model
{
    /**
     * @description 本次操作的行为
     *
     * @var string
     */
    public $action;

    /**
     * @description 生态唯一标识, 需要注册
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 审批状态
     *
     * @var string
     */
    public $approveStatus;

    /**
     * @description 主数据名称
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description 不良品总数(多次报工)
     *
     * @var string
     */
    public $defectsAmount;

    /**
     * @description 不良品原因
     *
     * @var string
     */
    public $defectsReason;

    /**
     * @description 良品总数(多次报工)
     *
     * @var string
     */
    public $fineAmount;

    /**
     * @description 是否已质检
     *
     * @var string
     */
    public $hasQualityTest;

    /**
     * @description 任务逾期
     *
     * @var int
     */
    public $overdue;

    /**
     * @description 派工(总)数
     *
     * @var int
     */
    public $planQuantity;

    /**
     * @description 是否加急
     *
     * @var int
     */
    public $priority;

    /**
     * @description 工序名称
     *
     * @var string
     */
    public $processName;

    /**
     * @description 工序业务唯一标识
     *
     * @var string
     */
    public $processUuid;

    /**
     * @description 产品编号(物料编号)
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
     * @description 产品(物料)规格
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
     * @description 工单(生产计划单)
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 工单状态
     *
     * @var string
     */
    public $projectStatus;

    /**
     * @description 检验状态
     *
     * @var string
     */
    public $qualityTestStatus;

    /**
     * @description 任务计划结束(完成)时间
     *
     * @var string
     */
    public $taskPlanEndTime;

    /**
     * @description 任务计划开始时间
     *
     * @var string
     */
    public $taskPlanStartTime;

    /**
     * @description 派工任务状态
     *
     * @var string
     */
    public $taskStatus;

    /**
     * @description 报工类型(正常,委外)
     *
     * @var string
     */
    public $taskType;

    /**
     * @description 派工任务唯一标识
     *
     * @var string
     */
    public $taskUuid;

    /**
     * @description 负责班组id
     *
     * @var string
     */
    public $teamId;

    /**
     * @description 报工人staffNo(生产人员)
     *
     * @var string
     */
    public $userId;

    /**
     * @description 派工人名称
     *
     * @var string
     */
    public $userName;

    /**
     * @description 本次记录唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'               => 'action',
        'appKey'               => 'appKey',
        'approveStatus'        => 'approveStatus',
        'baseDataName'         => 'baseDataName',
        'defectsAmount'        => 'defectsAmount',
        'defectsReason'        => 'defectsReason',
        'fineAmount'           => 'fineAmount',
        'hasQualityTest'       => 'hasQualityTest',
        'overdue'              => 'overdue',
        'planQuantity'         => 'planQuantity',
        'priority'             => 'priority',
        'processName'          => 'processName',
        'processUuid'          => 'processUuid',
        'productCode'          => 'productCode',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'projectCode'          => 'projectCode',
        'projectId'            => 'projectId',
        'projectStatus'        => 'projectStatus',
        'qualityTestStatus'    => 'qualityTestStatus',
        'taskPlanEndTime'      => 'taskPlanEndTime',
        'taskPlanStartTime'    => 'taskPlanStartTime',
        'taskStatus'           => 'taskStatus',
        'taskType'             => 'taskType',
        'taskUuid'             => 'taskUuid',
        'teamId'               => 'teamId',
        'userId'               => 'userId',
        'userName'             => 'userName',
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
        if (null !== $this->approveStatus) {
            $res['approveStatus'] = $this->approveStatus;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->defectsAmount) {
            $res['defectsAmount'] = $this->defectsAmount;
        }
        if (null !== $this->defectsReason) {
            $res['defectsReason'] = $this->defectsReason;
        }
        if (null !== $this->fineAmount) {
            $res['fineAmount'] = $this->fineAmount;
        }
        if (null !== $this->hasQualityTest) {
            $res['hasQualityTest'] = $this->hasQualityTest;
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
        if (null !== $this->qualityTestStatus) {
            $res['qualityTestStatus'] = $this->qualityTestStatus;
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
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesOutputRequest
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
        if (isset($map['approveStatus'])) {
            $model->approveStatus = $map['approveStatus'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['defectsAmount'])) {
            $model->defectsAmount = $map['defectsAmount'];
        }
        if (isset($map['defectsReason'])) {
            $model->defectsReason = $map['defectsReason'];
        }
        if (isset($map['fineAmount'])) {
            $model->fineAmount = $map['fineAmount'];
        }
        if (isset($map['hasQualityTest'])) {
            $model->hasQualityTest = $map['hasQualityTest'];
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
        if (isset($map['qualityTestStatus'])) {
            $model->qualityTestStatus = $map['qualityTestStatus'];
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
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
