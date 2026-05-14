<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class deviceList extends Model
{
    /**
     * @var int
     */
    public $devServId;

    /**
     * @var int
     */
    public $deviceId;

    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $sn;
    protected $_name = [
        'devServId' => 'devServId',
        'deviceId' => 'deviceId',
        'deviceName' => 'deviceName',
        'sn' => 'sn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->devServId) {
            $res['devServId'] = $this->devServId;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['devServId'])) {
            $model->devServId = $map['devServId'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }

        return $model;
    }
}
