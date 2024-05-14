<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetRequest;

use AlibabaCloud\Tea\Model;

class fields extends Model
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

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'name'     => 'name',
        'property' => 'property',
        'type'     => 'type',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
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

        return $model;
    }
}
