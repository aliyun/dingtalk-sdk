<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest\recurrence;

use AlibabaCloud\Tea\Model;

class pattern extends Model
{
    /**
     * @var int
     */
    public $dayOfMonth;

    /**
     * @var string
     */
    public $daysOfWeek;

    /**
     * @var string
     */
    public $index;

    /**
     * @var int
     */
    public $interval;

    /**
     * @description 循环规则类型：  daily：每interval天 weekly：每interval周的第daysOfWeek天 absoluteMonthly：每interval月的第dayOfMonth天 relativeMonthly：每interval月的第index周的第daysOfWeek天 absoluteYearly：每interval年
     *
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'dayOfMonth' => 'dayOfMonth',
        'daysOfWeek' => 'daysOfWeek',
        'index'      => 'index',
        'interval'   => 'interval',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dayOfMonth) {
            $res['dayOfMonth'] = $this->dayOfMonth;
        }
        if (null !== $this->daysOfWeek) {
            $res['daysOfWeek'] = $this->daysOfWeek;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->interval) {
            $res['interval'] = $this->interval;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pattern
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dayOfMonth'])) {
            $model->dayOfMonth = $map['dayOfMonth'];
        }
        if (isset($map['daysOfWeek'])) {
            $model->daysOfWeek = $map['daysOfWeek'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['interval'])) {
            $model->interval = $map['interval'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
