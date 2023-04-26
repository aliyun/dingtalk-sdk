<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody\result;

use AlibabaCloud\Tea\Model;

class closingAccountModel extends Model
{
    /**
     * @var int
     */
    public $closingDay;

    /**
     * @var int
     */
    public $closingHourMinutes;

    /**
     * @var int
     */
    public $endDay;

    /**
     * @var int
     */
    public $endMonth;

    /**
     * @var int
     */
    public $startDay;

    /**
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
