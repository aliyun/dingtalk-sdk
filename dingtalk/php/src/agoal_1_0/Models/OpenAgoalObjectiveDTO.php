<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalObjectiveDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $executor;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalKeyActionDTO[]
     */
    public $keyActions;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalKeyResultDTO[]
     */
    public $keyResults;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalLatestProgressDTO
     */
    public $latestProgress;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @description This parameter is required.
     *
     * @var OpenOrgObjectiveRuleDTO
     */
    public $objectiveRule;

    /**
     * @description This parameter is required.
     *
     * @var OpenObjectiveRulePeriodDTO
     */
    public $period;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $progress;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $relatedUsers;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalTeamDTO[]
     */
    public $teams;

    /**
     * @description This parameter is required.
     *
     * @example 测试目标
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 30
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'executor' => 'executor',
        'keyActions' => 'keyActions',
        'keyResults' => 'keyResults',
        'latestProgress' => 'latestProgress',
        'objectiveId' => 'objectiveId',
        'objectiveRule' => 'objectiveRule',
        'period' => 'period',
        'progress' => 'progress',
        'relatedUsers' => 'relatedUsers',
        'status' => 'status',
        'teams' => 'teams',
        'title' => 'title',
        'weight' => 'weight',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->keyActions) {
            $res['keyActions'] = [];
            if (null !== $this->keyActions && \is_array($this->keyActions)) {
                $n = 0;
                foreach ($this->keyActions as $item) {
                    $res['keyActions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->keyResults) {
            $res['keyResults'] = [];
            if (null !== $this->keyResults && \is_array($this->keyResults)) {
                $n = 0;
                foreach ($this->keyResults as $item) {
                    $res['keyResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->latestProgress) {
            $res['latestProgress'] = null !== $this->latestProgress ? $this->latestProgress->toMap() : null;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->objectiveRule) {
            $res['objectiveRule'] = null !== $this->objectiveRule ? $this->objectiveRule->toMap() : null;
        }
        if (null !== $this->period) {
            $res['period'] = null !== $this->period ? $this->period->toMap() : null;
        }
        if (null !== $this->progress) {
            $res['progress'] = $this->progress;
        }
        if (null !== $this->relatedUsers) {
            $res['relatedUsers'] = null !== $this->relatedUsers ? $this->relatedUsers->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->teams) {
            $res['teams'] = [];
            if (null !== $this->teams && \is_array($this->teams)) {
                $n = 0;
                foreach ($this->teams as $item) {
                    $res['teams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalObjectiveDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executor'])) {
            $model->executor = OpenAgoalUserDTO::fromMap($map['executor']);
        }
        if (isset($map['keyActions'])) {
            if (!empty($map['keyActions'])) {
                $model->keyActions = [];
                $n = 0;
                foreach ($map['keyActions'] as $item) {
                    $model->keyActions[$n++] = null !== $item ? OpenAgoalKeyActionDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['keyResults'])) {
            if (!empty($map['keyResults'])) {
                $model->keyResults = [];
                $n = 0;
                foreach ($map['keyResults'] as $item) {
                    $model->keyResults[$n++] = null !== $item ? OpenAgoalKeyResultDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['latestProgress'])) {
            $model->latestProgress = OpenAgoalLatestProgressDTO::fromMap($map['latestProgress']);
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['objectiveRule'])) {
            $model->objectiveRule = OpenOrgObjectiveRuleDTO::fromMap($map['objectiveRule']);
        }
        if (isset($map['period'])) {
            $model->period = OpenObjectiveRulePeriodDTO::fromMap($map['period']);
        }
        if (isset($map['progress'])) {
            $model->progress = $map['progress'];
        }
        if (isset($map['relatedUsers'])) {
            $model->relatedUsers = OpenAgoalUserDTO::fromMap($map['relatedUsers']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teams'])) {
            if (!empty($map['teams'])) {
                $model->teams = [];
                $n = 0;
                foreach ($map['teams'] as $item) {
                    $model->teams[$n++] = null !== $item ? OpenAgoalTeamDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
