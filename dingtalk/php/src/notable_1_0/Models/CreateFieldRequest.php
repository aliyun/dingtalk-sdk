<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFieldRequest extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @example key: id或者name
     * }]
     * @var mixed[]
     */
    public $property;

    /**
     * @var string
     */
    public $type;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'name'       => 'name',
        'property'   => 'property',
        'type'       => 'type',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->property) {
            $res['property'] = $this->property;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['property'])) {
            $model->property = $map['property'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
