<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleGroupsResponseBody\result\groups\selectedClass;
use AlibabaCloud\Tea\Model;

class groups extends Model
{
    /**
     * @var string[]
     */
    public $classesList;

    /**
     * @example 111
     *
     * @var int
     */
    public $defaultClassId;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @var string[]
     */
    public $deptNameList;

    /**
     * @example false
     *
     * @var bool
     */
    public $disableCheckWhenRest;

    /**
     * @example false
     *
     * @var bool
     */
    public $disableCheckWithoutSchedule;

    /**
     * @example false
     *
     * @var bool
     */
    public $enableEmpSelectClass;

    /**
     * @example 240
     *
     * @var int
     */
    public $freeCheckDayStartMinOffset;

    /**
     * @var int[]
     */
    public $freecheckWorkDays;

    /**
     * @example 20015047
     *
     * @var int
     */
    public $groupId;

    /**
     * @example 固定排班
     *
     * @var string
     */
    public $groupName;

    /**
     * @example false
     *
     * @var bool
     */
    public $isDefault;

    /**
     * @example 1,2
     *
     * @var string[]
     */
    public $managerList;

    /**
     * @example 1
     *
     * @var int
     */
    public $memberCount;

    /**
     * @example 123
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @var selectedClass[]
     */
    public $selectedClass;

    /**
     * @example FIXED
     *
     * @var string
     */
    public $type;

    /**
     * @var string[]
     */
    public $userIds;

    /**
     * @var string[]
     */
    public $workDayList;
    protected $_name = [
        'classesList'                 => 'classesList',
        'defaultClassId'              => 'defaultClassId',
        'deptIds'                     => 'deptIds',
        'deptNameList'                => 'deptNameList',
        'disableCheckWhenRest'        => 'disableCheckWhenRest',
        'disableCheckWithoutSchedule' => 'disableCheckWithoutSchedule',
        'enableEmpSelectClass'        => 'enableEmpSelectClass',
        'freeCheckDayStartMinOffset'  => 'freeCheckDayStartMinOffset',
        'freecheckWorkDays'           => 'freecheckWorkDays',
        'groupId'                     => 'groupId',
        'groupName'                   => 'groupName',
        'isDefault'                   => 'isDefault',
        'managerList'                 => 'managerList',
        'memberCount'                 => 'memberCount',
        'ownerUserId'                 => 'ownerUserId',
        'selectedClass'               => 'selectedClass',
        'type'                        => 'type',
        'userIds'                     => 'userIds',
        'workDayList'                 => 'workDayList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classesList) {
            $res['classesList'] = $this->classesList;
        }
        if (null !== $this->defaultClassId) {
            $res['defaultClassId'] = $this->defaultClassId;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->deptNameList) {
            $res['deptNameList'] = $this->deptNameList;
        }
        if (null !== $this->disableCheckWhenRest) {
            $res['disableCheckWhenRest'] = $this->disableCheckWhenRest;
        }
        if (null !== $this->disableCheckWithoutSchedule) {
            $res['disableCheckWithoutSchedule'] = $this->disableCheckWithoutSchedule;
        }
        if (null !== $this->enableEmpSelectClass) {
            $res['enableEmpSelectClass'] = $this->enableEmpSelectClass;
        }
        if (null !== $this->freeCheckDayStartMinOffset) {
            $res['freeCheckDayStartMinOffset'] = $this->freeCheckDayStartMinOffset;
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
        if (null !== $this->isDefault) {
            $res['isDefault'] = $this->isDefault;
        }
        if (null !== $this->managerList) {
            $res['managerList'] = $this->managerList;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->selectedClass) {
            $res['selectedClass'] = [];
            if (null !== $this->selectedClass && \is_array($this->selectedClass)) {
                $n = 0;
                foreach ($this->selectedClass as $item) {
                    $res['selectedClass'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->workDayList) {
            $res['workDayList'] = $this->workDayList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groups
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classesList'])) {
            if (!empty($map['classesList'])) {
                $model->classesList = $map['classesList'];
            }
        }
        if (isset($map['defaultClassId'])) {
            $model->defaultClassId = $map['defaultClassId'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['deptNameList'])) {
            if (!empty($map['deptNameList'])) {
                $model->deptNameList = $map['deptNameList'];
            }
        }
        if (isset($map['disableCheckWhenRest'])) {
            $model->disableCheckWhenRest = $map['disableCheckWhenRest'];
        }
        if (isset($map['disableCheckWithoutSchedule'])) {
            $model->disableCheckWithoutSchedule = $map['disableCheckWithoutSchedule'];
        }
        if (isset($map['enableEmpSelectClass'])) {
            $model->enableEmpSelectClass = $map['enableEmpSelectClass'];
        }
        if (isset($map['freeCheckDayStartMinOffset'])) {
            $model->freeCheckDayStartMinOffset = $map['freeCheckDayStartMinOffset'];
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
        if (isset($map['isDefault'])) {
            $model->isDefault = $map['isDefault'];
        }
        if (isset($map['managerList'])) {
            if (!empty($map['managerList'])) {
                $model->managerList = $map['managerList'];
            }
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['selectedClass'])) {
            if (!empty($map['selectedClass'])) {
                $model->selectedClass = [];
                $n                    = 0;
                foreach ($map['selectedClass'] as $item) {
                    $model->selectedClass[$n++] = null !== $item ? selectedClass::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['workDayList'])) {
            if (!empty($map['workDayList'])) {
                $model->workDayList = $map['workDayList'];
            }
        }

        return $model;
    }
}
