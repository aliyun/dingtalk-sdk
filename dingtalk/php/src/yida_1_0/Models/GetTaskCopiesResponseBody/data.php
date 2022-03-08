<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesResponseBody\data\currentActivityInstances;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description actionerId
     *
     * @var string[]
     */
    public $actionExecutorId;

    /**
     * @description actionerName
     *
     * @var string[]
     */
    public $actionExecutorName;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description carbonActivityId
     *
     * @var string
     */
    public $carbonActivityId;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @description currentActivityInstances
     *
     * @var currentActivityInstances[]
     */
    public $currentActivityInstances;

    /**
     * @description dataMap
     *
     * @var mixed[]
     */
    public $dataMap;

    /**
     * @description dataType
     *
     * @var string
     */
    public $dataType;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @description formInstanceId
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description formUuid
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 实例数据
     *
     * @var string
     */
    public $instanceValue;

    /**
     * @description modifiedTime
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @description originatorAvatar
     *
     * @var string
     */
    public $originatorAvatar;

    /**
     * @description originatorDisplayName
     *
     * @var string
     */
    public $originatorDisplayName;

    /**
     * @description originatorId
     *
     * @var string
     */
    public $originatorId;

    /**
     * @description processApprovedResult
     *
     * @var string
     */
    public $processApprovedResult;

    /**
     * @description processApprovedResultText
     *
     * @var string
     */
    public $processApprovedResultText;

    /**
     * @description processCode
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 流程id
     *
     * @var int
     */
    public $processId;

    /**
     * @description processInstanceId
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description processInstanceStatus
     *
     * @var string
     */
    public $processInstanceStatus;

    /**
     * @description processInstanceStatusText
     *
     * @var string
     */
    public $processInstanceStatusText;

    /**
     * @description processName
     *
     * @var string
     */
    public $processName;

    /**
     * @description 序列号
     *
     * @var string
     */
    public $serialNumber;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 版本
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'actionExecutorId'          => 'actionExecutorId',
        'actionExecutorName'        => 'actionExecutorName',
        'appType'                   => 'appType',
        'carbonActivityId'          => 'carbonActivityId',
        'createTimeGMT'             => 'createTimeGMT',
        'currentActivityInstances'  => 'currentActivityInstances',
        'dataMap'                   => 'dataMap',
        'dataType'                  => 'dataType',
        'finishTimeGMT'             => 'finishTimeGMT',
        'formInstanceId'            => 'formInstanceId',
        'formUuid'                  => 'formUuid',
        'instanceValue'             => 'instanceValue',
        'modifiedTimeGMT'           => 'modifiedTimeGMT',
        'originatorAvatar'          => 'originatorAvatar',
        'originatorDisplayName'     => 'originatorDisplayName',
        'originatorId'              => 'originatorId',
        'processApprovedResult'     => 'processApprovedResult',
        'processApprovedResultText' => 'processApprovedResultText',
        'processCode'               => 'processCode',
        'processId'                 => 'processId',
        'processInstanceId'         => 'processInstanceId',
        'processInstanceStatus'     => 'processInstanceStatus',
        'processInstanceStatusText' => 'processInstanceStatusText',
        'processName'               => 'processName',
        'serialNumber'              => 'serialNumber',
        'title'                     => 'title',
        'version'                   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionExecutorId) {
            $res['actionExecutorId'] = $this->actionExecutorId;
        }
        if (null !== $this->actionExecutorName) {
            $res['actionExecutorName'] = $this->actionExecutorName;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->carbonActivityId) {
            $res['carbonActivityId'] = $this->carbonActivityId;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->currentActivityInstances) {
            $res['currentActivityInstances'] = [];
            if (null !== $this->currentActivityInstances && \is_array($this->currentActivityInstances)) {
                $n = 0;
                foreach ($this->currentActivityInstances as $item) {
                    $res['currentActivityInstances'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dataMap) {
            $res['dataMap'] = $this->dataMap;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->instanceValue) {
            $res['instanceValue'] = $this->instanceValue;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->originatorAvatar) {
            $res['originatorAvatar'] = $this->originatorAvatar;
        }
        if (null !== $this->originatorDisplayName) {
            $res['originatorDisplayName'] = $this->originatorDisplayName;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->processApprovedResult) {
            $res['processApprovedResult'] = $this->processApprovedResult;
        }
        if (null !== $this->processApprovedResultText) {
            $res['processApprovedResultText'] = $this->processApprovedResultText;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->processInstanceStatus) {
            $res['processInstanceStatus'] = $this->processInstanceStatus;
        }
        if (null !== $this->processInstanceStatusText) {
            $res['processInstanceStatusText'] = $this->processInstanceStatusText;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->serialNumber) {
            $res['serialNumber'] = $this->serialNumber;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionExecutorId'])) {
            if (!empty($map['actionExecutorId'])) {
                $model->actionExecutorId = $map['actionExecutorId'];
            }
        }
        if (isset($map['actionExecutorName'])) {
            if (!empty($map['actionExecutorName'])) {
                $model->actionExecutorName = $map['actionExecutorName'];
            }
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['carbonActivityId'])) {
            $model->carbonActivityId = $map['carbonActivityId'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['currentActivityInstances'])) {
            if (!empty($map['currentActivityInstances'])) {
                $model->currentActivityInstances = [];
                $n                               = 0;
                foreach ($map['currentActivityInstances'] as $item) {
                    $model->currentActivityInstances[$n++] = null !== $item ? currentActivityInstances::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dataMap'])) {
            $model->dataMap = $map['dataMap'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['instanceValue'])) {
            $model->instanceValue = $map['instanceValue'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['originatorAvatar'])) {
            $model->originatorAvatar = $map['originatorAvatar'];
        }
        if (isset($map['originatorDisplayName'])) {
            $model->originatorDisplayName = $map['originatorDisplayName'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['processApprovedResult'])) {
            $model->processApprovedResult = $map['processApprovedResult'];
        }
        if (isset($map['processApprovedResultText'])) {
            $model->processApprovedResultText = $map['processApprovedResultText'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['processInstanceStatus'])) {
            $model->processInstanceStatus = $map['processInstanceStatus'];
        }
        if (isset($map['processInstanceStatusText'])) {
            $model->processInstanceStatusText = $map['processInstanceStatusText'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['serialNumber'])) {
            $model->serialNumber = $map['serialNumber'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
