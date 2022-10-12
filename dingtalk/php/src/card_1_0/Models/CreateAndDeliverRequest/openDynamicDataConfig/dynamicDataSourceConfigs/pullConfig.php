<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\openDynamicDataConfig\dynamicDataSourceConfigs;

use AlibabaCloud\Tea\Model;

class pullConfig extends Model
{
    /**
     * @description 间隔
     *
     * @var int
     */
    public $interval;

    /**
     * @description 拉取策略 (NONE: 不拉取,无动态数据, INTERVAL: 间隔拉取, ONCE: 只拉取一次)
     *
     * @var string
     */
    public $pullStrategy;

    /**
     * @description 间隔的时间单位 (SECONDS, MINUTES, HOURS, DAYS)
     *
     * @var string
     */
    public $timeUnit;
    protected $_name = [
        'interval'     => 'interval',
        'pullStrategy' => 'pullStrategy',
        'timeUnit'     => 'timeUnit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->interval) {
            $res['interval'] = $this->interval;
        }
        if (null !== $this->pullStrategy) {
            $res['pullStrategy'] = $this->pullStrategy;
        }
        if (null !== $this->timeUnit) {
            $res['timeUnit'] = $this->timeUnit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pullConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['interval'])) {
            $model->interval = $map['interval'];
        }
        if (isset($map['pullStrategy'])) {
            $model->pullStrategy = $map['pullStrategy'];
        }
        if (isset($map['timeUnit'])) {
            $model->timeUnit = $map['timeUnit'];
        }

        return $model;
    }
}
