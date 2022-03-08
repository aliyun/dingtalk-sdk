<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponseBody\scheduleInformation\scheduleItems;
use AlibabaCloud\Tea\Model;

class scheduleInformation extends Model
{
    /**
     * @description 异常描述
     *
     * @var string
     */
    public $error;

    /**
     * @var scheduleItems[]
     */
    public $scheduleItems;

    /**
     * @description 用户userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'error'         => 'error',
        'scheduleItems' => 'scheduleItems',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->error) {
            $res['error'] = $this->error;
        }
        if (null !== $this->scheduleItems) {
            $res['scheduleItems'] = [];
            if (null !== $this->scheduleItems && \is_array($this->scheduleItems)) {
                $n = 0;
                foreach ($this->scheduleItems as $item) {
                    $res['scheduleItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scheduleInformation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['error'])) {
            $model->error = $map['error'];
        }
        if (isset($map['scheduleItems'])) {
            if (!empty($map['scheduleItems'])) {
                $model->scheduleItems = [];
                $n                    = 0;
                foreach ($map['scheduleItems'] as $item) {
                    $model->scheduleItems[$n++] = null !== $item ? scheduleItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
