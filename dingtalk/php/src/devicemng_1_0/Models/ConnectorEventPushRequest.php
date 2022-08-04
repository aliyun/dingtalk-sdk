<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConnectorEventPushRequest extends Model
{
    /**
     * @description 设备类型唯一标识
     *
     * @var string
     */
    public $deviceTypeUuid;

    /**
     * @description 事件名称
     *
     * @var string
     */
    public $eventName;

    /**
     * @description 事件入参，json字符串
     *
     * @var string
     */
    public $input;
    protected $_name = [
        'deviceTypeUuid' => 'deviceTypeUuid',
        'eventName'      => 'eventName',
        'input'          => 'input',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceTypeUuid) {
            $res['deviceTypeUuid'] = $this->deviceTypeUuid;
        }
        if (null !== $this->eventName) {
            $res['eventName'] = $this->eventName;
        }
        if (null !== $this->input) {
            $res['input'] = $this->input;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConnectorEventPushRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceTypeUuid'])) {
            $model->deviceTypeUuid = $map['deviceTypeUuid'];
        }
        if (isset($map['eventName'])) {
            $model->eventName = $map['eventName'];
        }
        if (isset($map['input'])) {
            $model->input = $map['input'];
        }

        return $model;
    }
}
