<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMesOutputRequest extends Model
{
    /**
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @example opsoft
     *
     * @var string
     */
    public $appKey;

    /**
     * @example AGREE
     *
     * @var string
     */
    public $approveStatus;

    /**
     * @example output
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
     * @example [{"count":10,"reason":"工废"},{"count":20,"reason":"料废"}]
     *
     * @var string
     */
    public $defectsReason;

    /**
     * @example 20
     *
     * @var string
     */
    public $fineAmount;

    /**
     * @example y
     *
     * @var string
     */
    public $hasQualityTest;

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
     * @example VERIFIED
     *
     * @var string
     */
    public $qualityTestStatus;

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
     * @example C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $taskUuid;

    /**
     * @example dfsdfs3fsd2234wds
     *
     * @var string
     */
    public $teamId;

    /**
     * @example 170000000332
     *
     * @var string
     */
    public $userId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $userName;

    /**
     * @example fsdfs3fsd2234wds
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
