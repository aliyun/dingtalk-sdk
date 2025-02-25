<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest;

use AlibabaCloud\Tea\Model;

class numberCondition extends Model
{
    /**
     * @var string
     */
    public $operator;

    /**
     * @var mixed
     */
    public $value1;

    /**
     * @var mixed
     */
    public $value2;
    protected $_name = [
        'operator' => 'operator',
        'value1'   => 'value1',
        'value2'   => 'value2',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->value1) {
            $res['value1'] = $this->value1;
        }
        if (null !== $this->value2) {
            $res['value2'] = $this->value2;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return numberCondition
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['value1'])) {
            $model->value1 = $map['value1'];
        }
        if (isset($map['value2'])) {
            $model->value2 = $map['value2'];
        }

        return $model;
    }
}
