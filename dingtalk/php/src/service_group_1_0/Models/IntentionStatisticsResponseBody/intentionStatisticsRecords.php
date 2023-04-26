<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class intentionStatisticsRecords extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $count;

    /**
     * @example 产品异常类
     *
     * @var string
     */
    public $intention;

    /**
     * @example 9
     *
     * @var int
     */
    public $lastCount;
    protected $_name = [
        'count'     => 'count',
        'intention' => 'intention',
        'lastCount' => 'lastCount',
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
        if (null !== $this->intention) {
            $res['intention'] = $this->intention;
        }
        if (null !== $this->lastCount) {
            $res['lastCount'] = $this->lastCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return intentionStatisticsRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['intention'])) {
            $model->intention = $map['intention'];
        }
        if (isset($map['lastCount'])) {
            $model->lastCount = $map['lastCount'];
        }

        return $model;
    }
}
