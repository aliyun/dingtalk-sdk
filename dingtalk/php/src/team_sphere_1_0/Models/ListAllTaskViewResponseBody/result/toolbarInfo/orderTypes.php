<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\toolbarInfo;

use AlibabaCloud\Tea\Model;

class orderTypes extends Model
{
    /**
     * @var string
     */
    public $direction;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $supportDirection;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'direction'        => 'direction',
        'name'             => 'name',
        'supportDirection' => 'supportDirection',
        'value'            => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->direction) {
            $res['direction'] = $this->direction;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->supportDirection) {
            $res['supportDirection'] = $this->supportDirection;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orderTypes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['direction'])) {
            $model->direction = $map['direction'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['supportDirection'])) {
            $model->supportDirection = $map['supportDirection'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
