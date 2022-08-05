<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items;

use AlibabaCloud\Tea\Model;

class userLastOperation extends Model
{
    /**
     * @description 操作人名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 操作的时间戳（ms）。
     *
     * @var int
     */
    public $time;
    protected $_name = [
        'name' => 'name',
        'time' => 'time',
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
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userLastOperation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
