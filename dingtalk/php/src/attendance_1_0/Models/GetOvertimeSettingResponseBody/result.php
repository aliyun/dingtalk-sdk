<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody\result\overtimeDivisions;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetOvertimeSettingResponseBody\result\warningSettings;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ResultDurationSettingsValue;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否默认
     *
     * @var bool
     */
    public $default;

    /**
     * @var ResultDurationSettingsValue[]
     */
    public $durationSettings;

    /**
     * @description 历史加班规则设置id
     *
     * @var int
     */
    public $id;

    /**
     * @description 规则名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 时间分割规则
     *
     * @var overtimeDivisions[]
     */
    public $overtimeDivisions;

    /**
     * @description 设置id
     *
     * @var int
     */
    public $settingId;

    /**
     * @description 加班时长单位
     *
     * @var int
     */
    public $stepType;

    /**
     * @description 加班时长是否取整 单位 小时
     *
     * @var float
     */
    public $stepValue;

    /**
     * @var warningSettings[]
     */
    public $warningSettings;

    /**
     * @description 日折算时长 单位：分钟
     *
     * @var int
     */
    public $workMinutesPerDay;
    protected $_name = [
        'default'           => 'default',
        'durationSettings'  => 'durationSettings',
        'id'                => 'id',
        'name'              => 'name',
        'overtimeDivisions' => 'overtimeDivisions',
        'settingId'         => 'settingId',
        'stepType'          => 'stepType',
        'stepValue'         => 'stepValue',
        'warningSettings'   => 'warningSettings',
        'workMinutesPerDay' => 'workMinutesPerDay',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->default) {
            $res['default'] = $this->default;
        }
        if (null !== $this->durationSettings) {
            $res['durationSettings'] = [];
            if (null !== $this->durationSettings && \is_array($this->durationSettings)) {
                foreach ($this->durationSettings as $key => $val) {
                    $res['durationSettings'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->overtimeDivisions) {
            $res['overtimeDivisions'] = [];
            if (null !== $this->overtimeDivisions && \is_array($this->overtimeDivisions)) {
                $n = 0;
                foreach ($this->overtimeDivisions as $item) {
                    $res['overtimeDivisions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->settingId) {
            $res['settingId'] = $this->settingId;
        }
        if (null !== $this->stepType) {
            $res['stepType'] = $this->stepType;
        }
        if (null !== $this->stepValue) {
            $res['stepValue'] = $this->stepValue;
        }
        if (null !== $this->warningSettings) {
            $res['warningSettings'] = [];
            if (null !== $this->warningSettings && \is_array($this->warningSettings)) {
                $n = 0;
                foreach ($this->warningSettings as $item) {
                    $res['warningSettings'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workMinutesPerDay) {
            $res['workMinutesPerDay'] = $this->workMinutesPerDay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['default'])) {
            $model->default = $map['default'];
        }
        if (isset($map['durationSettings'])) {
            $model->durationSettings = $map['durationSettings'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['overtimeDivisions'])) {
            if (!empty($map['overtimeDivisions'])) {
                $model->overtimeDivisions = [];
                $n                        = 0;
                foreach ($map['overtimeDivisions'] as $item) {
                    $model->overtimeDivisions[$n++] = null !== $item ? overtimeDivisions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['settingId'])) {
            $model->settingId = $map['settingId'];
        }
        if (isset($map['stepType'])) {
            $model->stepType = $map['stepType'];
        }
        if (isset($map['stepValue'])) {
            $model->stepValue = $map['stepValue'];
        }
        if (isset($map['warningSettings'])) {
            if (!empty($map['warningSettings'])) {
                $model->warningSettings = [];
                $n                      = 0;
                foreach ($map['warningSettings'] as $item) {
                    $model->warningSettings[$n++] = null !== $item ? warningSettings::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workMinutesPerDay'])) {
            $model->workMinutesPerDay = $map['workMinutesPerDay'];
        }

        return $model;
    }
}
