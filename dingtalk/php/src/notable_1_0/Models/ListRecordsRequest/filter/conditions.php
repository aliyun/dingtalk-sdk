<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsRequest\filter;

use AlibabaCloud\Tea\Model;

class conditions extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $field;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operator;

    /**
     * @var mixed[]
     */
    public $value;
    protected $_name = [
        'field'    => 'field',
        'operator' => 'operator',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->field) {
            $res['field'] = $this->field;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conditions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['field'])) {
            $model->field = $map['field'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = $map['value'];
            }
        }

        return $model;
    }
}
