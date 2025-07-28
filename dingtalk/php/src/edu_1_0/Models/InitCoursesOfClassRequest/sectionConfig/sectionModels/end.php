<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\sectionConfig\sectionModels;

use AlibabaCloud\Tea\Model;

class end extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $hour;

    /**
     * @description This parameter is required.
     *
     * @example 45
     *
     * @var int
     */
    public $min;
    protected $_name = [
        'hour' => 'hour',
        'min' => 'min',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hour) {
            $res['hour'] = $this->hour;
        }
        if (null !== $this->min) {
            $res['min'] = $this->min;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return end
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hour'])) {
            $model->hour = $map['hour'];
        }
        if (isset($map['min'])) {
            $model->min = $map['min'];
        }

        return $model;
    }
}
