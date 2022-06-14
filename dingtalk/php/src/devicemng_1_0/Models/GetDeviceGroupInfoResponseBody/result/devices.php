<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class devices extends Model
{
    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $deviceUuid;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'deviceCode' => 'deviceCode',
        'deviceName' => 'deviceName',
        'deviceUuid' => 'deviceUuid',
        'uuid'       => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return devices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
