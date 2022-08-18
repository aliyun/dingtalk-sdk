<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\freeCheckSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\positions;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\resourcePermissionMap;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupUpdateRequest\shiftVOList;
use AlibabaCloud\Tea\Model;

class GroupUpdateRequest extends Model
{
    /**
     * @description 补卡规则settingId。
     *
     * @var int
     */
    public $adjustmentSettingId;

    /**
     * @description 休息日打卡是否需审批：true：需要false：不需要
     *
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
     * @description 是否开启拍照打卡。true：开启false：关闭（默认值）
     *
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
     * @description 是否开启人脸检测。true：开启false：关闭（默认值）
     *
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
     * @description 是否可以外勤打卡。true：允许（默认值）false：不允许
     *
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
     * @description 休息日打卡方式。0严格打卡模式 1标准打卡模式
     *
     * @var int
     */
    public $freeCheckTypeId;

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
     * @description 子管理员权限范围。w：可管理r：可读
     *
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
     * @description 是否跳过节假日。true：跳过（默认值）false：不跳过
     *
     * @var bool
     */
    public $skipHolidays;

    /**
     * @description 地点微调范围（单位米）。
     *
     * @var int
     */
    public $trimDistance;

    /**
     * @description 周班次列表。说明固定班制必填，0表示休息。数组内的值，从左到右依次代表周日到周六，每日的排班情况。
     *
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
        'disableCheckWhenRest'           => 'disableCheckWhenRest',
        'disableCheckWithoutSchedule'    => 'disableCheckWithoutSchedule',
        'enableCameraCheck'              => 'enableCameraCheck',
        'enableEmpSelectClass'           => 'enableEmpSelectClass',
        'enableFaceCheck'                => 'enableFaceCheck',
        'enableFaceStrictMode'           => 'enableFaceStrictMode',
        'enableOutSideUpdateNormalCheck' => 'enableOutSideUpdateNormalCheck',
        'enableOutsideApply'             => 'enableOutsideApply',
        'enableOutsideCheck'             => 'enableOutsideCheck',
        'enableOutsideRemark'            => 'enableOutsideRemark',
        'enableTrimDistance'             => 'enableTrimDistance',
        'forbidHideOutSideAddress'       => 'forbidHideOutSideAddress',
        'freeCheckSetting'               => 'freeCheckSetting',
        'freeCheckTypeId'                => 'freeCheckTypeId',
        'groupId'                        => 'groupId',
        'groupName'                      => 'groupName',
        'managerList'                    => 'managerList',
        'offset'                         => 'offset',
        'openFaceCheck'                  => 'openFaceCheck',
        'outsideCheckApproveModeId'      => 'outsideCheckApproveModeId',
        'overtimeSettingId'              => 'overtimeSettingId',
        'owner'                          => 'owner',
        'positions'                      => 'positions',
        'resourcePermissionMap'          => 'resourcePermissionMap',
        'shiftVOList'                    => 'shiftVOList',
        'skipHolidays'                   => 'skipHolidays',
        'trimDistance'                   => 'trimDistance',
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
