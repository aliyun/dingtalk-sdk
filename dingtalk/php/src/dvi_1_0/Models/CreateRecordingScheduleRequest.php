<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateRecordingScheduleRequest\schedules;
use AlibabaCloud\Tea\Model;

class CreateRecordingScheduleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var schedules[]
     */
    public $schedules;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sn;
    protected $_name = [
        'schedules' => 'schedules',
        'sn' => 'sn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->schedules) {
            $res['schedules'] = [];
            if (null !== $this->schedules && \is_array($this->schedules)) {
                $n = 0;
                foreach ($this->schedules as $item) {
                    $res['schedules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRecordingScheduleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['schedules'])) {
            if (!empty($map['schedules'])) {
                $model->schedules = [];
                $n = 0;
                foreach ($map['schedules'] as $item) {
                    $model->schedules[$n++] = null !== $item ? schedules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }

        return $model;
    }
}
