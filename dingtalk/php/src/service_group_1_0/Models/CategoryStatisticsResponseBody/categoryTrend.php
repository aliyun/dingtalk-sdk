<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class categoryTrend extends Model
{
    /**
     * @description 心声数量
     *
     * @var int
     */
    public $count;

    /**
     * @description 日期
     *
     * @var string
     */
    public $dt;

    /**
     * @description 分类名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'count' => 'count',
        'dt'    => 'dt',
        'name'  => 'name',
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
        if (null !== $this->dt) {
            $res['dt'] = $this->dt;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categoryTrend
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['dt'])) {
            $model->dt = $map['dt'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
