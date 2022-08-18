<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\freeCheckSetting;

use AlibabaCloud\Tea\Model;

class freeCheckGap extends Model
{
    /**
     * @description 下班打卡最小打卡间隔（单位分钟）。
     *
     * @var int
     */
    public $offOnCheckGapMinutes;

    /**
     * @description 上班打卡最小打卡间隔（单位分钟）。
     *
     * @var int
     */
    public $onOffCheckGapMinutes;
    protected $_name = [
        'offOnCheckGapMinutes' => 'offOnCheckGapMinutes',
        'onOffCheckGapMinutes' => 'onOffCheckGapMinutes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->offOnCheckGapMinutes) {
            $res['offOnCheckGapMinutes'] = $this->offOnCheckGapMinutes;
        }
        if (null !== $this->onOffCheckGapMinutes) {
            $res['onOffCheckGapMinutes'] = $this->onOffCheckGapMinutes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return freeCheckGap
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['offOnCheckGapMinutes'])) {
            $model->offOnCheckGapMinutes = $map['offOnCheckGapMinutes'];
        }
        if (isset($map['onOffCheckGapMinutes'])) {
            $model->onOffCheckGapMinutes = $map['onOffCheckGapMinutes'];
        }

        return $model;
    }
}
