<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ResultDurationSettingsValue\skipTimeByDurations;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ResultDurationSettingsValue\skipTimeByFrames;
use AlibabaCloud\Tea\Model;

class ResultDurationSettingsValue extends Model
{
    /**
     * @var int
     */
    public $calcType;

    /**
     * @var int
     */
    public $durationType;

    /**
     * @description 加班时长计为调休或加班费开关
     *
     * @var bool
     */
    public $overtimeRedress;

    /**
     * @description 加班开始时间 或 最小加班时间
     *
     * @var mixed[]
     */
    public $settings;

    /**
     * @description 加班时长计为方式
     *
     * @var string
     */
    public $overtimeRedressBy;

    /**
     * @description 调休时长计算
     *
     * @var float
     */
    public $vacationRate;

    /**
     * @description 扣除休息时间
     *
     * @var string
     */
    public $skipTime;

    /**
     * @description 休息时段
     *
     * @var skipTimeByFrames[]
     */
    public $skipTimeByFrames;

    /**
     * @description 加班时长
     *
     * @var skipTimeByDurations[]
     */
    public $skipTimeByDurations;

    /**
     * @description 休息日或节假日排班加班时长计为调休或加班费开关
     *
     * @var bool
     */
    public $holidayPlanOvertimeRedress;

    /**
     * @description 休息日或节假日排班加班时长计为方式
     *
     * @var string
     */
    public $holidayPlanOvertimeRedressBy;

    /**
     * @description 休息日或节假日排班调休时长计算
     *
     * @var float
     */
    public $holidayPlanVacationRate;
    protected $_name = [
        'calcType'                     => 'calcType',
        'durationType'                 => 'durationType',
        'overtimeRedress'              => 'overtimeRedress',
        'settings'                     => 'settings',
        'overtimeRedressBy'            => 'overtimeRedressBy',
        'vacationRate'                 => 'vacationRate',
        'skipTime'                     => 'skipTime',
        'skipTimeByFrames'             => 'skipTimeByFrames',
        'skipTimeByDurations'          => 'skipTimeByDurations',
        'holidayPlanOvertimeRedress'   => 'holidayPlanOvertimeRedress',
        'holidayPlanOvertimeRedressBy' => 'holidayPlanOvertimeRedressBy',
        'holidayPlanVacationRate'      => 'holidayPlanVacationRate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->calcType) {
            $res['calcType'] = $this->calcType;
        }
        if (null !== $this->durationType) {
            $res['durationType'] = $this->durationType;
        }
        if (null !== $this->overtimeRedress) {
            $res['overtimeRedress'] = $this->overtimeRedress;
        }
        if (null !== $this->settings) {
            $res['settings'] = $this->settings;
        }
        if (null !== $this->overtimeRedressBy) {
            $res['overtimeRedressBy'] = $this->overtimeRedressBy;
        }
        if (null !== $this->vacationRate) {
            $res['vacationRate'] = $this->vacationRate;
        }
        if (null !== $this->skipTime) {
            $res['skipTime'] = $this->skipTime;
        }
        if (null !== $this->skipTimeByFrames) {
            $res['skipTimeByFrames'] = [];
            if (null !== $this->skipTimeByFrames && \is_array($this->skipTimeByFrames)) {
                $n = 0;
                foreach ($this->skipTimeByFrames as $item) {
                    $res['skipTimeByFrames'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->skipTimeByDurations) {
            $res['skipTimeByDurations'] = [];
            if (null !== $this->skipTimeByDurations && \is_array($this->skipTimeByDurations)) {
                $n = 0;
                foreach ($this->skipTimeByDurations as $item) {
                    $res['skipTimeByDurations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->holidayPlanOvertimeRedress) {
            $res['holidayPlanOvertimeRedress'] = $this->holidayPlanOvertimeRedress;
        }
        if (null !== $this->holidayPlanOvertimeRedressBy) {
            $res['holidayPlanOvertimeRedressBy'] = $this->holidayPlanOvertimeRedressBy;
        }
        if (null !== $this->holidayPlanVacationRate) {
            $res['holidayPlanVacationRate'] = $this->holidayPlanVacationRate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ResultDurationSettingsValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['calcType'])) {
            $model->calcType = $map['calcType'];
        }
        if (isset($map['durationType'])) {
            $model->durationType = $map['durationType'];
        }
        if (isset($map['overtimeRedress'])) {
            $model->overtimeRedress = $map['overtimeRedress'];
        }
        if (isset($map['settings'])) {
            $model->settings = $map['settings'];
        }
        if (isset($map['overtimeRedressBy'])) {
            $model->overtimeRedressBy = $map['overtimeRedressBy'];
        }
        if (isset($map['vacationRate'])) {
            $model->vacationRate = $map['vacationRate'];
        }
        if (isset($map['skipTime'])) {
            $model->skipTime = $map['skipTime'];
        }
        if (isset($map['skipTimeByFrames'])) {
            if (!empty($map['skipTimeByFrames'])) {
                $model->skipTimeByFrames = [];
                $n                       = 0;
                foreach ($map['skipTimeByFrames'] as $item) {
                    $model->skipTimeByFrames[$n++] = null !== $item ? skipTimeByFrames::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['skipTimeByDurations'])) {
            if (!empty($map['skipTimeByDurations'])) {
                $model->skipTimeByDurations = [];
                $n                          = 0;
                foreach ($map['skipTimeByDurations'] as $item) {
                    $model->skipTimeByDurations[$n++] = null !== $item ? skipTimeByDurations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['holidayPlanOvertimeRedress'])) {
            $model->holidayPlanOvertimeRedress = $map['holidayPlanOvertimeRedress'];
        }
        if (isset($map['holidayPlanOvertimeRedressBy'])) {
            $model->holidayPlanOvertimeRedressBy = $map['holidayPlanOvertimeRedressBy'];
        }
        if (isset($map['holidayPlanVacationRate'])) {
            $model->holidayPlanVacationRate = $map['holidayPlanVacationRate'];
        }

        return $model;
    }
}
