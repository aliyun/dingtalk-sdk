<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ResultDurationSettingsValue;

use AlibabaCloud\Tea\Model;

class skipTimeByFrames extends Model
{
    /**
     * @description 开始时间，格式为"HH:mm"
     *
     * @var string
     */
    public $startTime;

    /**
     * @description 结束时间，格式为"HH:mm"
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 是否生效
     *
     * @var bool
     */
    public $valid;
    protected $_name = [
        'startTime' => 'startTime',
        'endTime'   => 'endTime',
        'valid'     => 'valid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->valid) {
            $res['valid'] = $this->valid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return skipTimeByFrames
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['valid'])) {
            $model->valid = $map['valid'];
        }

        return $model;
    }
}
