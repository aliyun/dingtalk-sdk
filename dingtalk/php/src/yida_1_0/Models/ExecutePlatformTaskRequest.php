<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecutePlatformTaskRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

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
     * @example ●
     * disagree
     * @var string
     */
    public $outResult;

    /**
     * @example f30233fb-72e1-4af4-8cb8-c7e0ea9ee530
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 确认同意
     *
     * @var string
     */
    public $remark;

    /**
     * @example hexxyyddd
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example yida_pub_account
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'              => 'appType',
        'formDataJson'         => 'formDataJson',
        'language'             => 'language',
        'noExecuteExpressions' => 'noExecuteExpressions',
        'outResult'            => 'outResult',
        'processInstanceId'    => 'processInstanceId',
        'remark'               => 'remark',
        'systemToken'          => 'systemToken',
        'userId'               => 'userId',
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
