<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCalenderSummaryResponseBody extends Model
{
    /**
     * @description 最近1天累计创建日程人数
     *
     * @var string
     */
    public $calendarCreateUserCnt;
    protected $_name = [
        'calendarCreateUserCnt' => 'calendarCreateUserCnt',
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

        return $model;
    }
}
