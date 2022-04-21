<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsResponseBody\intentionStatisticsRecords;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsResponseBody\intentionTrend;
use AlibabaCloud\Tea\Model;

class IntentionStatisticsResponseBody extends Model
{
    /**
     * @description 意图统计
     *
     * @var intentionStatisticsRecords[]
     */
    public $intentionStatisticsRecords;

    /**
     * @description 意图趋势
     *
     * @var intentionTrend[]
     */
    public $intentionTrend;
    protected $_name = [
        'intentionStatisticsRecords' => 'intentionStatisticsRecords',
        'intentionTrend'             => 'intentionTrend',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->intentionStatisticsRecords) {
            $res['intentionStatisticsRecords'] = [];
            if (null !== $this->intentionStatisticsRecords && \is_array($this->intentionStatisticsRecords)) {
                $n = 0;
                foreach ($this->intentionStatisticsRecords as $item) {
                    $res['intentionStatisticsRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->intentionTrend) {
            $res['intentionTrend'] = [];
            if (null !== $this->intentionTrend && \is_array($this->intentionTrend)) {
                $n = 0;
                foreach ($this->intentionTrend as $item) {
                    $res['intentionTrend'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IntentionStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['intentionStatisticsRecords'])) {
            if (!empty($map['intentionStatisticsRecords'])) {
                $model->intentionStatisticsRecords = [];
                $n                                 = 0;
                foreach ($map['intentionStatisticsRecords'] as $item) {
                    $model->intentionStatisticsRecords[$n++] = null !== $item ? intentionStatisticsRecords::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['intentionTrend'])) {
            if (!empty($map['intentionTrend'])) {
                $model->intentionTrend = [];
                $n                     = 0;
                foreach ($map['intentionTrend'] as $item) {
                    $model->intentionTrend[$n++] = null !== $item ? intentionTrend::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
