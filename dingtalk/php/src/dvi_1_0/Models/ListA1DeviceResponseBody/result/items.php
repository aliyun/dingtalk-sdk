<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListA1DeviceResponseBody\result;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var int
     */
    public $bindTimestamp;

    /**
     * @var string
     */
    public $bindingStatus;

    /**
     * @var string
     */
    public $deviceModel;

    /**
     * @var string
     */
    public $deviceName;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bindTimestamp' => 'bindTimestamp',
        'bindingStatus' => 'bindingStatus',
        'deviceModel' => 'deviceModel',
        'deviceName' => 'deviceName',
        'sn' => 'sn',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindTimestamp) {
            $res['bindTimestamp'] = $this->bindTimestamp;
        }
        if (null !== $this->bindingStatus) {
            $res['bindingStatus'] = $this->bindingStatus;
        }
        if (null !== $this->deviceModel) {
            $res['deviceModel'] = $this->deviceModel;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindTimestamp'])) {
            $model->bindTimestamp = $map['bindTimestamp'];
        }
        if (isset($map['bindingStatus'])) {
            $model->bindingStatus = $map['bindingStatus'];
        }
        if (isset($map['deviceModel'])) {
            $model->deviceModel = $map['deviceModel'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
