<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description action
     *
     * @var string
     */
    public $action;

    /**
     * @description actionExt
     *
     * @var string
     */
    public $actionExit;

    /**
     * @description activeTime
     *
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @description activityId
     *
     * @var string
     */
    public $activityId;

    /**
     * @description id
     *
     * @var int
     */
    public $dataId;

    /**
     * @description digitalSign
     *
     * @var string
     */
    public $digitalSign;

    /**
     * @description files
     *
     * @var string
     */
    public $files;

    /**
     * @description operateTime
     *
     * @var string
     */
    public $operateTimeGMT;

    /**
     * @description operateType
     *
     * @var string
     */
    public $operateType;

    /**
     * @description operatorDisplayName
     *
     * @var string
     */
    public $operatorDisplayName;

    /**
     * @description operatorName
     *
     * @var string
     */
    public $operatorName;

    /**
     * @description operatorNick
     *
     * @var string
     */
    public $operatorNickName;

    /**
     * @description operatorPhotoUrl
     *
     * @var string
     */
    public $operatorPhotoUrl;

    /**
     * @description operatorStatus
     *
     * @var string
     */
    public $operatorStatus;

    /**
     * @description operator
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description processInstanceId
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description remark
     *
     * @var string
     */
    public $remark;

    /**
     * @description showName
     *
     * @var string
     */
    public $showName;

    /**
     * @description size
     *
     * @var int
     */
    public $size;

    /**
     * @description taskExecuteType
     *
     * @var string
     */
    public $taskExecuteType;

    /**
     * @description taskHoldTime
     *
     * @var int
     */
    public $taskHoldTimeGMT;

    /**
     * @description taskId
     *
     * @var string
     */
    public $taskId;

    /**
     * @description taskType
     *
     * @var string
     */
    public $taskType;

    /**
     * @description type
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'action'              => 'action',
        'actionExit'          => 'actionExit',
        'activeTimeGMT'       => 'activeTimeGMT',
        'activityId'          => 'activityId',
        'dataId'              => 'dataId',
        'digitalSign'         => 'digitalSign',
        'files'               => 'files',
        'operateTimeGMT'      => 'operateTimeGMT',
        'operateType'         => 'operateType',
        'operatorDisplayName' => 'operatorDisplayName',
        'operatorName'        => 'operatorName',
        'operatorNickName'    => 'operatorNickName',
        'operatorPhotoUrl'    => 'operatorPhotoUrl',
        'operatorStatus'      => 'operatorStatus',
        'operatorUserId'      => 'operatorUserId',
        'processInstanceId'   => 'processInstanceId',
        'remark'              => 'remark',
        'showName'            => 'showName',
        'size'                => 'size',
        'taskExecuteType'     => 'taskExecuteType',
        'taskHoldTimeGMT'     => 'taskHoldTimeGMT',
        'taskId'              => 'taskId',
        'taskType'            => 'taskType',
        'type'                => 'type',
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
        if (null !== $this->actionExit) {
            $res['actionExit'] = $this->actionExit;
        }
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
        }
        if (null !== $this->digitalSign) {
            $res['digitalSign'] = $this->digitalSign;
        }
        if (null !== $this->files) {
            $res['files'] = $this->files;
        }
        if (null !== $this->operateTimeGMT) {
            $res['operateTimeGMT'] = $this->operateTimeGMT;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->operatorDisplayName) {
            $res['operatorDisplayName'] = $this->operatorDisplayName;
        }
        if (null !== $this->operatorName) {
            $res['operatorName'] = $this->operatorName;
        }
        if (null !== $this->operatorNickName) {
            $res['operatorNickName'] = $this->operatorNickName;
        }
        if (null !== $this->operatorPhotoUrl) {
            $res['operatorPhotoUrl'] = $this->operatorPhotoUrl;
        }
        if (null !== $this->operatorStatus) {
            $res['operatorStatus'] = $this->operatorStatus;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->showName) {
            $res['showName'] = $this->showName;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->taskExecuteType) {
            $res['taskExecuteType'] = $this->taskExecuteType;
        }
        if (null !== $this->taskHoldTimeGMT) {
            $res['taskHoldTimeGMT'] = $this->taskHoldTimeGMT;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['actionExit'])) {
            $model->actionExit = $map['actionExit'];
        }
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
        }
        if (isset($map['digitalSign'])) {
            $model->digitalSign = $map['digitalSign'];
        }
        if (isset($map['files'])) {
            $model->files = $map['files'];
        }
        if (isset($map['operateTimeGMT'])) {
            $model->operateTimeGMT = $map['operateTimeGMT'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['operatorDisplayName'])) {
            $model->operatorDisplayName = $map['operatorDisplayName'];
        }
        if (isset($map['operatorName'])) {
            $model->operatorName = $map['operatorName'];
        }
        if (isset($map['operatorNickName'])) {
            $model->operatorNickName = $map['operatorNickName'];
        }
        if (isset($map['operatorPhotoUrl'])) {
            $model->operatorPhotoUrl = $map['operatorPhotoUrl'];
        }
        if (isset($map['operatorStatus'])) {
            $model->operatorStatus = $map['operatorStatus'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['showName'])) {
            $model->showName = $map['showName'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['taskExecuteType'])) {
            $model->taskExecuteType = $map['taskExecuteType'];
        }
        if (isset($map['taskHoldTimeGMT'])) {
            $model->taskHoldTimeGMT = $map['taskHoldTimeGMT'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
