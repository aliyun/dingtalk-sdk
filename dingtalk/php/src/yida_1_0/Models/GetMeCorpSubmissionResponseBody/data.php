<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponseBody\data\actioner;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponseBody\data\currentActivityInstances;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description actioner
     *
     * @var actioner[]
     */
    public $actioner;

    /**
     * @description actionerId
     *
     * @var string[]
     */
    public $actionerId;

    /**
     * @description actionerName
     *
     * @var string[]
     */
    public $actionerName;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description createTime
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
     * @description finishTime
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
     * @description instValue
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
     * @description processId
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
     * @description title
     *
     * @var string
     */
    public $title;

    /**
     * @description version
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'actioner'                  => 'actioner',
        'actionerId'                => 'actionerId',
        'actionerName'              => 'actionerName',
        'appType'                   => 'appType',
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
        'title'                     => 'title',
        'version'                   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actioner) {
            $res['actioner'] = [];
            if (null !== $this->actioner && \is_array($this->actioner)) {
                $n = 0;
                foreach ($this->actioner as $item) {
                    $res['actioner'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->actionerId) {
            $res['actionerId'] = $this->actionerId;
        }
        if (null !== $this->actionerName) {
            $res['actionerName'] = $this->actionerName;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
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
        if (isset($map['actioner'])) {
            if (!empty($map['actioner'])) {
                $model->actioner = [];
                $n               = 0;
                foreach ($map['actioner'] as $item) {
                    $model->actioner[$n++] = null !== $item ? actioner::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['actionerId'])) {
            if (!empty($map['actionerId'])) {
                $model->actionerId = $map['actionerId'];
            }
        }
        if (isset($map['actionerName'])) {
            if (!empty($map['actionerName'])) {
                $model->actionerName = $map['actionerName'];
            }
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
