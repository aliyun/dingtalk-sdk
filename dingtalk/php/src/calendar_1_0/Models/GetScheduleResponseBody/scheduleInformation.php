<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponseBody\scheduleInformation\scheduleItems;
use AlibabaCloud\Tea\Model;

class scheduleInformation extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $error;

    /**
     * @var scheduleItems[]
     */
    public $scheduleItems;
    protected $_name = [
        'userId'        => 'userId',
        'error'         => 'error',
        'scheduleItems' => 'scheduleItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
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

        return $model;
    }
}
