<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result;

use AlibabaCloud\Tea\Model;

class groupType extends Model
{
    /**
     * @var bool
     */
    public $canCreateGroup;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'canCreateGroup' => 'canCreateGroup',
        'name'           => 'name',
        'value'          => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->canCreateGroup) {
            $res['canCreateGroup'] = $this->canCreateGroup;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupType
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canCreateGroup'])) {
            $model->canCreateGroup = $map['canCreateGroup'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
