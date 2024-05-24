<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example 主持人有问好，并得到积极回应
     *
     * @var string
     */
    public $info;

    /**
     * @example 是否有问好
     *
     * @var string
     */
    public $name;

    /**
     * @example 10
     *
     * @var int
     */
    public $point;
    protected $_name = [
        'info'  => 'info',
        'name'  => 'name',
        'point' => 'point',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->info) {
            $res['info'] = $this->info;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->point) {
            $res['point'] = $this->point;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['info'])) {
            $model->info = $map['info'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['point'])) {
            $model->point = $map['point'];
        }

        return $model;
    }
}
