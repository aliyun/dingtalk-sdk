<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\templateConfig;
use AlibabaCloud\Tea\Model;

class FormCreateRequest extends Model
{
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
     * @description 表单模板名称
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @description 模板配置信息
     *
     * @var templateConfig
     */
    public $templateConfig;
    protected $_name = [
        'description'    => 'description',
        'formComponents' => 'formComponents',
        'name'           => 'name',
        'processCode'    => 'processCode',
        'templateConfig' => 'templateConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['templateConfig'])) {
            $model->templateConfig = templateConfig::fromMap($map['templateConfig']);
        }

        return $model;
    }
}
