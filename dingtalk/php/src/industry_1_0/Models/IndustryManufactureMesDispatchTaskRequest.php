<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesDispatchTaskRequest extends Model
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
     * @description 派工人名称
     *
     * @var string
     */
    public $dispatchStaffName;

    /**
     * @description 派工人ID
     *
     * @var string
     */
    public $dispatchStaffNo;

    /**
     * @description 良品总数(多次报工)
     *
     * @var string
     */
    public $fineAmount;

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
     * @description 任务分配员工列表(生产人员)
     *
     * @var string
     */
    public $taskOperators;

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
     * @description 任务类型(正常和委外)
     *
     * @var string
     */
    public $taskType;

    /**
     * @description 负责班组id
     *
     * @var string
     */
    public $teamId;

    /**
     * @description 本次记录唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'               => 'action',
        'appKey'               => 'appKey',
        'baseDataName'         => 'baseDataName',
        'defectsAmount'        => 'defectsAmount',
        'dispatchStaffName'    => 'dispatchStaffName',
        'dispatchStaffNo'      => 'dispatchStaffNo',
        'fineAmount'           => 'fineAmount',
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
        'taskOperators'        => 'taskOperators',
        'taskPlanEndTime'      => 'taskPlanEndTime',
        'taskPlanStartTime'    => 'taskPlanStartTime',
        'taskStatus'           => 'taskStatus',
        'taskType'             => 'taskType',
        'teamId'               => 'teamId',
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
