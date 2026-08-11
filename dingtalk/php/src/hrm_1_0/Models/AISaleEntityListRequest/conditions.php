<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListRequest;

use AlibabaCloud\Tea\Model;

class conditions extends Model
{
    /**
     * @var string
     */
    public $fieldKey;

    /**
     * @var string
     */
    public $operator;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'fieldKey' => 'fieldKey',
        'operator' => 'operator',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldKey) {
            $res['fieldKey'] = $this->fieldKey;
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
        if (isset($map['fieldKey'])) {
            $model->fieldKey = $map['fieldKey'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
