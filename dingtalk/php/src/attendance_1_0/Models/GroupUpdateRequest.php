<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\freeCheckSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\positions;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\shiftVOList;
use AlibabaCloud\Tea\Model;

class GroupUpdateRequest extends Model
{
    /**
     * @example 123L
     *
     * @var int
     */
    public $adjustmentSettingId;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableCheckWhenRest;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableCheckWithoutSchedule;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableCameraCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableEmpSelectClass;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableFaceCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableFaceStrictMode;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableOutSideUpdateNormalCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableOutsideApply;

    /**
     * @var bool
     */
    public $enableOutsideCameraCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableOutsideCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableOutsideRemark;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableTrimDistance;

    /**
     * @example true
     *
     * @var bool
     */
    public $forbidHideOutSideAddress;

    /**
     * @var freeCheckSetting
     */
    public $freeCheckSetting;

    /**
     * @example 0
     *
     * @var int
     */
    public $freeCheckTypeId;

    /**
     * @var int
     */
    public $freecheckDayStartMinOffset;

    /**
     * @example 123
     *
     * @var int
     */
    public $groupId;

    /**
     * @example 白班考勤
     *
     * @var string
     */
    public $groupName;

    /**
     * @var string[]
     */
    public $managerList;

    /**
     * @example 500
     *
     * @var int
     */
    public $offset;

    /**
     * @var bool
     */
    public $onlyMachineCheck;

    /**
     * @var bool
     */
    public $openCameraCheck;

    /**
     * @example true
     *
     * @var bool
     */
    public $openFaceCheck;

    /**
     * @example -1
     *
     * @var int
     */
    public $outsideCheckApproveModeId;

    /**
     * @example 123L
     *
     * @var int
     */
    public $overtimeSettingId;

    /**
     * @example 123dfdf
     *
     * @var string
     */
    public $owner;

    /**
     * @var positions[]
     */
    public $positions;

    /**
     * @var mixed[]
     */
    public $resourcePermissionMap;

    /**
     * @var shiftVOList[]
     */
    public $shiftVOList;

    /**
     * @example true
     *
     * @var bool
     */
    public $skipHolidays;

    /**
     * @example 100
     *
     * @var int
     */
    public $trimDistance;

    /**
     * @var int[]
     */
    public $workdayClassList;

