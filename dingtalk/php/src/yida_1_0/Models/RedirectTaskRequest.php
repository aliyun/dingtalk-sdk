<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RedirectTaskRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example y
     *
     * @var string
     */
    public $byManager;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $nowActionExecutorId;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @example task-123
     *
     * @var int
     */
    public $taskId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'             => 'appType',
        'byManager'           => 'byManager',
        'language'            => 'language',
        'nowActionExecutorId' => 'nowActionExecutorId',
        'processInstanceId'   => 'processInstanceId',
        'remark'              => 'remark',
        'systemToken'         => 'systemToken',
        'taskId'              => 'taskId',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->byManager) {
            $res['byManager'] = $this->byManager;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->nowActionExecutorId) {
            $res['nowActionExecutorId'] = $this->nowActionExecutorId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
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
     * @return RedirectTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['byManager'])) {
            $model->byManager = $map['byManager'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['nowActionExecutorId'])) {
            $model->nowActionExecutorId = $map['nowActionExecutorId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
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
