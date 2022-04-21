<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TopicStatisticsResponseBody\topicStatisticsRecords;
use AlibabaCloud\Tea\Model;

class TopicStatisticsResponseBody extends Model
{
    /**
     * @description 话题趋势
     *
     * @var topicStatisticsRecords[]
     */
    public $topicStatisticsRecords;
    protected $_name = [
        'topicStatisticsRecords' => 'topicStatisticsRecords',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->topicStatisticsRecords) {
            $res['topicStatisticsRecords'] = [];
            if (null !== $this->topicStatisticsRecords && \is_array($this->topicStatisticsRecords)) {
                $n = 0;
                foreach ($this->topicStatisticsRecords as $item) {
                    $res['topicStatisticsRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TopicStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['topicStatisticsRecords'])) {
            if (!empty($map['topicStatisticsRecords'])) {
                $model->topicStatisticsRecords = [];
                $n                             = 0;
                foreach ($map['topicStatisticsRecords'] as $item) {
                    $model->topicStatisticsRecords[$n++] = null !== $item ? topicStatisticsRecords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
