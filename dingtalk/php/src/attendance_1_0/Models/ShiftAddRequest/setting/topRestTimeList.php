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

    /**
     * @example OnDuty
     *
     * @var string
     */
    public $checkType;
    protected $_name = [
        'across' => 'across',
        'checkTime' => 'checkTime',
        'checkType' => 'checkType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->checkType) {
            $res['checkType'] = $this->checkType;
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
        if (isset($map['checkType'])) {
            $model->checkType = $map['checkType'];
        }

        return $model;
    }
}
