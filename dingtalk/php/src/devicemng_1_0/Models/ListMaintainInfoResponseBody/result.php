<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListMaintainInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 报修设备码
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
     * @description 报修时间
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
     * @description 报修人
     *
     * @var string[]
     */
    public $maintenanceStaff;

    /**
     * @description 处理结果，0:同意，1:拒绝，2:终止，3:删除，4:进行中
     *
     * @var int
     */
    public $processState;

    /**
     * @description 异常描述
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'deviceCode'       => 'deviceCode',
        'deviceName'       => 'deviceName',
        'gmtCreate'        => 'gmtCreate',
        'handleTime'       => 'handleTime',
        'maintenanceStaff' => 'maintenanceStaff',
        'processState'     => 'processState',
        'remark'           => 'remark',
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
        if (null !== $this->processState) {
            $res['processState'] = $this->processState;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
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
        if (isset($map['processState'])) {
            $model->processState = $map['processState'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
