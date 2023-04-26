<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponseBody\result;

use AlibabaCloud\Tea\Model;

class choices extends Model
{
    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $choiceId;

    /**
     * @example 选项一
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'choiceId' => 'choiceId',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->choiceId) {
            $res['choiceId'] = $this->choiceId;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return choices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['choiceId'])) {
            $model->choiceId = $map['choiceId'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
