<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\bleDeviceList;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\freeCheckSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\members;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\positions;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\resourcePermissionMap;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\shiftVOList;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest\wifis;
use AlibabaCloud\Tea\Model;

class GroupAddRequest extends Model
{
    /**
     * @description 补卡规则settingId。
     *
     * @var int
     */
    public $adjustmentSettingId;

    /**
     * @description 蓝牙打卡相关配置信息。
     *
     * @var bleDeviceList[]
     */
    public $bleDeviceList;

    /**
     * @description 打卡是否需要健康码：
     *
     * false：关闭（默认值）
     * @var bool
     */
    public $checkNeedHealthyCode;

    /**
     * @description 默认班次ID。
     *
     * 说明 固定班制必填，可通过获取班次摘要信息接口获取
     * @var int
     */
    public $defaultClassId;

    /**
     * @description 休息日打卡是否需审批：
     *
     * false：不需要
     * @var bool
     */
    public $disableCheckWhenRest;

    /**
     * @description 未排班时是否禁止员工打卡。
     *
     * @var bool
     */
    public $disableCheckWithoutSchedule;

    /**
     * @description 是否开启拍照打卡。
     *
     * false：关闭（默认值）
     * @var bool
     */
    public $enableCameraCheck;

    /**
     * @description 未排班时是否允许员工选择班次打卡。
     *
     * @var bool
     */
    public $enableEmpSelectClass;

    /**
     * @description 是否开启人脸检测。
     *
     * false：关闭（默认值）
     * @var bool
     */
    public $enableFaceCheck;

    /**
     * @description 是否开启真人验证。
     *
     * @var bool
     */
    public $enableFaceStrictMode;

    /**
     * @description 是否第二天生效。
     * false：否
     * @var bool
     */
    public $enableNextDay;

    /**
     * @description 是否允许外勤卡更新内勤卡。
     *
     * @var bool
     */
    public $enableOutSideUpdateNormalCheck;

    /**
     * @description 外勤打卡是否需要审批。
     *
     * @var bool
     */
    public $enableOutsideApply;

    /**
     * @description 是否开启外勤打卡必须拍照。
     *
     * false：关闭（默认值）
     * @var bool
     */
    public $enableOutsideCameraCheck;

    /**
     * @description 是否可以外勤打卡。
     *
     * false：不允许
     * @var bool
     */
    public $enableOutsideCheck;

    /**
     * @description 外勤打卡是否需要拍照备注。
     *
     * @var bool
     */
    public $enableOutsideRemark;

    /**
     * @description 是否启用蓝牙定位。
     *
     * @var bool
     */
    public $enablePositionBle;

    /**
     * @description 是否允许地点微调距离。
     *
     * @var bool
     */
    public $enableTrimDistance;

    /**
     * @description 是否禁止员工隐藏详细地址。
     *
     * @var bool
     */
    public $forbidHideOutSideAddress;

    /**
     * @description 休息日打卡规则。
     *
     * @var freeCheckSetting
     */
    public $freeCheckSetting;

    /**
     * @description 休息日打卡方式。
     * 1标准打卡模式
     * @var int
     */
    public $freeCheckTypeId;

    /**
     * @description 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
     *
     * 例如：540表示9:00
     * @var int
     */
    public $freecheckDayStartMinOffset;

    /**
     * @description 自由工时考勤组工作日。
     * 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
     * @var int[]
     */
    public $freecheckWorkDays;

    /**
     * @description 考勤组ID。
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 考勤组名。
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 考勤组子管理员userid列表。
     *
     * @var string[]
     */
    public $managerList;

    /**
     * @description 考勤组成员相关设置信息。
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 是否有修改考勤组成员相关信息。
     *
     * @var bool
     */
    public $modifyMember;

    /**
     * @description 考勤范围。
     *
     * @var int
     */
    public $offset;

    /**
     * @description 是否开启人脸打卡。
     *
     * @var bool
     */
    public $openFaceCheck;

    /**
     * @description 外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批
     *
     * @var int
     */
    public $outsideCheckApproveModeId;

    /**
     * @description 加班规则settingId。
     *
     * @var int
     */
    public $overtimeSettingId;

    /**
     * @description 考勤组负责人。
     *
     * @var string
     */
    public $owner;

    /**
     * @description 考勤地点相关设置信息。
     *
     * @var positions[]
     */
    public $positions;

    /**
     * @description 子管理员权限范围。
     *
     * r：可读
     * @var resourcePermissionMap[]
     */
    public $resourcePermissionMap;

