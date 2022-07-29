<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\extendData;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\groupPlugins;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\leaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest\members;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesSubCooperationTeamRequest extends Model
{
    /**
     * @description 本次操作的行为，取值： ● add：增加   -- 创建群 ● update：更新 -- 群成员变更
     *
     * @var string
     */
    public $action;

    /**
     * @description ISV的唯一标识,由BPaaS分配
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 基础数据名称。比如班组
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description 事件配置列表(启用卡片列表),所有枚举值： 任务分配提醒: TASK_ASSIGN_REMINDER 任务逾期提醒: TASK_OVERDUE_REMINDER 置顶加急任务: STICK_URGET_TASK 报工审批提醒: OUTPUT_APPROVE_REMINDER 报工审批反馈: OUTPUT_APPROVE_RESULT 班组概览 :TEAM_OVERVIEW 我的任务:MYTASK_OVERVIEW     例如： ["STICK_URGET_TASK","OUTPUT_APPROVE_REMINDER"]
     *
     * @var string[]
     */
    public $events;

    /**
     * @description 扩展字段
     *
     * @var extendData[]
     */
    public $extendData;

    /**
     * @description 群插件列表
     *
     * @var groupPlugins[]
     */
    public $groupPlugins;

    /**
     * @description 群类型，枚举
     *
     * @var string
     */
    public $groupType;

    /**
     * @description 班组长(支持多个)
     *
     * @var leaders[]
     */
    public $leaders;

    /**
     * @description 班组成员(群成员)
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 班组群名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 委外合作群所属组织
     *
     * @var string
     */
    public $outCorpId;

    /**
     * @description 关联的工序
     *
     * @var string[]
     */
    public $processIds;

    /**
     * @description 班组模型实例的唯一Id， 由业务方传递
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'       => 'action',
        'appKey'       => 'appKey',
        'baseDataName' => 'baseDataName',
        'events'       => 'events',
        'extendData'   => 'extendData',
        'groupPlugins' => 'groupPlugins',
        'groupType'    => 'groupType',
        'leaders'      => 'leaders',
        'members'      => 'members',
        'name'         => 'name',
        'outCorpId'    => 'outCorpId',
        'processIds'   => 'processIds',
        'uuid'         => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->events) {
            $res['events'] = $this->events;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = [];
            if (null !== $this->extendData && \is_array($this->extendData)) {
                $n = 0;
                foreach ($this->extendData as $item) {
                    $res['extendData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupPlugins) {
            $res['groupPlugins'] = [];
            if (null !== $this->groupPlugins && \is_array($this->groupPlugins)) {
                $n = 0;
                foreach ($this->groupPlugins as $item) {
                    $res['groupPlugins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->leaders) {
            $res['leaders'] = [];
            if (null !== $this->leaders && \is_array($this->leaders)) {
                $n = 0;
                foreach ($this->leaders as $item) {
                    $res['leaders'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outCorpId) {
            $res['outCorpId'] = $this->outCorpId;
        }
        if (null !== $this->processIds) {
            $res['processIds'] = $this->processIds;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesSubCooperationTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['events'])) {
            if (!empty($map['events'])) {
                $model->events = $map['events'];
            }
        }
        if (isset($map['extendData'])) {
            if (!empty($map['extendData'])) {
                $model->extendData = [];
                $n                 = 0;
                foreach ($map['extendData'] as $item) {
                    $model->extendData[$n++] = null !== $item ? extendData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupPlugins'])) {
            if (!empty($map['groupPlugins'])) {
                $model->groupPlugins = [];
                $n                   = 0;
                foreach ($map['groupPlugins'] as $item) {
                    $model->groupPlugins[$n++] = null !== $item ? groupPlugins::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['leaders'])) {
            if (!empty($map['leaders'])) {
                $model->leaders = [];
                $n              = 0;
                foreach ($map['leaders'] as $item) {
                    $model->leaders[$n++] = null !== $item ? leaders::fromMap($item) : $item;
                }
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outCorpId'])) {
            $model->outCorpId = $map['outCorpId'];
        }
        if (isset($map['processIds'])) {
            if (!empty($map['processIds'])) {
                $model->processIds = $map['processIds'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
