<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting;

use AlibabaCloud\Tea\Model;

class topRestTimeList extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $across;

    /**
     * @example 1714298002940
     *
     * @var int
     */
    public $checkTime;
    protected $_name = [
        'across'    => 'across',
        'checkTime' => 'checkTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topRestTimeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['across'])) {
            $model->across = $map['across'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }

        return $model;
    }
}
