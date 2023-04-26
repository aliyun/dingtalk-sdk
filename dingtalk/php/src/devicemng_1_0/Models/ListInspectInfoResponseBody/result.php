<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListInspectInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example testDeviceCode
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @example 测试设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 2022-09-10 12:00
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2022-09-10 12:00
     *
     * @var string
     */
    public $handleTime;

    /**
     * @var string[]
     */
    public $maintenanceStaff;

    /**
     * @example 巡检表F
     *
     * @var string
     */
    public $name;

    /**
     * @example 巡检项1：高度（正常)
     *
     * @var string
     */
    public $remark;

    /**
     * @example 1
     *
     * @var int
     */
    public $repairStatus;

    /**
     * @var int
     */
    public $status;

    /**
     * @example inspect
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'deviceCode'       => 'deviceCode',
        'deviceName'       => 'deviceName',
        'gmtCreate'        => 'gmtCreate',
        'handleTime'       => 'handleTime',
        'maintenanceStaff' => 'maintenanceStaff',
        'name'             => 'name',
        'remark'           => 'remark',
        'repairStatus'     => 'repairStatus',
        'status'           => 'status',
        'type'             => 'type',
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
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->handleTime) {
            $res['handleTime'] = $this->handleTime;
        }
        if (null !== $this->maintenanceStaff) {
            $res['maintenanceStaff'] = $this->maintenanceStaff;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->repairStatus) {
            $res['repairStatus'] = $this->repairStatus;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['handleTime'])) {
            $model->handleTime = $map['handleTime'];
        }
        if (isset($map['maintenanceStaff'])) {
            if (!empty($map['maintenanceStaff'])) {
                $model->maintenanceStaff = $map['maintenanceStaff'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['repairStatus'])) {
            $model->repairStatus = $map['repairStatus'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
