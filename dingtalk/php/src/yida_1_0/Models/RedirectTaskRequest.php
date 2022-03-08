<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RedirectTaskRequest extends Model
{
    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 是否应用管理员进行转交; ●
     * n, userId必须传任务的当前执行人
     * @var string
     */
    public $byManager;

    /**
     * @description 语言环境; 可选值：zh_CN/en_US
     *
     * @var string
     */
    public $language;

    /**
     * @description 新的任务处理人工号
     *
     * @var string
     */
    public $nowActionExecutorId;

    /**
     * @description 实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 转交备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 验权token; 在应用数据中获取。
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 任务ID
     *
     * @var int
     */
    public $taskId;

    /**
     * @description 钉钉的userId
     *
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
