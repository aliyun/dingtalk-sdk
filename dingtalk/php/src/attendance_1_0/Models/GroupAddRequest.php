<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\bleDeviceList;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\freeCheckSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\members;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\positions;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\shiftVOList;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\wifis;
use AlibabaCloud\Tea\Model;

class GroupAddRequest extends Model
{
    /**
     * @example 123L
     *
     * @var int
     */
    public $adjustmentSettingId;

    /**
     * @var bleDeviceList[]
     */
    public $bleDeviceList;

    /**
     * @example true
     *
     * @var bool
     */
    public $checkNeedHealthyCode;

    /**
     * @example 1234
     *
     * @var int
     */
    public $defaultClassId;

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
    public $enableNextDay;

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
     * @example true
     *
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
     * @var bool
     */
    public $enablePositionBle;

    /**
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
     * @example 240
     *
     * @var int
     */
    public $freecheckDayStartMinOffset;

    /**
     * @var int[]
     */
    public $freecheckWorkDays;

    /**
     * @example 123
     *
     * @var int
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
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
     * @description This parameter is required.
     *
     * @var members[]
     */
    public $members;

    /**
     * @example true
     *
     * @var bool
     */
    public $modifyMember;

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
     * @example {"onDuty":{1400000:123,1400001:123},"offDuty":[1400000,1400001]}
     *
     * @var string
     */
    public $specialDays;

    /**
     * @example 100
     *
     * @var int
     */
    public $trimDistance;

    /**
     * @description This parameter is required.
     *
     * @example TURN
     *
     * @var string
     */
    public $type;

    /**
     * @var wifis[]
     */
    public $wifis;

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
        'bleDeviceList' => 'bleDeviceList',
        'checkNeedHealthyCode' => 'checkNeedHealthyCode',
        'defaultClassId' => 'defaultClassId',
        'disableCheckWhenRest' => 'disableCheckWhenRest',
        'disableCheckWithoutSchedule' => 'disableCheckWithoutSchedule',
        'enableCameraCheck' => 'enableCameraCheck',
        'enableEmpSelectClass' => 'enableEmpSelectClass',
        'enableFaceCheck' => 'enableFaceCheck',
        'enableFaceStrictMode' => 'enableFaceStrictMode',
        'enableNextDay' => 'enableNextDay',
        'enableOutSideUpdateNormalCheck' => 'enableOutSideUpdateNormalCheck',
        'enableOutsideApply' => 'enableOutsideApply',
        'enableOutsideCameraCheck' => 'enableOutsideCameraCheck',
        'enableOutsideCheck' => 'enableOutsideCheck',
        'enableOutsideRemark' => 'enableOutsideRemark',
        'enablePositionBle' => 'enablePositionBle',
        'enableTrimDistance' => 'enableTrimDistance',
        'forbidHideOutSideAddress' => 'forbidHideOutSideAddress',
        'freeCheckSetting' => 'freeCheckSetting',
        'freeCheckTypeId' => 'freeCheckTypeId',
        'freecheckDayStartMinOffset' => 'freecheckDayStartMinOffset',
        'freecheckWorkDays' => 'freecheckWorkDays',
        'groupId' => 'groupId',
        'groupName' => 'groupName',
        'managerList' => 'managerList',
        'members' => 'members',
        'modifyMember' => 'modifyMember',
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
        'specialDays' => 'specialDays',
        'trimDistance' => 'trimDistance',
        'type' => 'type',
        'wifis' => 'wifis',
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
        if (null !== $this->bleDeviceList) {
            $res['bleDeviceList'] = [];
            if (null !== $this->bleDeviceList && \is_array($this->bleDeviceList)) {
                $n = 0;
                foreach ($this->bleDeviceList as $item) {
                    $res['bleDeviceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->checkNeedHealthyCode) {
            $res['checkNeedHealthyCode'] = $this->checkNeedHealthyCode;
        }
        if (null !== $this->defaultClassId) {
            $res['defaultClassId'] = $this->defaultClassId;
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
        if (null !== $this->enableNextDay) {
            $res['enableNextDay'] = $this->enableNextDay;
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
        if (null !== $this->enablePositionBle) {
            $res['enablePositionBle'] = $this->enablePositionBle;
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
        if (null !== $this->freecheckWorkDays) {
            $res['freecheckWorkDays'] = $this->freecheckWorkDays;
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
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modifyMember) {
            $res['modifyMember'] = $this->modifyMember;
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
        if (null !== $this->specialDays) {
            $res['specialDays'] = $this->specialDays;
        }
        if (null !== $this->trimDistance) {
            $res['trimDistance'] = $this->trimDistance;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->wifis) {
            $res['wifis'] = [];
            if (null !== $this->wifis && \is_array($this->wifis)) {
                $n = 0;
                foreach ($this->wifis as $item) {
                    $res['wifis'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
     * @return GroupAddRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adjustmentSettingId'])) {
            $model->adjustmentSettingId = $map['adjustmentSettingId'];
        }
        if (isset($map['bleDeviceList'])) {
            if (!empty($map['bleDeviceList'])) {
                $model->bleDeviceList = [];
                $n = 0;
                foreach ($map['bleDeviceList'] as $item) {
                    $model->bleDeviceList[$n++] = null !== $item ? bleDeviceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['checkNeedHealthyCode'])) {
            $model->checkNeedHealthyCode = $map['checkNeedHealthyCode'];
        }
        if (isset($map['defaultClassId'])) {
            $model->defaultClassId = $map['defaultClassId'];
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
        if (isset($map['enableNextDay'])) {
            $model->enableNextDay = $map['enableNextDay'];
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
        if (isset($map['enablePositionBle'])) {
            $model->enablePositionBle = $map['enablePositionBle'];
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
        if (isset($map['freecheckWorkDays'])) {
            if (!empty($map['freecheckWorkDays'])) {
                $model->freecheckWorkDays = $map['freecheckWorkDays'];
            }
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
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modifyMember'])) {
            $model->modifyMember = $map['modifyMember'];
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
        if (isset($map['specialDays'])) {
            $model->specialDays = $map['specialDays'];
        }
        if (isset($map['trimDistance'])) {
            $model->trimDistance = $map['trimDistance'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['wifis'])) {
            if (!empty($map['wifis'])) {
                $model->wifis = [];
                $n = 0;
                foreach ($map['wifis'] as $item) {
                    $model->wifis[$n++] = null !== $item ? wifis::fromMap($item) : $item;
                }
            }
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
