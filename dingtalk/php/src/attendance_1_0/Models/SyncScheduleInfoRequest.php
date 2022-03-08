<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoRequest\scheduleInfos;
use AlibabaCloud\Tea\Model;

class SyncScheduleInfoRequest extends Model
{
    /**
     * @var string
     */
    public $opUserId;

    /**
     * @var scheduleInfos[]
     */
    public $scheduleInfos;
    protected $_name = [
        'opUserId'      => 'opUserId',
        'scheduleInfos' => 'scheduleInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->scheduleInfos) {
            $res['scheduleInfos'] = [];
            if (null !== $this->scheduleInfos && \is_array($this->scheduleInfos)) {
                $n = 0;
                foreach ($this->scheduleInfos as $item) {
                    $res['scheduleInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncScheduleInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['scheduleInfos'])) {
            if (!empty($map['scheduleInfos'])) {
                $model->scheduleInfos = [];
                $n                    = 0;
                foreach ($map['scheduleInfos'] as $item) {
                    $model->scheduleInfos[$n++] = null !== $item ? scheduleInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
