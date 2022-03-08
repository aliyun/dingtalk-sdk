<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody\result;

use AlibabaCloud\Tea\Model;

class overtimeDivisions extends Model
{
    /**
     * @description 后一日类型
     *
     * @var string
     */
    public $nextDayType;

    /**
     * @description 前一日类型
     *
     * @var string
     */
    public $previousDayType;

    /**
     * @description 分割时间点
     *
     * @var string
     */
    public $timeSplitPoint;
    protected $_name = [
        'nextDayType'     => 'nextDayType',
        'previousDayType' => 'previousDayType',
        'timeSplitPoint'  => 'timeSplitPoint',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextDayType) {
            $res['nextDayType'] = $this->nextDayType;
        }
        if (null !== $this->previousDayType) {
            $res['previousDayType'] = $this->previousDayType;
        }
        if (null !== $this->timeSplitPoint) {
            $res['timeSplitPoint'] = $this->timeSplitPoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return overtimeDivisions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextDayType'])) {
            $model->nextDayType = $map['nextDayType'];
        }
        if (isset($map['previousDayType'])) {
            $model->previousDayType = $map['previousDayType'];
        }
        if (isset($map['timeSplitPoint'])) {
            $model->timeSplitPoint = $map['timeSplitPoint'];
        }

        return $model;
    }
}
