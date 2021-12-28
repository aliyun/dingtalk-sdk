<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\templateConfig;
use AlibabaCloud\Tea\Model;

class FormCreateRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @description 表单模板名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 表单模板描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 表单控件列表
     *
     * @var FormComponent[]
     */
    public $formComponents;

    /**
     * @description 模板配置信息
     *
     * @var templateConfig
     */
    public $templateConfig;
    protected $_name = [
        'dingCorpId'         => 'dingCorpId',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'requestId'          => 'RequestId',
        'processCode'        => 'processCode',
        'name'               => 'name',
        'description'        => 'description',
        'formComponents'     => 'formComponents',
        'templateConfig'     => 'templateConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->requestId) {
            $res['RequestId'] = $this->requestId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->formComponents) {
            $res['formComponents'] = [];
            if (null !== $this->formComponents && \is_array($this->formComponents)) {
                $n = 0;
                foreach ($this->formComponents as $item) {
                    $res['formComponents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->templateConfig) {
            $res['templateConfig'] = null !== $this->templateConfig ? $this->templateConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FormCreateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['RequestId'])) {
            $model->requestId = $map['RequestId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['formComponents'])) {
            if (!empty($map['formComponents'])) {
                $model->formComponents = [];
                $n                     = 0;
                foreach ($map['formComponents'] as $item) {
                    $model->formComponents[$n++] = null !== $item ? FormComponent::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['templateConfig'])) {
            $model->templateConfig = templateConfig::fromMap($map['templateConfig']);
        }

        return $model;
    }
}
