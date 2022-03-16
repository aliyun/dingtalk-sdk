<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightResponseBody\data;

use AlibabaCloud\Tea\Model;

class objectiveProgress extends Model
{
    /**
     * @description 目标百分比。
     *
     * @var int
     */
    public $percent;
    protected $_name = [
        'percent' => 'percent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->percent) {
            $res['percent'] = $this->percent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return objectiveProgress
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['percent'])) {
            $model->percent = $map['percent'];
        }

        return $model;
    }
}
