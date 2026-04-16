<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SortFilterRequest\field;
use AlibabaCloud\Tea\Model;

class SortFilterRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var field
     */
    public $field;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'field' => 'field',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->field) {
            $res['field'] = null !== $this->field ? $this->field->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SortFilterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['field'])) {
            $model->field = field::fromMap($map['field']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
