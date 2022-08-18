<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class bleDeviceList extends Model
{
    /**
     * @description 设备ID，调用查询员工智能考勤机列表获取。
     *
     * @var int
     */
    public $deviceId;
    protected $_name = [
        'deviceId' => 'deviceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bleDeviceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }

        return $model;
    }
}
