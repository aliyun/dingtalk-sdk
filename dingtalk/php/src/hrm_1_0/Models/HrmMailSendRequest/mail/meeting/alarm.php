<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting;

use AlibabaCloud\Tea\Model;

class alarm extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 还有10分钟开始
     *
     * @var string
     */
    public $alarmDesc;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $alarmMinutes;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $alarmSummary;
    protected $_name = [
        'alarmDesc' => 'alarmDesc',
        'alarmMinutes' => 'alarmMinutes',
        'alarmSummary' => 'alarmSummary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->alarmDesc) {
            $res['alarmDesc'] = $this->alarmDesc;
        }
        if (null !== $this->alarmMinutes) {
            $res['alarmMinutes'] = $this->alarmMinutes;
        }
        if (null !== $this->alarmSummary) {
            $res['alarmSummary'] = $this->alarmSummary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return alarm
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alarmDesc'])) {
            $model->alarmDesc = $map['alarmDesc'];
        }
        if (isset($map['alarmMinutes'])) {
            $model->alarmMinutes = $map['alarmMinutes'];
        }
        if (isset($map['alarmSummary'])) {
            $model->alarmSummary = $map['alarmSummary'];
        }

        return $model;
    }
}
