<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrUpdateFormDataRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 宜搭表单实例数据 json格式，如果存在满足检索条件的表单实例数据则用此值增量更新满足检索条件的的表单实例数据，否则用此值创建一条表单实例。表单实例数据的结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
     *
     * @var string
     */
    public $formDataJson;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 是否不触发校验规则、关联业务规则和第三方服务回调
     *
     * @var bool
     */
    public $noExecuteExpression;

    /**
     * @description 用于检索表单实例数据的检索条件
     *
     * @var string
     */
    public $searchCondition;

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
        'appType'             => 'appType',
        'formDataJson'        => 'formDataJson',
        'formUuid'            => 'formUuid',
        'noExecuteExpression' => 'noExecuteExpression',
        'searchCondition'     => 'searchCondition',
        'systemToken'         => 'systemToken',
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
        if (null !== $this->formDataJson) {
            $res['formDataJson'] = $this->formDataJson;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
        }
        if (null !== $this->searchCondition) {
            $res['searchCondition'] = $this->searchCondition;
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
     * @return CreateOrUpdateFormDataRequest
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
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
        }
        if (isset($map['searchCondition'])) {
            $model->searchCondition = $map['searchCondition'];
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
