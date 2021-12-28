<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushEventResponseBody extends Model
{
    /**
     * @description 事件ID。
     *
     * @var string
     */
    public $eventId;
    protected $_name = [
        'eventId' => 'eventId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushEventResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }

        return $model;
    }
}
