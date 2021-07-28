<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses;

use AlibabaCloud\Tea\Model;

class dateModel extends Model
{
    /**
     * @description 月份。
     *
     * @var int
     */
    public $month;

    /**
     * @description 年份。
     *
     * @var int
     */
    public $year;

    /**
     * @description 每个月的第几天。
     *
     * @var int
     */
    public $dayOfMonth;
    protected $_name = [
        'month'      => 'month',
        'year'       => 'year',
        'dayOfMonth' => 'dayOfMonth',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->month) {
            $res['month'] = $this->month;
        }
        if (null !== $this->year) {
            $res['year'] = $this->year;
        }
        if (null !== $this->dayOfMonth) {
            $res['dayOfMonth'] = $this->dayOfMonth;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dateModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['month'])) {
            $model->month = $map['month'];
        }
        if (isset($map['year'])) {
            $model->year = $map['year'];
        }
        if (isset($map['dayOfMonth'])) {
            $model->dayOfMonth = $map['dayOfMonth'];
        }

        return $model;
    }
}