    /**
     * @description This parameter is required.
     *
     * @example 123dfd
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'adjustmentSettingId' => 'adjustmentSettingId',
        'disableCheckWhenRest' => 'disableCheckWhenRest',
        'disableCheckWithoutSchedule' => 'disableCheckWithoutSchedule',
        'enableCameraCheck' => 'enableCameraCheck',
        'enableEmpSelectClass' => 'enableEmpSelectClass',
        'enableFaceCheck' => 'enableFaceCheck',
        'enableFaceStrictMode' => 'enableFaceStrictMode',
        'enableOutSideUpdateNormalCheck' => 'enableOutSideUpdateNormalCheck',
        'enableOutsideApply' => 'enableOutsideApply',
        'enableOutsideCameraCheck' => 'enableOutsideCameraCheck',
        'enableOutsideCheck' => 'enableOutsideCheck',
        'enableOutsideRemark' => 'enableOutsideRemark',
        'enableTrimDistance' => 'enableTrimDistance',
        'forbidHideOutSideAddress' => 'forbidHideOutSideAddress',
        'freeCheckSetting' => 'freeCheckSetting',
        'freeCheckTypeId' => 'freeCheckTypeId',
        'freecheckDayStartMinOffset' => 'freecheckDayStartMinOffset',
        'groupId' => 'groupId',
        'groupName' => 'groupName',
        'managerList' => 'managerList',
        'offset' => 'offset',
        'onlyMachineCheck' => 'onlyMachineCheck',
        'openCameraCheck' => 'openCameraCheck',
        'openFaceCheck' => 'openFaceCheck',
        'outsideCheckApproveModeId' => 'outsideCheckApproveModeId',
        'overtimeSettingId' => 'overtimeSettingId',
        'owner' => 'owner',
        'positions' => 'positions',
        'resourcePermissionMap' => 'resourcePermissionMap',
        'shiftVOList' => 'shiftVOList',
        'skipHolidays' => 'skipHolidays',
        'trimDistance' => 'trimDistance',
        'workdayClassList' => 'workdayClassList',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adjustmentSettingId) {
            $res['adjustmentSettingId'] = $this->adjustmentSettingId;
        }
        if (null !== $this->disableCheckWhenRest) {
            $res['disableCheckWhenRest'] = $this->disableCheckWhenRest;
        }
        if (null !== $this->disableCheckWithoutSchedule) {
            $res['disableCheckWithoutSchedule'] = $this->disableCheckWithoutSchedule;
        }
        if (null !== $this->enableCameraCheck) {
            $res['enableCameraCheck'] = $this->enableCameraCheck;
        }
        if (null !== $this->enableEmpSelectClass) {
            $res['enableEmpSelectClass'] = $this->enableEmpSelectClass;
        }
        if (null !== $this->enableFaceCheck) {
            $res['enableFaceCheck'] = $this->enableFaceCheck;
        }
        if (null !== $this->enableFaceStrictMode) {
            $res['enableFaceStrictMode'] = $this->enableFaceStrictMode;
        }
        if (null !== $this->enableOutSideUpdateNormalCheck) {
            $res['enableOutSideUpdateNormalCheck'] = $this->enableOutSideUpdateNormalCheck;
        }
        if (null !== $this->enableOutsideApply) {
            $res['enableOutsideApply'] = $this->enableOutsideApply;
        }
        if (null !== $this->enableOutsideCameraCheck) {
            $res['enableOutsideCameraCheck'] = $this->enableOutsideCameraCheck;
        }
        if (null !== $this->enableOutsideCheck) {
            $res['enableOutsideCheck'] = $this->enableOutsideCheck;
        }
        if (null !== $this->enableOutsideRemark) {
            $res['enableOutsideRemark'] = $this->enableOutsideRemark;
        }
        if (null !== $this->enableTrimDistance) {
            $res['enableTrimDistance'] = $this->enableTrimDistance;
        }
        if (null !== $this->forbidHideOutSideAddress) {
            $res['forbidHideOutSideAddress'] = $this->forbidHideOutSideAddress;
        }
        if (null !== $this->freeCheckSetting) {
            $res['freeCheckSetting'] = null !== $this->freeCheckSetting ? $this->freeCheckSetting->toMap() : null;
        }
        if (null !== $this->freeCheckTypeId) {
            $res['freeCheckTypeId'] = $this->freeCheckTypeId;
        }
        if (null !== $this->freecheckDayStartMinOffset) {
            $res['freecheckDayStartMinOffset'] = $this->freecheckDayStartMinOffset;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->managerList) {
            $res['managerList'] = $this->managerList;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->onlyMachineCheck) {
            $res['onlyMachineCheck'] = $this->onlyMachineCheck;
        }
        if (null !== $this->openCameraCheck) {
            $res['openCameraCheck'] = $this->openCameraCheck;
        }
        if (null !== $this->openFaceCheck) {
            $res['openFaceCheck'] = $this->openFaceCheck;
        }
        if (null !== $this->outsideCheckApproveModeId) {
            $res['outsideCheckApproveModeId'] = $this->outsideCheckApproveModeId;
        }
        if (null !== $this->overtimeSettingId) {
            $res['overtimeSettingId'] = $this->overtimeSettingId;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->positions) {
            $res['positions'] = [];
            if (null !== $this->positions && \is_array($this->positions)) {
                $n = 0;
                foreach ($this->positions as $item) {
                    $res['positions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->resourcePermissionMap) {
            $res['resourcePermissionMap'] = $this->resourcePermissionMap;
        }
        if (null !== $this->shiftVOList) {
            $res['shiftVOList'] = [];
            if (null !== $this->shiftVOList && \is_array($this->shiftVOList)) {
                $n = 0;
                foreach ($this->shiftVOList as $item) {
                    $res['shiftVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->skipHolidays) {
            $res['skipHolidays'] = $this->skipHolidays;
        }
        if (null !== $this->trimDistance) {
            $res['trimDistance'] = $this->trimDistance;
        }
        if (null !== $this->workdayClassList) {
            $res['workdayClassList'] = $this->workdayClassList;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adjustmentSettingId'])) {
            $model->adjustmentSettingId = $map['adjustmentSettingId'];
        }
        if (isset($map['disableCheckWhenRest'])) {
            $model->disableCheckWhenRest = $map['disableCheckWhenRest'];
        }
        if (isset($map['disableCheckWithoutSchedule'])) {
            $model->disableCheckWithoutSchedule = $map['disableCheckWithoutSchedule'];
        }
        if (isset($map['enableCameraCheck'])) {
            $model->enableCameraCheck = $map['enableCameraCheck'];
        }
        if (isset($map['enableEmpSelectClass'])) {
            $model->enableEmpSelectClass = $map['enableEmpSelectClass'];
        }
        if (isset($map['enableFaceCheck'])) {
            $model->enableFaceCheck = $map['enableFaceCheck'];
        }
        if (isset($map['enableFaceStrictMode'])) {
            $model->enableFaceStrictMode = $map['enableFaceStrictMode'];
        }
        if (isset($map['enableOutSideUpdateNormalCheck'])) {
            $model->enableOutSideUpdateNormalCheck = $map['enableOutSideUpdateNormalCheck'];
        }
        if (isset($map['enableOutsideApply'])) {
            $model->enableOutsideApply = $map['enableOutsideApply'];
        }
        if (isset($map['enableOutsideCameraCheck'])) {
            $model->enableOutsideCameraCheck = $map['enableOutsideCameraCheck'];
        }
        if (isset($map['enableOutsideCheck'])) {
            $model->enableOutsideCheck = $map['enableOutsideCheck'];
        }
        if (isset($map['enableOutsideRemark'])) {
            $model->enableOutsideRemark = $map['enableOutsideRemark'];
        }
        if (isset($map['enableTrimDistance'])) {
            $model->enableTrimDistance = $map['enableTrimDistance'];
        }
        if (isset($map['forbidHideOutSideAddress'])) {
            $model->forbidHideOutSideAddress = $map['forbidHideOutSideAddress'];
        }
        if (isset($map['freeCheckSetting'])) {
            $model->freeCheckSetting = freeCheckSetting::fromMap($map['freeCheckSetting']);
        }
        if (isset($map['freeCheckTypeId'])) {
            $model->freeCheckTypeId = $map['freeCheckTypeId'];
        }
        if (isset($map['freecheckDayStartMinOffset'])) {
            $model->freecheckDayStartMinOffset = $map['freecheckDayStartMinOffset'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['managerList'])) {
            if (!empty($map['managerList'])) {
                $model->managerList = $map['managerList'];
            }
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['onlyMachineCheck'])) {
            $model->onlyMachineCheck = $map['onlyMachineCheck'];
        }
        if (isset($map['openCameraCheck'])) {
            $model->openCameraCheck = $map['openCameraCheck'];
        }
        if (isset($map['openFaceCheck'])) {
            $model->openFaceCheck = $map['openFaceCheck'];
        }
        if (isset($map['outsideCheckApproveModeId'])) {
            $model->outsideCheckApproveModeId = $map['outsideCheckApproveModeId'];
        }
        if (isset($map['overtimeSettingId'])) {
            $model->overtimeSettingId = $map['overtimeSettingId'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['positions'])) {
            if (!empty($map['positions'])) {
                $model->positions = [];
                $n = 0;
                foreach ($map['positions'] as $item) {
                    $model->positions[$n++] = null !== $item ? positions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resourcePermissionMap'])) {
            $model->resourcePermissionMap = $map['resourcePermissionMap'];
        }
        if (isset($map['shiftVOList'])) {
            if (!empty($map['shiftVOList'])) {
                $model->shiftVOList = [];
                $n = 0;
                foreach ($map['shiftVOList'] as $item) {
                    $model->shiftVOList[$n++] = null !== $item ? shiftVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['skipHolidays'])) {
            $model->skipHolidays = $map['skipHolidays'];
        }
        if (isset($map['trimDistance'])) {
            $model->trimDistance = $map['trimDistance'];
        }
        if (isset($map['workdayClassList'])) {
            if (!empty($map['workdayClassList'])) {
                $model->workdayClassList = $map['workdayClassList'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
