<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListResponseBody\result\data\fieldInstances;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListResponseBody\result\data\fieldInstances\subFields\options;
use AlibabaCloud\Tea\Model;

class subFields extends Model
{
    /**
     * @var string
     */
    public $fieldKey;

    /**
     * @var string
     */
    public $fieldLabel;

    /**
     * @var string
     */
    public $fieldValue;

    /**
     * @var options[]
     */
    public $options;

    /**
     * @var string
     */
    public $placeholder;

    /**
     * @var bool
     */
    public $required;

    /**
     * @var string
     */
    public $source;
    protected $_name = [
        'fieldKey' => 'fieldKey',
        'fieldLabel' => 'fieldLabel',
        'fieldValue' => 'fieldValue',
        'options' => 'options',
        'placeholder' => 'placeholder',
        'required' => 'required',
        'source' => 'source',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
        }
        if (null !== $this->fieldLabel) {
            $res['fieldLabel'] = $this->fieldLabel;
        }
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }
        if (null !== $this->options) {
            $res['options'] = [];
            if (null !== $this->options && \is_array($this->options)) {
                $n = 0;
                foreach ($this->options as $item) {
                    $res['options'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['fieldLabel'])) {
            $model->fieldLabel = $map['fieldLabel'];
        }
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = [];
                $n = 0;
                foreach ($map['options'] as $item) {
                    $model->options[$n++] = null !== $item ? options::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
