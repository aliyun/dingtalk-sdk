<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\freeCheckSetting\freeCheckGap;
use AlibabaCloud\Tea\Model;

class freeCheckSetting extends Model
{
    /**
     * @description 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
     *
     * 例如：540表示9:00
     * @var int
     */
    public $delimitOffsetMinutesBetweenDays;

    /**
     * @description 休息日打卡间隔设置。
     *
     * @var freeCheckGap
     */
    public $freeCheckGap;
    protected $_name = [
        'delimitOffsetMinutesBetweenDays' => 'delimitOffsetMinutesBetweenDays',
        'freeCheckGap'                    => 'freeCheckGap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delimitOffsetMinutesBetweenDays) {
            $res['delimitOffsetMinutesBetweenDays'] = $this->delimitOffsetMinutesBetweenDays;
        }
        if (null !== $this->freeCheckGap) {
            $res['freeCheckGap'] = null !== $this->freeCheckGap ? $this->freeCheckGap->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return freeCheckSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['delimitOffsetMinutesBetweenDays'])) {
            $model->delimitOffsetMinutesBetweenDays = $map['delimitOffsetMinutesBetweenDays'];
        }
        if (isset($map['freeCheckGap'])) {
            $model->freeCheckGap = freeCheckGap::fromMap($map['freeCheckGap']);
        }

        return $model;
    }
}
