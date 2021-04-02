<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest\recurrence;

use AlibabaCloud\Tea\Model;

class pattern extends Model
{
    /**
     * @var string
     */
    public $type;

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
    public $firstDayOfWeek;

    /**
     * @var string
     */
    public $index;

    /**
     * @var int
     */
    public $interval;

    /**
     * @var int
     */
    public $month;
    protected $_name = [
        'type'           => 'type',
        'dayOfMonth'     => 'dayOfMonth',
        'daysOfWeek'     => 'daysOfWeek',
        'firstDayOfWeek' => 'firstDayOfWeek',
        'index'          => 'index',
        'interval'       => 'interval',
        'month'          => 'month',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->dayOfMonth) {
            $res['dayOfMonth'] = $this->dayOfMonth;
        }
        if (null !== $this->daysOfWeek) {
            $res['daysOfWeek'] = $this->daysOfWeek;
        }
        if (null !== $this->firstDayOfWeek) {
            $res['firstDayOfWeek'] = $this->firstDayOfWeek;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->interval) {
            $res['interval'] = $this->interval;
        }
        if (null !== $this->month) {
            $res['month'] = $this->month;
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['dayOfMonth'])) {
            $model->dayOfMonth = $map['dayOfMonth'];
        }
        if (isset($map['daysOfWeek'])) {
            $model->daysOfWeek = $map['daysOfWeek'];
        }
        if (isset($map['firstDayOfWeek'])) {
            $model->firstDayOfWeek = $map['firstDayOfWeek'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['interval'])) {
            $model->interval = $map['interval'];
        }
        if (isset($map['month'])) {
            $model->month = $map['month'];
        }

        return $model;
    }
}
