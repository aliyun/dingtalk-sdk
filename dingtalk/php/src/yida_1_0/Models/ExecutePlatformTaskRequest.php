<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecutePlatformTaskRequest extends Model
{
    /**
     * @description 审批结果
     *
     * @var string
     */
    public $outResult;

    /**
     * @description 是否不执行校验&关联操作
     *
     * @var string
     */
    public $noExecuteExpressions;

    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 更新的表单数据
     *
     * @var string
     */
    public $formDataJson;

    /**
     * @description 应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 语言
     *
     * @var string
     */
    public $language;

    /**
     * @description 审批意见
     *
     * @var string
     */
    public $remark;

    /**
     * @description 流程实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 钉钉的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'outResult'            => 'outResult',
        'noExecuteExpressions' => 'noExecuteExpressions',
        'appType'              => 'appType',
        'formDataJson'         => 'formDataJson',
        'systemToken'          => 'systemToken',
        'language'             => 'language',
        'remark'               => 'remark',
        'processInstanceId'    => 'processInstanceId',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outResult) {
            $res['outResult'] = $this->outResult;
        }
        if (null !== $this->noExecuteExpressions) {
            $res['noExecuteExpressions'] = $this->noExecuteExpressions;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formDataJson) {
            $res['formDataJson'] = $this->formDataJson;
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
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecutePlatformTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outResult'])) {
            $model->outResult = $map['outResult'];
        }
        if (isset($map['noExecuteExpressions'])) {
            $model->noExecuteExpressions = $map['noExecuteExpressions'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formDataJson'])) {
            $model->formDataJson = $map['formDataJson'];
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
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
