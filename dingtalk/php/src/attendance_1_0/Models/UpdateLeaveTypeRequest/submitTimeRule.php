<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\UpdateLeaveTypeRequest;

use AlibabaCloud\Tea\Model;

class submitTimeRule extends Model
{
    /**
     * @description 是否开启限时提交功能：仅且为true时开启
     *
     * @var bool
     */
    public $enableTimeLimit;

    /**
     * @description 限制类型：before-提前；after-补交
     *
     * @var string
     */
    public $timeType;

    /**
     * @description 时间单位：day-天；hour-小时
     *
     * @var string
     */
    public $timeUnit;

    /**
     * @description 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
     *
     * @var int
     */
    public $timeValue;
    protected $_name = [
        'enableTimeLimit' => 'enableTimeLimit',
        'timeType'        => 'timeType',
        'timeUnit'        => 'timeUnit',
        'timeValue'       => 'timeValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableTimeLimit) {
            $res['enableTimeLimit'] = $this->enableTimeLimit;
        }
        if (null !== $this->timeType) {
            $res['timeType'] = $this->timeType;
        }
        if (null !== $this->timeUnit) {
            $res['timeUnit'] = $this->timeUnit;
        }
        if (null !== $this->timeValue) {
            $res['timeValue'] = $this->timeValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return submitTimeRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableTimeLimit'])) {
            $model->enableTimeLimit = $map['enableTimeLimit'];
        }
        if (isset($map['timeType'])) {
            $model->timeType = $map['timeType'];
        }
        if (isset($map['timeUnit'])) {
            $model->timeUnit = $map['timeUnit'];
        }
        if (isset($map['timeValue'])) {
            $model->timeValue = $map['timeValue'];
        }

        return $model;
    }
}
