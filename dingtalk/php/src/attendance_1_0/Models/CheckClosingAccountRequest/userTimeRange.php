<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountRequest;

use AlibabaCloud\Tea\Model;

class userTimeRange extends Model
{
    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $endTime;
    protected $_name = [
        'startTime' => 'startTime',
        'endTime'   => 'endTime',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userTimeRange
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

        return $model;
    }
}
