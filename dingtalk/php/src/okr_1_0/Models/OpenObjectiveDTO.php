<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenObjectiveDTO extends Model
{
    /**
     * @var OpenUserDTO
     */
    public $executor;

    /**
     * @var OpenKeyResultDTO[]
     */
    public $keyResults;

    /**
     * @example 65222640d0e8b868f9f9ae3c
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @var OpenPeriodDTO
     */
    public $period;

    /**
     * @example 80
     *
     * @var int
     */
    public $progress;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @var OpenTeamDTO[]
     */
    public $teams;

    /**
     * @example 这是一个O的标题
     *
     * @var string
     */
    public $title;

    /**
     * @example 10.00
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'executor' => 'executor',
        'keyResults' => 'keyResults',
        'objectiveId' => 'objectiveId',
        'period' => 'period',
        'progress' => 'progress',
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
        if (null !== $this->keyResults) {
            $res['keyResults'] = [];
            if (null !== $this->keyResults && \is_array($this->keyResults)) {
                $n = 0;
                foreach ($this->keyResults as $item) {
                    $res['keyResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->period) {
            $res['period'] = null !== $this->period ? $this->period->toMap() : null;
        }
        if (null !== $this->progress) {
            $res['progress'] = $this->progress;
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
     * @return OpenObjectiveDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executor'])) {
            $model->executor = OpenUserDTO::fromMap($map['executor']);
        }
        if (isset($map['keyResults'])) {
            if (!empty($map['keyResults'])) {
                $model->keyResults = [];
                $n = 0;
                foreach ($map['keyResults'] as $item) {
                    $model->keyResults[$n++] = null !== $item ? OpenKeyResultDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['period'])) {
            $model->period = OpenPeriodDTO::fromMap($map['period']);
        }
        if (isset($map['progress'])) {
            $model->progress = $map['progress'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teams'])) {
            if (!empty($map['teams'])) {
                $model->teams = [];
                $n = 0;
                foreach ($map['teams'] as $item) {
                    $model->teams[$n++] = null !== $item ? OpenTeamDTO::fromMap($item) : $item;
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
