<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $appStatus;

    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceName;
    protected $_name = [
        'appStatus'  => 'appStatus',
        'deviceCode' => 'deviceCode',
        'deviceName' => 'deviceName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appStatus) {
            $res['appStatus'] = $this->appStatus;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appStatus'])) {
            $model->appStatus = $map['appStatus'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }

        return $model;
    }
}
