<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsResponseBody\categoryStatisticsRecords;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsResponseBody\categoryTrend;
use AlibabaCloud\Tea\Model;

class CategoryStatisticsResponseBody extends Model
{
    /**
     * @description 分类统计
     *
     * @var categoryStatisticsRecords[]
     */
    public $categoryStatisticsRecords;

    /**
     * @description 分类趋势
     *
     * @var categoryTrend[]
     */
    public $categoryTrend;
    protected $_name = [
        'categoryStatisticsRecords' => 'categoryStatisticsRecords',
        'categoryTrend'             => 'categoryTrend',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryStatisticsRecords) {
            $res['categoryStatisticsRecords'] = [];
            if (null !== $this->categoryStatisticsRecords && \is_array($this->categoryStatisticsRecords)) {
                $n = 0;
                foreach ($this->categoryStatisticsRecords as $item) {
                    $res['categoryStatisticsRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->categoryTrend) {
            $res['categoryTrend'] = [];
            if (null !== $this->categoryTrend && \is_array($this->categoryTrend)) {
                $n = 0;
                foreach ($this->categoryTrend as $item) {
                    $res['categoryTrend'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CategoryStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryStatisticsRecords'])) {
            if (!empty($map['categoryStatisticsRecords'])) {
                $model->categoryStatisticsRecords = [];
                $n                                = 0;
                foreach ($map['categoryStatisticsRecords'] as $item) {
                    $model->categoryStatisticsRecords[$n++] = null !== $item ? categoryStatisticsRecords::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['categoryTrend'])) {
            if (!empty($map['categoryTrend'])) {
                $model->categoryTrend = [];
                $n                    = 0;
                foreach ($map['categoryTrend'] as $item) {
                    $model->categoryTrend[$n++] = null !== $item ? categoryTrend::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
