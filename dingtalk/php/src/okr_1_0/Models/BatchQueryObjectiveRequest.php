<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryObjectiveRequest extends Model
{
    /**
     * @description 需要查看的 Objective ID。
     *
     * @var string[]
     */
    public $objectiveIds;

    /**
     * @description 周期 ID。
     *
     * @var string
     */
    public $periodId;

    /**
     * @description 是否返回关联信息。
     *
     * @var bool
     */
    public $withAlign;

    /**
     * @description 是否返回 KR 信息。
     *
     * @var bool
     */
    public $withKr;

    /**
     * @description 是否返回进度信息
     *
     * @var bool
     */
    public $withProgress;

    /**
     * @description 当前用户的 staff ID。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'objectiveIds' => 'objectiveIds',
        'periodId'     => 'periodId',
        'withAlign'    => 'withAlign',
        'withKr'       => 'withKr',
        'withProgress' => 'withProgress',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveIds) {
            $res['objectiveIds'] = $this->objectiveIds;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->withAlign) {
            $res['withAlign'] = $this->withAlign;
        }
        if (null !== $this->withKr) {
            $res['withKr'] = $this->withKr;
        }
        if (null !== $this->withProgress) {
            $res['withProgress'] = $this->withProgress;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryObjectiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveIds'])) {
            if (!empty($map['objectiveIds'])) {
                $model->objectiveIds = $map['objectiveIds'];
            }
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['withAlign'])) {
            $model->withAlign = $map['withAlign'];
        }
        if (isset($map['withKr'])) {
            $model->withKr = $map['withKr'];
        }
        if (isset($map['withProgress'])) {
            $model->withProgress = $map['withProgress'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
