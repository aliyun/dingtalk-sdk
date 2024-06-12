<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @example key: id或者name
     * }]
     * @var mixed[]
     */
    public $property;
    protected $_name = [
        'name'     => 'name',
        'property' => 'property',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFieldRequest
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

        return $model;
    }
}
