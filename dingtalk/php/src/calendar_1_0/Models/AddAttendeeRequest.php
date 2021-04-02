<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeRequest\attendeesToAdd;
use AlibabaCloud\Tea\Model;

class AddAttendeeRequest extends Model
{
    /**
     * @var attendeesToAdd[]
     */
    public $attendeesToAdd;
    protected $_name = [
        'attendeesToAdd' => 'attendeesToAdd',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendeesToAdd) {
            $res['attendeesToAdd'] = [];
            if (null !== $this->attendeesToAdd && \is_array($this->attendeesToAdd)) {
                $n = 0;
                foreach ($this->attendeesToAdd as $item) {
                    $res['attendeesToAdd'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddAttendeeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendeesToAdd'])) {
            if (!empty($map['attendeesToAdd'])) {
                $model->attendeesToAdd = [];
                $n                     = 0;
                foreach ($map['attendeesToAdd'] as $item) {
                    $model->attendeesToAdd[$n++] = null !== $item ? attendeesToAdd::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
