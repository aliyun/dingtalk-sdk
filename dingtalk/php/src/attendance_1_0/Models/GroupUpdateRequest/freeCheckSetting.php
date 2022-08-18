<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\freeCheckSetting\freeCheckGap;
use AlibabaCloud\Tea\Model;

class freeCheckSetting extends Model
{
    /**
     * @description 休息日打卡间隔设置。
     *
     * @var freeCheckGap
     */
    public $freeCheckGap;
    protected $_name = [
        'freeCheckGap' => 'freeCheckGap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (isset($map['freeCheckGap'])) {
            $model->freeCheckGap = freeCheckGap::fromMap($map['freeCheckGap']);
        }

        return $model;
    }
}
