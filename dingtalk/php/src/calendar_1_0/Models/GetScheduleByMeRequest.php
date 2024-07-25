<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetScheduleByMeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'endTime'   => 'endTime',
        'startTime' => 'startTime',
        'userIds'   => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetScheduleByMeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
