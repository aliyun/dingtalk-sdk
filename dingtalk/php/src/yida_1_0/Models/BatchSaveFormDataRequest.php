<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSaveFormDataRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 是否需要宜搭服务端异步执行该任务(如果选择异步创建表单实例，那么OpenAPI调用会立即返回，并且宜搭服务端会继续执行保存操作直至结束，且允许的单次保存数据量上限更大)
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @description 表单实例数据列表。表单实例数据的结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
     *
     * @var string[]
     */
    public $formDataJsonList;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 批量保存多条表单实例数据发生异常时是否跳过异常的表单实例并继续保存下一个表单实例数据。当noExecuteExpression为false时此参数才生效。
     *
     * @var bool
     */
    public $keepRunningAfterException;

    /**
     * @description 是否不触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填true以减小API的耗时以及获得更大的单次保存数据量上限）
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
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'                   => 'appType',
        'asynchronousExecution'     => 'asynchronousExecution',
        'formDataJsonList'          => 'formDataJsonList',
        'formUuid'                  => 'formUuid',
        'keepRunningAfterException' => 'keepRunningAfterException',
        'noExecuteExpression'       => 'noExecuteExpression',
        'systemToken'               => 'systemToken',
        'userId'                    => 'userId',
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
        if (null !== $this->formDataJsonList) {
            $res['formDataJsonList'] = $this->formDataJsonList;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->keepRunningAfterException) {
            $res['keepRunningAfterException'] = $this->keepRunningAfterException;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
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
     * @return BatchSaveFormDataRequest
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
        if (isset($map['formDataJsonList'])) {
            if (!empty($map['formDataJsonList'])) {
                $model->formDataJsonList = $map['formDataJsonList'];
            }
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['keepRunningAfterException'])) {
            $model->keepRunningAfterException = $map['keepRunningAfterException'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
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
