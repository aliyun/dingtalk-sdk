<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\children;

use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @var string
     */
    public $bizAlias;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $label;

    /**
     * @var string[]
     */
    public $options;

    /**
     * @var bool
     */
    public $required;
    protected $_name = [
        'bizAlias' => 'bizAlias',
        'id'       => 'id',
        'label'    => 'label',
        'options'  => 'options',
        'required' => 'required',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return props
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = $map['options'];
            }
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }

        return $model;
    }
}
