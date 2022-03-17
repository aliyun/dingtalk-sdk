<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesResponseBody\events\recurrence;

use AlibabaCloud\Tea\Model;

class pattern extends Model
{
    /**
     * @description 每月的第几天
     *
     * @var int
     */
    public $dayOfMonth;

    /**
     * @description 每周的第几天
     *
     * @var string
     */
    public $daysOfWeek;

    /**
     * @description 指定事件发生在daysOfsWeek中指定的允许天数的哪个实例上，从该月的第一个实例开始计算。取值为:first, second, third, fourth, last。默认是first。如果类型是relativMonthly或relativeYear，则可选并使用
     *
     * @var string
     */
    public $index;

    /**
     * @description 循环间隔
     *
     * @var int
     */
    public $interval;

    /**
     * @description 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
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
