<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;

use AlibabaCloud\Tea\Model;

class punchParam extends Model
{
    /**
     * @description 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
     *
     * @var string
     */
    public $positionId;

    /**
     * @description 地理位置名称
     *
     * @var string
     */
    public $positionName;

    /**
     * @description 地理位置类型：wifi/ble/gps
     *
     * @var string
     */
    public $positionType;

    /**
     * @description 打卡时间，单位毫秒
     *
     * @var int
     */
    public $punchTime;
    protected $_name = [
        'positionId'   => 'positionId',
        'positionName' => 'positionName',
        'positionType' => 'positionType',
        'punchTime'    => 'punchTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->positionId) {
            $res['positionId'] = $this->positionId;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->positionType) {
            $res['positionType'] = $this->positionType;
        }
        if (null !== $this->punchTime) {
            $res['punchTime'] = $this->punchTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return punchParam
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['positionId'])) {
            $model->positionId = $map['positionId'];
        }
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['positionType'])) {
            $model->positionType = $map['positionType'];
        }
        if (isset($map['punchTime'])) {
            $model->punchTime = $map['punchTime'];
        }

        return $model;
    }
}
