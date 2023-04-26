<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models;

use AlibabaCloud\Tea\Model;

class DentriesAppPropertiesValue extends Model
{
    /**
     * @example property_name
     *
     * @var string
     */
    public $name;

    /**
     * @example property_value
     *
     * @var string
     */
    public $value;

    /**
     * @example PRIVATE
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'name'       => 'name',
        'value'      => 'value',
        'visibility' => 'visibility',
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
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DentriesAppPropertiesValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
