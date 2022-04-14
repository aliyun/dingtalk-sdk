<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchUpdateFormDataByInstanceIdRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 是否需要宜搭服务端异步执行该任务(选择异步执行那么OpenAPI调用会立即返回，并且任务会在宜搭服务端继续执行直至结束，且允许的单次更新数据量上限更大)
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @description 表单实例id列表
     *
     * @var string[]
     */
    public $formInstanceIdList;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 是否忽略空值
     *
     * @var bool
     */
    public $ignoreEmpty;

    /**
     * @description 是否不触发校验规则、关联业务规则和第三方服务回调（如果您的业务无必要触发这些那么请填true以增大单次更新允许的数据量上限以及API的执行速度）
     *
     * @var bool
     */
    public $noExecuteExpression;

    /**
     * @description 宜搭应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 用于更新表单实例的数据, 格式为json字符串, 能解析成Map结构, 解析得到的Map的键为表单组件id, 值为表单组件值。详情参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
     *
     * @var string
     */
    public $updateFormDataJson;

    /**
     * @description 是否使用最新的表单schema版本, 默认false
     *
     * @var bool
     */
    public $useLatestFormSchemaVersion;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'                    => 'appType',
        'asynchronousExecution'      => 'asynchronousExecution',
        'formInstanceIdList'         => 'formInstanceIdList',
        'formUuid'                   => 'formUuid',
        'ignoreEmpty'                => 'ignoreEmpty',
        'noExecuteExpression'        => 'noExecuteExpression',
        'systemToken'                => 'systemToken',
        'updateFormDataJson'         => 'updateFormDataJson',
        'useLatestFormSchemaVersion' => 'useLatestFormSchemaVersion',
        'userId'                     => 'userId',
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
        if (null !== $this->asynchronousExecution) {
            $res['asynchronousExecution'] = $this->asynchronousExecution;
        }
        if (null !== $this->formInstanceIdList) {
            $res['formInstanceIdList'] = $this->formInstanceIdList;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->ignoreEmpty) {
            $res['ignoreEmpty'] = $this->ignoreEmpty;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->updateFormDataJson) {
            $res['updateFormDataJson'] = $this->updateFormDataJson;
        }
        if (null !== $this->useLatestFormSchemaVersion) {
            $res['useLatestFormSchemaVersion'] = $this->useLatestFormSchemaVersion;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateFormDataByInstanceIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['asynchronousExecution'])) {
            $model->asynchronousExecution = $map['asynchronousExecution'];
        }
        if (isset($map['formInstanceIdList'])) {
            if (!empty($map['formInstanceIdList'])) {
                $model->formInstanceIdList = $map['formInstanceIdList'];
            }
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['ignoreEmpty'])) {
            $model->ignoreEmpty = $map['ignoreEmpty'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['updateFormDataJson'])) {
            $model->updateFormDataJson = $map['updateFormDataJson'];
        }
        if (isset($map['useLatestFormSchemaVersion'])) {
            $model->useLatestFormSchemaVersion = $map['useLatestFormSchemaVersion'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
