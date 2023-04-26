<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryObjectiveRequest extends Model
{
    /**
     * @var string[]
     */
    public $objectiveIds;

    /**
     * @example 10056
     *
     * @var string
     */
    public $periodId;

    /**
     * @example false
     *
     * @var bool
     */
    public $withAlign;

    /**
     * @example false
     *
     * @var bool
     */
    public $withKr;

    /**
     * @example true
     *
     * @var bool
     */
    public $withProgress;

    /**
     * @example 0115396701752283
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
