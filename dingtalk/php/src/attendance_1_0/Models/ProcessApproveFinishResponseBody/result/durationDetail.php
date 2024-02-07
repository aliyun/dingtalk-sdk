<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveFinishResponseBody\result;

use AlibabaCloud\Tea\Model;

class durationDetail extends Model
{
    /**
     * @example 2019-08-15
     *
     * @var string
     */
    public $date;

    /**
     * @example 1.0
     *
     * @var float
     */
    public $duration;
    protected $_name = [
        'date'     => 'date',
        'duration' => 'duration',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return durationDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }

        return $model;
    }
}
