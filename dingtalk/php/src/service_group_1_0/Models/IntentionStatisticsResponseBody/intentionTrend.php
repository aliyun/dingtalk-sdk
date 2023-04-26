<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class intentionTrend extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $count;

    /**
     * @example 20220101
     *
     * @var string
     */
    public $dt;

    /**
     * @example 产品异常类
     *
     * @var string
     */
    public $intention;
    protected $_name = [
        'count'     => 'count',
        'dt'        => 'dt',
        'intention' => 'intention',
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
        if (null !== $this->intention) {
            $res['intention'] = $this->intention;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return intentionTrend
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
        if (isset($map['intention'])) {
            $model->intention = $map['intention'];
        }

        return $model;
    }
}
