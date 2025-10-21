<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponseBody\result\battery;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponseBody\result\firmware;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponseBody\result\recordingStartTime;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponseBody\result\status;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var battery
     */
    public $battery;

    /**
     * @var firmware
     */
    public $firmware;

    /**
     * @var recordingStartTime
     */
    public $recordingStartTime;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var status
     */
    public $status;
    protected $_name = [
        'battery' => 'battery',
        'firmware' => 'firmware',
        'recordingStartTime' => 'recordingStartTime',
        'sn' => 'sn',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->battery) {
            $res['battery'] = null !== $this->battery ? $this->battery->toMap() : null;
        }
        if (null !== $this->firmware) {
            $res['firmware'] = null !== $this->firmware ? $this->firmware->toMap() : null;
        }
        if (null !== $this->recordingStartTime) {
            $res['recordingStartTime'] = null !== $this->recordingStartTime ? $this->recordingStartTime->toMap() : null;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->status) {
            $res['status'] = null !== $this->status ? $this->status->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['battery'])) {
            $model->battery = battery::fromMap($map['battery']);
        }
        if (isset($map['firmware'])) {
            $model->firmware = firmware::fromMap($map['firmware']);
        }
        if (isset($map['recordingStartTime'])) {
            $model->recordingStartTime = recordingStartTime::fromMap($map['recordingStartTime']);
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['status'])) {
            $model->status = status::fromMap($map['status']);
        }

        return $model;
    }
}
