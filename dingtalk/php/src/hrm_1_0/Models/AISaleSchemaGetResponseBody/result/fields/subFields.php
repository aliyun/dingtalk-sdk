<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleSchemaGetResponseBody\result\fields;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleSchemaGetResponseBody\result\fields\subFields\options;
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
    protected $_name = [
        'fieldKey' => 'fieldKey',
        'fieldLabel' => 'fieldLabel',
        'options' => 'options',
        'placeholder' => 'placeholder',
        'required' => 'required',
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

        return $model;
    }
}
