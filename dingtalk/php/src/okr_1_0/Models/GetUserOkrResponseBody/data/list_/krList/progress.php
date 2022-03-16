<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetUserOkrResponseBody\data\list_\krList;

use AlibabaCloud\Tea\Model;

class progress extends Model
{
    /**
     * @description 百分比。
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
     * @return progress
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
