<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureJobBookResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 影响行数
     *
     * @var int
     */
    public $count;

    /**
     * @description 新增记录的数据库id
     *
     * @var int
     */
    public $id;
    protected $_name = [
        'count' => 'count',
        'id'    => 'id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