    /**
     * @description 班次相关配置信息。
     *
     * @var shiftVOList[]
     */
    public $shiftVOList;

    /**
     * @description 是否跳过节假日。
     *
     * false：不跳过
     * @var bool
     */
    public $skipHolidays;

    /**
     * @description 特殊日期配置。
     *
     * @var string
     */
    public $specialDays;

    /**
     * @description 地点微调范围（单位米）。
     *
     * @var int
     */
    public $trimDistance;

    /**
     * @description 考勤组类型：
     *
     * NONE：自由工时考勤组
     * @var string
     */
    public $type;

    /**
     * @description 考勤wifi打卡相关配置信息。
     *
     * @var wifis[]
     */
    public $wifis;

    /**
     * @description 周班次列表。
     * 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
     * @var int[]
     */
    public $workdayClassList;

    /**
     * @description 操作人的userid。
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'adjustmentSettingId'            => 'adjustmentSettingId',
        'bleDeviceList'                  => 'bleDeviceList',
        'checkNeedHealthyCode'           => 'checkNeedHealthyCode',
        'defaultClassId'                 => 'defaultClassId',
        'disableCheckWhenRest'           => 'disableCheckWhenRest',
        'disableCheckWithoutSchedule'    => 'disableCheckWithoutSchedule',
        'enableCameraCheck'              => 'enableCameraCheck',
        'enableEmpSelectClass'           => 'enableEmpSelectClass',
        'enableFaceCheck'                => 'enableFaceCheck',
        'enableFaceStrictMode'           => 'enableFaceStrictMode',
        'enableNextDay'                  => 'enableNextDay',
        'enableOutSideUpdateNormalCheck' => 'enableOutSideUpdateNormalCheck',
        'enableOutsideApply'             => 'enableOutsideApply',
        'enableOutsideCameraCheck'       => 'enableOutsideCameraCheck',
        'enableOutsideCheck'             => 'enableOutsideCheck',
        'enableOutsideRemark'            => 'enableOutsideRemark',
        'enablePositionBle'              => 'enablePositionBle',
        'enableTrimDistance'             => 'enableTrimDistance',
        'forbidHideOutSideAddress'       => 'forbidHideOutSideAddress',
        'freeCheckSetting'               => 'freeCheckSetting',
        'freeCheckTypeId'                => 'freeCheckTypeId',
        'freecheckDayStartMinOffset'     => 'freecheckDayStartMinOffset',
        'freecheckWorkDays'              => 'freecheckWorkDays',
        'groupId'                        => 'groupId',
        'groupName'                      => 'groupName',
        'managerList'                    => 'managerList',
        'members'                        => 'members',
        'modifyMember'                   => 'modifyMember',
        'offset'                         => 'offset',
        'openFaceCheck'                  => 'openFaceCheck',
        'outsideCheckApproveModeId'      => 'outsideCheckApproveModeId',
        'overtimeSettingId'              => 'overtimeSettingId',
        'owner'                          => 'owner',
        'positions'                      => 'positions',
        'resourcePermissionMap'          => 'resourcePermissionMap',
        'shiftVOList'                    => 'shiftVOList',
        'skipHolidays'                   => 'skipHolidays',
        'specialDays'                    => 'specialDays',
        'trimDistance'                   => 'trimDistance',
        'type'                           => 'type',
        'wifis'                          => 'wifis',
        'workdayClassList'               => 'workdayClassList',
        'opUserId'                       => 'opUserId',
    ];

    public function validate()
    {
    }

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
            $res['resourcePermissionMap'] = [];
            if (null !== $this->resourcePermissionMap && \is_array($this->resourcePermissionMap)) {
                $n = 0;
                foreach ($this->resourcePermissionMap as $item) {
                    $res['resourcePermissionMap'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
                $n                    = 0;
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
                $n              = 0;
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
                $n                = 0;
                foreach ($map['positions'] as $item) {
                    $model->positions[$n++] = null !== $item ? positions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resourcePermissionMap'])) {
            if (!empty($map['resourcePermissionMap'])) {
                $model->resourcePermissionMap = [];
                $n                            = 0;
                foreach ($map['resourcePermissionMap'] as $item) {
                    $model->resourcePermissionMap[$n++] = null !== $item ? resourcePermissionMap::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['shiftVOList'])) {
            if (!empty($map['shiftVOList'])) {
                $model->shiftVOList = [];
                $n                  = 0;
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
                $n            = 0;
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
