<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\props;

use AlibabaCloud\Tea\Model;

class statField extends Model
{
    /**
     * @description id 值。
     *
     * @var string
     */
    public $id;

    /**
     * @description 名称。
     *
     * @var string
     */
    public $label;

    /**
     * @description 单位。
     *
     * @var string
     */
    public $unit;

    /**
     * @description 大写。
     *
     * @var bool
     */
    public $upper;
    protected $_name = [
        'id'    => 'id',
        'label' => 'label',
        'unit'  => 'unit',
        'upper' => 'upper',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->upper) {
            $res['upper'] = $this->upper;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return statField
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }

        return $model;
    }
}
