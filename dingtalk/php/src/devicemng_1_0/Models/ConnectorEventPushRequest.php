<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConnectorEventPushRequest extends Model
{
    /**
     * @example DeviceType-xxxxxx
     *
     * @var string
     */
    public $deviceTypeUuid;

    /**
     * @example 设备关机
     *
     * @var string
     */
    public $eventName;

    /**
     * @example {"var1":"value"}
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
