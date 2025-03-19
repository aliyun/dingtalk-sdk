<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example https://tianshu-vpc.oss-cn-sahnghai.aliyuncs.com
     *
     * @var string
     */
    public $digitalSignUrl;

    /**
     * @example 未知
     *
     * @var string
     */
    public $formDataJson;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example y
     *
     * @var string
     */
    public $noExecuteExpressions;

    /**
     * @description This parameter is required.
     *
     * @example AGREE
     *
     * @var string
     */
    public $outResult;

    /**
     * @description This parameter is required.
     *
     * @example f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description This parameter is required.
     *
     * @example 确认同意
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example hexxyy
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description This parameter is required.
     *
     * @example 12002575
     *
     * @var int
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example 未知
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType' => 'appType',
        'digitalSignUrl' => 'digitalSignUrl',
        'formDataJson' => 'formDataJson',
        'language' => 'language',
        'noExecuteExpressions' => 'noExecuteExpressions',
        'outResult' => 'outResult',
        'processInstanceId' => 'processInstanceId',
        'remark' => 'remark',
        'systemToken' => 'systemToken',
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
        if (null !== $this->digitalSignUrl) {
            $res['digitalSignUrl'] = $this->digitalSignUrl;
        }
        if (null !== $this->formDataJson) {
            $res['formDataJson'] = $this->formDataJson;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->noExecuteExpressions) {
            $res['noExecuteExpressions'] = $this->noExecuteExpressions;
        }
        if (null !== $this->outResult) {
            $res['outResult'] = $this->outResult;
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
     * @return ExecuteTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['digitalSignUrl'])) {
            $model->digitalSignUrl = $map['digitalSignUrl'];
        }
        if (isset($map['formDataJson'])) {
            $model->formDataJson = $map['formDataJson'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['noExecuteExpressions'])) {
            $model->noExecuteExpressions = $map['noExecuteExpressions'];
        }
        if (isset($map['outResult'])) {
            $model->outResult = $map['outResult'];
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
