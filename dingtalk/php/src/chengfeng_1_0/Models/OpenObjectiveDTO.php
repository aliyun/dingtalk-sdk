<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenObjectiveDTO extends Model
{
    /**
     * @description 负责人信息
     *
     * @var OpenUserDTO
     */
    public $executor;

    /**
     * @description 主键
     *
     * @var string
     */
    public $id;

    /**
     * @description KR列表
     *
     * @var OpenKeyResultDTO[]
     */
    public $keyResults;

    /**
     * @description 周期信息
     *
     * @var OpenPeriodDTO
     */
    public $period;

    /**
     * @description 进度
     *
     * @var int
     */
    public $progress;

    /**
     * @description 状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 团队信息列表
     *
     * @var OpenTeamDTO[]
     */
    public $teams;

    /**
     * @description 目标标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'executor'   => 'executor',
        'id'         => 'id',
        'keyResults' => 'keyResults',
        'period'     => 'period',
        'progress'   => 'progress',
        'status'     => 'status',
        'teams'      => 'teams',
        'title'      => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['keyResults'])) {
            if (!empty($map['keyResults'])) {
                $model->keyResults = [];
                $n                 = 0;
                foreach ($map['keyResults'] as $item) {
                    $model->keyResults[$n++] = null !== $item ? OpenKeyResultDTO::fromMap($item) : $item;
                }
            }
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
                $n            = 0;
                foreach ($map['teams'] as $item) {
                    $model->teams[$n++] = null !== $item ? OpenTeamDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
