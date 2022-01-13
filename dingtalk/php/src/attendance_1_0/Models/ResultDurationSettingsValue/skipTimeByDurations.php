<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ResultDurationSettingsValue;

use AlibabaCloud\Tea\Model;

class skipTimeByDurations extends Model
{
    /**
     * @description 每天加班满 x小时，单位 秒
     *
     * @var int
     */
    public $duration;

    /**
     * @description 扣除 x小时，单位 秒
     *
     * @var int
     */
    public $minus;
    protected $_name = [
        'duration' => 'duration',
        'minus'    => 'minus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->minus) {
            $res['minus'] = $this->minus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return skipTimeByDurations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['minus'])) {
            $model->minus = $map['minus'];
        }

        return $model;
    }
}
