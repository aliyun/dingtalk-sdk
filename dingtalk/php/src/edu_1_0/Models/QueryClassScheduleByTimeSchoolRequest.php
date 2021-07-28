<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryClassScheduleByTimeSchoolRequest extends Model
{
    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 1621676000000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 1621566000000
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'startTime' => 'startTime',
        'endTime'   => 'endTime',
        'opUserId'  => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryClassScheduleByTimeSchoolRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
