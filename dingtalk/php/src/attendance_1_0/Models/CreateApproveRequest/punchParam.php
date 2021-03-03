<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;

use AlibabaCloud\Tea\Model;

class punchParam extends Model
{
    /**
     * @description 打卡时间，单位毫秒
     *
     * @var int
     */
    public $punchTime;

    /**
     * @description 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
     *
     * @var string
     */
    public $positionId;

    /**
     * @description 地理位置类型：wifi/ble/gps
     *
     * @var string
     */
    public $positionType;

    /**
     * @description 地理位置名称
     *
     * @var string
     */
    public $positionName;
    protected $_name = [
        'punchTime'    => 'punchTime',
        'positionId'   => 'positionId',
        'positionType' => 'positionType',
        'positionName' => 'positionName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->punchTime) {
            $res['punchTime'] = $this->punchTime;
        }
        if (null !== $this->positionId) {
            $res['positionId'] = $this->positionId;
        }
        if (null !== $this->positionType) {
            $res['positionType'] = $this->positionType;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
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
        if (isset($map['punchTime'])) {
            $model->punchTime = $map['punchTime'];
        }
        if (isset($map['positionId'])) {
            $model->positionId = $map['positionId'];
        }
        if (isset($map['positionType'])) {
            $model->positionType = $map['positionType'];
        }
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }

        return $model;
    }
}
