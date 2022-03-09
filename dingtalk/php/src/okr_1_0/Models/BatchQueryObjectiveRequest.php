<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class BatchQueryObjectiveRequest extends Model
{
    /**
     * @var Stream[]
     */
    public $objectiveIds;

    /**
     * @description periodId
     *
     * @var Stream
     */
    public $periodId;

    /**
     * @description withAlign
     *
     * @var bool
     */
    public $withAlign;

    /**
     * @description withKr
     *
     * @var bool
     */
    public $withKr;

    /**
     * @description withProgress
     *
     * @var bool
     */
    public $withProgress;

    /**
     * @description ownerId
     *
     * @var string
     */
    public $ownerId;
    protected $_name = [
        'objectiveIds' => 'objectiveIds',
        'periodId'     => 'periodId',
        'withAlign'    => 'withAlign',
        'withKr'       => 'withKr',
        'withProgress' => 'withProgress',
        'ownerId'      => 'ownerId',
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
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
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
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }

        return $model;
    }
}
