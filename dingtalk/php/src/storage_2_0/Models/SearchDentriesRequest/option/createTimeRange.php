<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest\option;

use AlibabaCloud\Tea\Model;

class createTimeRange extends Model
{
    /**
     * @example end_time
     *
     * @var int
     */
    public $endTime;

    /**
     * @example start_time
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime'   => 'endTime',
        'startTime' => 'startTime',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createTimeRange
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

        return $model;
    }
}
