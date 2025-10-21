<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceDetailResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $bindTimestamp;

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
    public $userId;
    protected $_name = [
        'bindTimestamp' => 'bindTimestamp',
        'deviceName' => 'deviceName',
        'sn' => 'sn',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindTimestamp) {
            $res['bindTimestamp'] = $this->bindTimestamp;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['bindTimestamp'])) {
            $model->bindTimestamp = $map['bindTimestamp'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
