<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody\result;

use AlibabaCloud\Tea\Model;

class closingAccountModel extends Model
{
    /**
     * @description 封账时间-日
     *
     * @var int
     */
    public $closingDay;

    /**
     * @description 封账时间-时分
     *
     * @var int
     */
    public $closingHourMinutes;

    /**
     * @description 封账范围-结束日
     *
     * @var int
     */
    public $endDay;

    /**
     * @description 封账范围-结束月
     *
     * @var int
     */
    public $endMonth;

    /**
     * @description 封账范围-开始日
     *
     * @var int
     */
    public $startDay;

    /**
     * @description 封账范围-开始月
     *
     * @var int
     */
    public $startMonth;
    protected $_name = [
        'closingDay'         => 'closingDay',
        'closingHourMinutes' => 'closingHourMinutes',
        'endDay'             => 'endDay',
        'endMonth'           => 'endMonth',
        'startDay'           => 'startDay',
        'startMonth'         => 'startMonth',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->closingDay) {
            $res['closingDay'] = $this->closingDay;
        }
        if (null !== $this->closingHourMinutes) {
            $res['closingHourMinutes'] = $this->closingHourMinutes;
        }
        if (null !== $this->endDay) {
            $res['endDay'] = $this->endDay;
        }
        if (null !== $this->endMonth) {
            $res['endMonth'] = $this->endMonth;
        }
        if (null !== $this->startDay) {
            $res['startDay'] = $this->startDay;
        }
        if (null !== $this->startMonth) {
            $res['startMonth'] = $this->startMonth;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return closingAccountModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['closingDay'])) {
            $model->closingDay = $map['closingDay'];
        }
        if (isset($map['closingHourMinutes'])) {
            $model->closingHourMinutes = $map['closingHourMinutes'];
        }
        if (isset($map['endDay'])) {
            $model->endDay = $map['endDay'];
        }
        if (isset($map['endMonth'])) {
            $model->endMonth = $map['endMonth'];
        }
        if (isset($map['startDay'])) {
            $model->startDay = $map['startDay'];
        }
        if (isset($map['startMonth'])) {
            $model->startMonth = $map['startMonth'];
        }

        return $model;
    }
}
