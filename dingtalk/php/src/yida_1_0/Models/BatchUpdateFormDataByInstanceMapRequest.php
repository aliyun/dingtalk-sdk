<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchUpdateFormDataByInstanceMapRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 该任务是否需要服务端异步执行(选择异步执行那么OpenAPI调用会立即返回并且任务在宜搭服务端继续执行，可支持更大的单次更新数据量上限)
     *
     * @var bool
     */
    public $asynchronousExecution;

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
     * @description 是否不需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填true以减小API的耗时以及更大的单次更新数据量上限）
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
     * @description 表单实例数据, json字符串, 可以解析成Map, 解析后得到的Map的键是表单实例id, 值是表单实例更新值json字符串。具体结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
     *
     * @var mixed[]
     */
    public $updateFormDataJsonMap;

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
        'formUuid'                   => 'formUuid',
        'ignoreEmpty'                => 'ignoreEmpty',
        'noExecuteExpression'        => 'noExecuteExpression',
        'systemToken'                => 'systemToken',
        'updateFormDataJsonMap'      => 'updateFormDataJsonMap',
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
        if (null !== $this->updateFormDataJsonMap) {
            $res['updateFormDataJsonMap'] = $this->updateFormDataJsonMap;
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
     * @return BatchUpdateFormDataByInstanceMapRequest
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
        if (isset($map['updateFormDataJsonMap'])) {
            $model->updateFormDataJsonMap = $map['updateFormDataJsonMap'];
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
