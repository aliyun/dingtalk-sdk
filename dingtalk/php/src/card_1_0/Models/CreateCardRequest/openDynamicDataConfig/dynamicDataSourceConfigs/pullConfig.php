<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\openDynamicDataConfig\dynamicDataSourceConfigs;

use AlibabaCloud\Tea\Model;

class pullConfig extends Model
{
    /**
     * @description 拉取的间隔时间，只在将 pullStrategy 设置为 INTERVAL 的时候生效
     *
     * @var int
     */
    public $interval;

    /**
     * @description 【条件必填】拉取策略，可选值：
     * ● ONCE：只拉取一次
     * @var string
     */
    public $pullStrategy;

    /**
     * @description 拉取的间隔时间的单位，只在将 pullStrategy 设置为 INTERVAL 的时候生效。 可选值：
     * ● DAYS
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
