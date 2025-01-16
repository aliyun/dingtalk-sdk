<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalOrgObjectiveDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalObjectiveDimensionDTO
     */
    public $dimension;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalAlignDTO[]
     */
    public $downAlignObjects;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $executor;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalFieldMetaDTO[]
     */
    public $fieldConfig;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $fieldValueMap;

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
     * @var OpenObjectiveRulePeriodDTO
     */
    public $period;

    /**
     * @description This parameter is required.
     *
     * @example formalEffective
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalTeamDTO
     */
    public $team;

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
     * @var OpenAgoalAlignDTO[]
     */
    public $upAlignObjects;
    protected $_name = [
        'dimension'        => 'dimension',
        'downAlignObjects' => 'downAlignObjects',
        'executor'         => 'executor',
        'fieldConfig'      => 'fieldConfig',
        'fieldValueMap'    => 'fieldValueMap',
        'objectiveId'      => 'objectiveId',
        'period'           => 'period',
        'status'           => 'status',
        'team'             => 'team',
        'title'            => 'title',
        'upAlignObjects'   => 'upAlignObjects',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dimension) {
            $res['dimension'] = null !== $this->dimension ? $this->dimension->toMap() : null;
        }
        if (null !== $this->downAlignObjects) {
            $res['downAlignObjects'] = [];
            if (null !== $this->downAlignObjects && \is_array($this->downAlignObjects)) {
                $n = 0;
                foreach ($this->downAlignObjects as $item) {
                    $res['downAlignObjects'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->fieldConfig) {
            $res['fieldConfig'] = [];
            if (null !== $this->fieldConfig && \is_array($this->fieldConfig)) {
                $n = 0;
                foreach ($this->fieldConfig as $item) {
                    $res['fieldConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->fieldValueMap) {
            $res['fieldValueMap'] = $this->fieldValueMap;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->period) {
            $res['period'] = null !== $this->period ? $this->period->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->team) {
            $res['team'] = null !== $this->team ? $this->team->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->upAlignObjects) {
            $res['upAlignObjects'] = [];
            if (null !== $this->upAlignObjects && \is_array($this->upAlignObjects)) {
                $n = 0;
                foreach ($this->upAlignObjects as $item) {
                    $res['upAlignObjects'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalOrgObjectiveDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dimension'])) {
            $model->dimension = OpenAgoalObjectiveDimensionDTO::fromMap($map['dimension']);
        }
        if (isset($map['downAlignObjects'])) {
            if (!empty($map['downAlignObjects'])) {
                $model->downAlignObjects = [];
                $n                       = 0;
                foreach ($map['downAlignObjects'] as $item) {
                    $model->downAlignObjects[$n++] = null !== $item ? OpenAgoalAlignDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['executor'])) {
            $model->executor = OpenAgoalUserDTO::fromMap($map['executor']);
        }
        if (isset($map['fieldConfig'])) {
            if (!empty($map['fieldConfig'])) {
                $model->fieldConfig = [];
                $n                  = 0;
                foreach ($map['fieldConfig'] as $item) {
                    $model->fieldConfig[$n++] = null !== $item ? OpenAgoalFieldMetaDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['fieldValueMap'])) {
            $model->fieldValueMap = $map['fieldValueMap'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['period'])) {
            $model->period = OpenObjectiveRulePeriodDTO::fromMap($map['period']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['team'])) {
            $model->team = OpenAgoalTeamDTO::fromMap($map['team']);
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['upAlignObjects'])) {
            if (!empty($map['upAlignObjects'])) {
                $model->upAlignObjects = [];
                $n                     = 0;
                foreach ($map['upAlignObjects'] as $item) {
                    $model->upAlignObjects[$n++] = null !== $item ? OpenAgoalAlignDTO::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
