<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListInspectInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 设备码
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 处理时间
     *
     * @var string
     */
    public $handleTime;

    /**
     * @description 维修人员
     *
     * @var string[]
     */
    public $maintenanceStaff;

    /**
     * @description 巡检表名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 巡检/保养内容
     *
     * @var string
     */
    public $remark;

    /**
     * @description 处理结果（1:未修复，2:已修复）
     *
     * @var int
     */
    public $repairStatus;

    /**
     * @description 巡检/保养结果：0:正常，1:异常
     *
     * @var int
     */
    public $status;

    /**
     * @description 类型（inspect：巡检，protect：保养）
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
