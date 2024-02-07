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

    /**
     * @var bool
     */
    public $chatNotification;

    /**
     * @var bool
     */
    public $pushNotification;
    protected $_name = [
        'attendeesToAdd'   => 'attendeesToAdd',
        'chatNotification' => 'chatNotification',
        'pushNotification' => 'pushNotification',
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
        if (null !== $this->chatNotification) {
            $res['chatNotification'] = $this->chatNotification;
        }
        if (null !== $this->pushNotification) {
            $res['pushNotification'] = $this->pushNotification;
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
        if (isset($map['chatNotification'])) {
            $model->chatNotification = $map['chatNotification'];
        }
        if (isset($map['pushNotification'])) {
            $model->pushNotification = $map['pushNotification'];
        }

        return $model;
    }
}
