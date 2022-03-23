<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCalenderSummaryResponseBody extends Model
{
    /**
     * @description 最近1天创建日程人数
     *
     * @var string
     */
    public $calendarCreateUserCnt;

    /**
     * @description 最近1天接收日程人数
     *
     * @var string
     */
    public $recvCalendarUserCnt1d;

    /**
     * @description 最近1天使用日程人数
     *
     * @var string
     */
    public $useCalendarUserCnt1d;
    protected $_name = [
        'calendarCreateUserCnt' => 'calendarCreateUserCnt',
        'recvCalendarUserCnt1d' => 'recvCalendarUserCnt1d',
        'useCalendarUserCnt1d'  => 'useCalendarUserCnt1d',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->calendarCreateUserCnt) {
            $res['calendarCreateUserCnt'] = $this->calendarCreateUserCnt;
        }
        if (null !== $this->recvCalendarUserCnt1d) {
            $res['recvCalendarUserCnt1d'] = $this->recvCalendarUserCnt1d;
        }
        if (null !== $this->useCalendarUserCnt1d) {
            $res['useCalendarUserCnt1d'] = $this->useCalendarUserCnt1d;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCalenderSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['calendarCreateUserCnt'])) {
            $model->calendarCreateUserCnt = $map['calendarCreateUserCnt'];
        }
        if (isset($map['recvCalendarUserCnt1d'])) {
            $model->recvCalendarUserCnt1d = $map['recvCalendarUserCnt1d'];
        }
        if (isset($map['useCalendarUserCnt1d'])) {
            $model->useCalendarUserCnt1d = $map['useCalendarUserCnt1d'];
        }

        return $model;
    }
}
