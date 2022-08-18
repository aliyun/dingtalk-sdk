<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class resourcePermissionMap extends Model
{
    /**
     * @description 设置拍照打卡规则。
     *
     * @var string
     */
    public $cameraCheck;

    /**
     * @description 设置打卡方式。
     *
     * @var string
     */
    public $checkPositionType;

    /**
     * @description 设置考勤时间。
     *
     * @var string
     */
    public $checkTime;

    /**
     * @description 设置参与考勤人员。
     *
     * @var string
     */
    public $groupMember;

    /**
     * @description 设置考勤类型。
     *
     * @var string
     */
    public $groupType;

    /**
     * @description 设置外勤打卡。
     *
     * @var string
     */
    public $outSideCheck;

    /**
     * @description 设置加班规则。
     *
     * @var string
     */
    public $overTimeRule;

    /**
     * @description 员工排班。
     *
     * @var string
     */
    public $schedule;
    protected $_name = [
        'cameraCheck'       => 'cameraCheck',
        'checkPositionType' => 'checkPositionType',
        'checkTime'         => 'checkTime',
        'groupMember'       => 'groupMember',
        'groupType'         => 'groupType',
        'outSideCheck'      => 'outSideCheck',
        'overTimeRule'      => 'overTimeRule',
        'schedule'          => 'schedule',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cameraCheck) {
            $res['cameraCheck'] = $this->cameraCheck;
        }
        if (null !== $this->checkPositionType) {
            $res['checkPositionType'] = $this->checkPositionType;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->groupMember) {
            $res['groupMember'] = $this->groupMember;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->outSideCheck) {
            $res['outSideCheck'] = $this->outSideCheck;
        }
        if (null !== $this->overTimeRule) {
            $res['overTimeRule'] = $this->overTimeRule;
        }
        if (null !== $this->schedule) {
            $res['schedule'] = $this->schedule;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resourcePermissionMap
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cameraCheck'])) {
            $model->cameraCheck = $map['cameraCheck'];
        }
        if (isset($map['checkPositionType'])) {
            $model->checkPositionType = $map['checkPositionType'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['groupMember'])) {
            $model->groupMember = $map['groupMember'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['outSideCheck'])) {
            $model->outSideCheck = $map['outSideCheck'];
        }
        if (isset($map['overTimeRule'])) {
            $model->overTimeRule = $map['overTimeRule'];
        }
        if (isset($map['schedule'])) {
            $model->schedule = $map['schedule'];
        }

        return $model;
    }
}
