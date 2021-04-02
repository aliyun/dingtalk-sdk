<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeRequest\attendeesToRemove;
use AlibabaCloud\Tea\Model;

class RemoveAttendeeRequest extends Model
{
    /**
     * @var attendeesToRemove[]
     */
    public $attendeesToRemove;
    protected $_name = [
        'attendeesToRemove' => 'attendeesToRemove',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendeesToRemove) {
            $res['attendeesToRemove'] = [];
            if (null !== $this->attendeesToRemove && \is_array($this->attendeesToRemove)) {
                $n = 0;
                foreach ($this->attendeesToRemove as $item) {
                    $res['attendeesToRemove'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveAttendeeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendeesToRemove'])) {
            if (!empty($map['attendeesToRemove'])) {
                $model->attendeesToRemove = [];
                $n                        = 0;
                foreach ($map['attendeesToRemove'] as $item) {
                    $model->attendeesToRemove[$n++] = null !== $item ? attendeesToRemove::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
