<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\EmotionStatisticsResponseBody\emotionStatisticsRecords;
use AlibabaCloud\Tea\Model;

class EmotionStatisticsResponseBody extends Model
{
    /**
     * @description 情感统计
     *
     * @var emotionStatisticsRecords[]
     */
    public $emotionStatisticsRecords;
    protected $_name = [
        'emotionStatisticsRecords' => 'emotionStatisticsRecords',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->emotionStatisticsRecords) {
            $res['emotionStatisticsRecords'] = [];
            if (null !== $this->emotionStatisticsRecords && \is_array($this->emotionStatisticsRecords)) {
                $n = 0;
                foreach ($this->emotionStatisticsRecords as $item) {
                    $res['emotionStatisticsRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EmotionStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['emotionStatisticsRecords'])) {
            if (!empty($map['emotionStatisticsRecords'])) {
                $model->emotionStatisticsRecords = [];
                $n                               = 0;
                foreach ($map['emotionStatisticsRecords'] as $item) {
                    $model->emotionStatisticsRecords[$n++] = null !== $item ? emotionStatisticsRecords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
