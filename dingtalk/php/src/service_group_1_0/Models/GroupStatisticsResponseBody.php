<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GroupStatisticsResponseBody\groupTrend;
use AlibabaCloud\Tea\Model;

class GroupStatisticsResponseBody extends Model
{
    /**
     * @description (本期)群总数
     *
     * @var int
     */
    public $groupCount;

    /**
     * @description 群趋势
     *
     * @var groupTrend[]
     */
    public $groupTrend;

    /**
     * @description 较上期增长数
     *
     * @var int
     */
    public $increaseGroupCount;

    /**
     * @description 较上期增长率(已乘以100）
     *
     * @var string
     */
    public $increaseRate;
    protected $_name = [
        'groupCount'         => 'groupCount',
        'groupTrend'         => 'groupTrend',
        'increaseGroupCount' => 'increaseGroupCount',
        'increaseRate'       => 'increaseRate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupCount) {
            $res['groupCount'] = $this->groupCount;
        }
        if (null !== $this->groupTrend) {
            $res['groupTrend'] = [];
            if (null !== $this->groupTrend && \is_array($this->groupTrend)) {
                $n = 0;
                foreach ($this->groupTrend as $item) {
                    $res['groupTrend'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->increaseGroupCount) {
            $res['increaseGroupCount'] = $this->increaseGroupCount;
        }
        if (null !== $this->increaseRate) {
            $res['increaseRate'] = $this->increaseRate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupCount'])) {
            $model->groupCount = $map['groupCount'];
        }
        if (isset($map['groupTrend'])) {
            if (!empty($map['groupTrend'])) {
                $model->groupTrend = [];
                $n                 = 0;
                foreach ($map['groupTrend'] as $item) {
                    $model->groupTrend[$n++] = null !== $item ? groupTrend::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['increaseGroupCount'])) {
            $model->increaseGroupCount = $map['increaseGroupCount'];
        }
        if (isset($map['increaseRate'])) {
            $model->increaseRate = $map['increaseRate'];
        }

        return $model;
    }
}
