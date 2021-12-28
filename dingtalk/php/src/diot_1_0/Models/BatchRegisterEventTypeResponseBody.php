<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRegisterEventTypeResponseBody extends Model
{
    /**
     * @description 注册成功的事件类型列表。
     *
     * @var string[]
     */
    public $eventTypes;
    protected $_name = [
        'eventTypes' => 'eventTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventTypes) {
            $res['eventTypes'] = $this->eventTypes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRegisterEventTypeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventTypes'])) {
            if (!empty($map['eventTypes'])) {
                $model->eventTypes = $map['eventTypes'];
            }
        }

        return $model;
    }
}
