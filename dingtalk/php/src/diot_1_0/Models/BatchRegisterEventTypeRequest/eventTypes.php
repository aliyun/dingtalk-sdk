<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeRequest;

use AlibabaCloud\Tea\Model;

class eventTypes extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example fireDetect
     *
     * @var string
     */
    public $eventType;

    /**
     * @description This parameter is required.
     *
     * @example 火焰告警
     *
     * @var string
     */
    public $eventTypeName;
    protected $_name = [
        'eventType'     => 'eventType',
        'eventTypeName' => 'eventTypeName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->eventTypeName) {
            $res['eventTypeName'] = $this->eventTypeName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eventTypes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['eventTypeName'])) {
            $model->eventTypeName = $map['eventTypeName'];
        }

        return $model;
    }
}
