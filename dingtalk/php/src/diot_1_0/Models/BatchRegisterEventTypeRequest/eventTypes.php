<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeRequest;

use AlibabaCloud\Tea\Model;

class eventTypes extends Model
{
    /**
     * @description 事件类型(唯一)，最长20个字符。
     *
     * @var string
     */
    public $eventType;

    /**
     * @description 事件类型名称，长度4-20个字符，一个中文汉字算2个字符。
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
