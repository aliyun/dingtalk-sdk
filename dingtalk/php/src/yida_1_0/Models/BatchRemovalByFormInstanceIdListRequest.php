<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRemovalByFormInstanceIdListRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 是否需要宜搭服务端异步执行该任务(选择异步执行删除操作，那么OpenAPI调用会立即返回，并且宜搭服务端会继续执行删除操作直至结束，且允许的单次删除数据量上限更大)
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @description 是否需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填false以降低API的耗时以及获得更大的单次删除数据量上限）
     *
     * @var bool
     */
    public $executeExpression;

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
        'appType'               => 'appType',
        'asynchronousExecution' => 'asynchronousExecution',
        'executeExpression'     => 'executeExpression',
        'formInstanceIdList'    => 'formInstanceIdList',
        'formUuid'              => 'formUuid',
        'systemToken'           => 'systemToken',
        'userId'                => 'userId',
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
        if (null !== $this->executeExpression) {
            $res['executeExpression'] = $this->executeExpression;
        }
        if (null !== $this->formInstanceIdList) {
            $res['formInstanceIdList'] = $this->formInstanceIdList;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
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
     * @return BatchRemovalByFormInstanceIdListRequest
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
        if (isset($map['executeExpression'])) {
            $model->executeExpression = $map['executeExpression'];
        }
        if (isset($map['formInstanceIdList'])) {
            if (!empty($map['formInstanceIdList'])) {
                $model->formInstanceIdList = $map['formInstanceIdList'];
            }
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
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
