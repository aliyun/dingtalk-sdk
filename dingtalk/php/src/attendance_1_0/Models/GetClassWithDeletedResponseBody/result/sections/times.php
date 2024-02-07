<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\sections;

use AlibabaCloud\Tea\Model;

class times extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $across;

    /**
     * @example 10
     *
     * @var int
     */
    public $beginMin;

    /**
     * @example 1970-01-01T09:00Z
     *
     * @var string
     */
    public $checkTime;

    /**
     * @example OnDuty
     *
     * @var string
     */
    public $checkType;

    /**
     * @example 10
     *
     * @var int
     */
    public $endMin;
    protected $_name = [
        'across'    => 'across',
        'beginMin'  => 'beginMin',
        'checkTime' => 'checkTime',
        'checkType' => 'checkType',
        'endMin'    => 'endMin',
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

        return $model;
    }
}
