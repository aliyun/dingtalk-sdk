<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RedirectTaskRequest extends Model
{
    /**
     * @description 实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 是否应用管理员进行转交; ●
     * n, userId必须传任务的当前执行人
     * @var string
     */
    public $byManager;

    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 验权token; 在应用数据中获取。
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 语言环境; 可选值：zh_CN/en_US
     *
     * @var string
     */
    public $language;

    /**
     * @description 转交备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 新的任务处理人工号
     *
     * @var string
     */
    public $nowActionExecutorId;

    /**
     * @description 钉钉的userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 任务ID
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'processInstanceId'   => 'processInstanceId',
        'byManager'           => 'byManager',
        'appType'             => 'appType',
        'systemToken'         => 'systemToken',
        'language'            => 'language',
        'remark'              => 'remark',
        'nowActionExecutorId' => 'nowActionExecutorId',
        'userId'              => 'userId',
        'taskId'              => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->byManager) {
            $res['byManager'] = $this->byManager;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->nowActionExecutorId) {
            $res['nowActionExecutorId'] = $this->nowActionExecutorId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
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
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['byManager'])) {
            $model->byManager = $map['byManager'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['nowActionExecutorId'])) {
            $model->nowActionExecutorId = $map['nowActionExecutorId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
