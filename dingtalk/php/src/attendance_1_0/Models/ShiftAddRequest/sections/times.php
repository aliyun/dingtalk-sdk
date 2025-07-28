<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\sections;

use AlibabaCloud\Tea\Model;

class times extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $across;

    /**
     * @example 30
     *
     * @var int
     */
    public $beginMin;

    /**
     * @description This parameter is required.
     *
     * @example 1714298274613
     *
     * @var int
     */
    public $checkTime;

    /**
     * @description This parameter is required.
     *
     * @example OnDuty
     *
     * @var string
     */
    public $checkType;

    /**
     * @example -1
     *
     * @var int
     */
    public $endMin;

    /**
     * @var int[]
     */
    public $flexMinutes;

    /**
     * @var bool
     */
    public $freeCheck;
    protected $_name = [
        'across' => 'across',
        'beginMin' => 'beginMin',
        'checkTime' => 'checkTime',
        'checkType' => 'checkType',
        'endMin' => 'endMin',
        'flexMinutes' => 'flexMinutes',
        'freeCheck' => 'freeCheck',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->beginMin) {
            $res['beginMin'] = $this->beginMin;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->checkType) {
            $res['checkType'] = $this->checkType;
        }
        if (null !== $this->endMin) {
            $res['endMin'] = $this->endMin;
        }
        if (null !== $this->flexMinutes) {
            $res['flexMinutes'] = $this->flexMinutes;
        }
        if (null !== $this->freeCheck) {
            $res['freeCheck'] = $this->freeCheck;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return times
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['across'])) {
            $model->across = $map['across'];
        }
        if (isset($map['beginMin'])) {
            $model->beginMin = $map['beginMin'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['checkType'])) {
            $model->checkType = $map['checkType'];
        }
        if (isset($map['endMin'])) {
            $model->endMin = $map['endMin'];
        }
        if (isset($map['flexMinutes'])) {
            if (!empty($map['flexMinutes'])) {
                $model->flexMinutes = $map['flexMinutes'];
            }
        }
        if (isset($map['freeCheck'])) {
            $model->freeCheck = $map['freeCheck'];
        }

        return $model;
    }
}
