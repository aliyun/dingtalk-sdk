<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups\selectedClass;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups\selectedClass\setting\restTimeList;
use AlibabaCloud\Tea\Model;

class setting extends Model
{
    /**
     * @example 30
     *
     * @var int
     */
    public $absenteeismLateMinutes;

    /**
     * @example 1
     *
     * @var int
     */
    public $classSettingId;

    /**
     * @example Y
     *
     * @var string
     */
    public $isOffDutyFreeCheck;

    /**
     * @example 10
     *
     * @var int
     */
    public $permitLateMinutes;

    /**
     * @var restTimeList[]
     */
    public $restTimeList;

    /**
     * @example 20
     *
     * @var int
     */
    public $seriousLateMinutes;

    /**
     * @example -1
     *
     * @var int
     */
    public $workTimeMinutes;
    protected $_name = [
        'absenteeismLateMinutes' => 'absenteeismLateMinutes',
        'classSettingId'         => 'classSettingId',
        'isOffDutyFreeCheck'     => 'isOffDutyFreeCheck',
        'permitLateMinutes'      => 'permitLateMinutes',
        'restTimeList'           => 'restTimeList',
        'seriousLateMinutes'     => 'seriousLateMinutes',
        'workTimeMinutes'        => 'workTimeMinutes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->absenteeismLateMinutes) {
            $res['absenteeismLateMinutes'] = $this->absenteeismLateMinutes;
        }
        if (null !== $this->classSettingId) {
            $res['classSettingId'] = $this->classSettingId;
        }
        if (null !== $this->isOffDutyFreeCheck) {
            $res['isOffDutyFreeCheck'] = $this->isOffDutyFreeCheck;
        }
        if (null !== $this->permitLateMinutes) {
            $res['permitLateMinutes'] = $this->permitLateMinutes;
        }
        if (null !== $this->restTimeList) {
            $res['restTimeList'] = [];
            if (null !== $this->restTimeList && \is_array($this->restTimeList)) {
                $n = 0;
                foreach ($this->restTimeList as $item) {
                    $res['restTimeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->seriousLateMinutes) {
            $res['seriousLateMinutes'] = $this->seriousLateMinutes;
        }
        if (null !== $this->workTimeMinutes) {
            $res['workTimeMinutes'] = $this->workTimeMinutes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return setting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['absenteeismLateMinutes'])) {
            $model->absenteeismLateMinutes = $map['absenteeismLateMinutes'];
        }
        if (isset($map['classSettingId'])) {
            $model->classSettingId = $map['classSettingId'];
        }
        if (isset($map['isOffDutyFreeCheck'])) {
            $model->isOffDutyFreeCheck = $map['isOffDutyFreeCheck'];
        }
        if (isset($map['permitLateMinutes'])) {
            $model->permitLateMinutes = $map['permitLateMinutes'];
        }
        if (isset($map['restTimeList'])) {
            if (!empty($map['restTimeList'])) {
                $model->restTimeList = [];
                $n                   = 0;
                foreach ($map['restTimeList'] as $item) {
                    $model->restTimeList[$n++] = null !== $item ? restTimeList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['seriousLateMinutes'])) {
            $model->seriousLateMinutes = $map['seriousLateMinutes'];
        }
        if (isset($map['workTimeMinutes'])) {
            $model->workTimeMinutes = $map['workTimeMinutes'];
        }

        return $model;
    }
}
