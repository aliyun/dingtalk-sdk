<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\EmotionStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class emotionStatisticsRecords extends Model
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
     * @example 20220101
     *
     * @var string
     */
    public $dt;

    /**
     * @description This parameter is required.
     *
     * @example 0.3
     *
     * @var float
     */
    public $emotionScore;
    protected $_name = [
        'count' => 'count',
        'dt' => 'dt',
        'emotionScore' => 'emotionScore',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->dt) {
            $res['dt'] = $this->dt;
        }
        if (null !== $this->emotionScore) {
            $res['emotionScore'] = $this->emotionScore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return emotionStatisticsRecords
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
        if (isset($map['emotionScore'])) {
            $model->emotionScore = $map['emotionScore'];
        }

        return $model;
    }
}
