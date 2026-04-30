<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class RestartInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $currentActivityId;

    /**
     * @var string
     */
    public $envProfile;

    /**
     * @description This parameter is required.
     *
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $procInstanceId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $targetActivityId;

    /**
     * @description This parameter is required.
     *
     * @example task-123
     *
     * @var string
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType' => 'appType',
        'currentActivityId' => 'currentActivityId',
        'envProfile' => 'envProfile',
        'formUuid' => 'formUuid',
        'procInstanceId' => 'procInstanceId',
        'remark' => 'remark',
        'systemToken' => 'systemToken',
        'targetActivityId' => 'targetActivityId',
        'taskId' => 'taskId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->currentActivityId) {
            $res['currentActivityId'] = $this->currentActivityId;
        }
        if (null !== $this->envProfile) {
            $res['envProfile'] = $this->envProfile;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->procInstanceId) {
            $res['procInstanceId'] = $this->procInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->targetActivityId) {
            $res['targetActivityId'] = $this->targetActivityId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RestartInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['currentActivityId'])) {
            $model->currentActivityId = $map['currentActivityId'];
        }
        if (isset($map['envProfile'])) {
            $model->envProfile = $map['envProfile'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['procInstanceId'])) {
            $model->procInstanceId = $map['procInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['targetActivityId'])) {
            $model->targetActivityId = $map['targetActivityId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
