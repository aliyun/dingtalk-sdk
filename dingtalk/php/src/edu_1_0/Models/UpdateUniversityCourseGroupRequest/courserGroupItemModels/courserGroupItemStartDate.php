<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupRequest\courserGroupItemModels;

use AlibabaCloud\Tea\Model;

class courserGroupItemStartDate extends Model
{
    /**
     * @description 月
     *
     * @var int
     */
    public $month;

    /**
     * @description 年
     *
     * @var int
     */
    public $year;

    /**
     * @description 一月的第几天
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
     * @return courserGroupItemStartDate
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
