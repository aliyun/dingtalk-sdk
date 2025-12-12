<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalIndicatorDataPushRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 111
     *
     * @var string
     */
    public $data;

    /**
     * @example 2025-11-01 11:01:00
     *
     * @var string
     */
    public $period;

    /**
     * @example YEAR、HALF_YEAR、QUARTER、DOUBLE_MONTH、MONTH、WEEK
     *
     * @var string
     */
    public $periodType;
    protected $_name = [
        'data' => 'data',
        'period' => 'period',
        'periodType' => 'periodType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->periodType) {
            $res['periodType'] = $this->periodType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['periodType'])) {
            $model->periodType = $map['periodType'];
        }

        return $model;
    }
}
