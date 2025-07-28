<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class forms extends Model
{
    /**
     * @example TextareaField_KGAW58AQ
     *
     * @var string
     */
    public $key;

    /**
     * @example 你希望的主题
     *
     * @var string
     */
    public $label;

    /**
     * @example 操作演示
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'key' => 'key',
        'label' => 'label',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return forms
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
