<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class categoryStatisticsRecords extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $count;

    /**
     * @description This parameter is required.
     *
     * @example 9
     *
     * @var int
     */
    public $lastCount;

    /**
     * @description This parameter is required.
     *
     * @example 工单类
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'count'     => 'count',
        'lastCount' => 'lastCount',
        'name'      => 'name',
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
        if (null !== $this->lastCount) {
            $res['lastCount'] = $this->lastCount;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categoryStatisticsRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['lastCount'])) {
            $model->lastCount = $map['lastCount'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
