<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class customfields extends Model
{
    /**
     * @example 666a472803e46df8ce98a4a5
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @example date
     *
     * @var string
     */
    public $type;

    /**
     * @var mixed[][]
     */
    public $value;

    /**
     * @var string[]
     */
    public $values;
    protected $_name = [
        'customfieldId' => 'customfieldId',
        'type'          => 'type',
        'value'         => 'value',
        'values'        => 'values',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldId) {
            $res['customfieldId'] = $this->customfieldId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customfields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = $map['value'];
            }
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }

        return $model;
    }
}
