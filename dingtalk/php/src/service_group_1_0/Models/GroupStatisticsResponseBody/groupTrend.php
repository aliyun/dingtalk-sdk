<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GroupStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class groupTrend extends Model
{
    /**
     * @description 群数量
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
    protected $_name = [
        'count' => 'count',
        'dt'    => 'dt',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupTrend
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

        return $model;
    }
}
