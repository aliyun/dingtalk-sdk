<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAnalyzeDataDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $deptCount;

    /**
     * @description This parameter is required.
     *
     * @example 22
     *
     * @var int
     */
    public $noAlignObjectiveCount;

    /**
     * @description This parameter is required.
     *
     * @example 33
     *
     * @var int
     */
    public $noKeyActionCount;

    /**
     * @description This parameter is required.
     *
     * @example 33.2
     *
     * @var float
     */
    public $objectiveAlignRate;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $objectiveNoSetCount;

    /**
     * @description This parameter is required.
     *
     * @example 11
     *
     * @var int
     */
    public $objectiveRiskCount;

    /**
     * @description This parameter is required.
     *
     * @example 33.3
     *
     * @var float
     */
    public $objectiveSetRate;

    /**
     * @description This parameter is required.
     *
     * @example 44
     *
     * @var int
     */
    public $onlyOneKeyResultCount;

    /**
     * @description This parameter is required.
     *
     * @example 33
     *
     * @var int
     */
    public $onlyOneObjectiveCount;

    /**
     * @description This parameter is required.
     *
     * @example 22.3
     *
     * @var float
     */
    public $progressUpdateRateLast15Days;

    /**
     * @description This parameter is required.
     *
     * @example 33.11
     *
     * @var float
     */
    public $progressUpdateRateLast30Days;

    /**
     * @description This parameter is required.
     *
     * @example 33.4
     *
     * @var float
     */
    public $progressUpdateRateLast7Days;
    protected $_name = [
        'deptCount' => 'deptCount',
        'noAlignObjectiveCount' => 'noAlignObjectiveCount',
        'noKeyActionCount' => 'noKeyActionCount',
        'objectiveAlignRate' => 'objectiveAlignRate',
        'objectiveNoSetCount' => 'objectiveNoSetCount',
        'objectiveRiskCount' => 'objectiveRiskCount',
        'objectiveSetRate' => 'objectiveSetRate',
        'onlyOneKeyResultCount' => 'onlyOneKeyResultCount',
        'onlyOneObjectiveCount' => 'onlyOneObjectiveCount',
        'progressUpdateRateLast15Days' => 'progressUpdateRateLast15Days',
        'progressUpdateRateLast30Days' => 'progressUpdateRateLast30Days',
        'progressUpdateRateLast7Days' => 'progressUpdateRateLast7Days',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCount) {
            $res['deptCount'] = $this->deptCount;
        }
        if (null !== $this->noAlignObjectiveCount) {
            $res['noAlignObjectiveCount'] = $this->noAlignObjectiveCount;
        }
        if (null !== $this->noKeyActionCount) {
            $res['noKeyActionCount'] = $this->noKeyActionCount;
        }
        if (null !== $this->objectiveAlignRate) {
            $res['objectiveAlignRate'] = $this->objectiveAlignRate;
        }
        if (null !== $this->objectiveNoSetCount) {
            $res['objectiveNoSetCount'] = $this->objectiveNoSetCount;
        }
        if (null !== $this->objectiveRiskCount) {
            $res['objectiveRiskCount'] = $this->objectiveRiskCount;
        }
        if (null !== $this->objectiveSetRate) {
            $res['objectiveSetRate'] = $this->objectiveSetRate;
        }
        if (null !== $this->onlyOneKeyResultCount) {
            $res['onlyOneKeyResultCount'] = $this->onlyOneKeyResultCount;
        }
        if (null !== $this->onlyOneObjectiveCount) {
            $res['onlyOneObjectiveCount'] = $this->onlyOneObjectiveCount;
        }
        if (null !== $this->progressUpdateRateLast15Days) {
            $res['progressUpdateRateLast15Days'] = $this->progressUpdateRateLast15Days;
        }
        if (null !== $this->progressUpdateRateLast30Days) {
            $res['progressUpdateRateLast30Days'] = $this->progressUpdateRateLast30Days;
        }
        if (null !== $this->progressUpdateRateLast7Days) {
            $res['progressUpdateRateLast7Days'] = $this->progressUpdateRateLast7Days;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAnalyzeDataDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCount'])) {
            $model->deptCount = $map['deptCount'];
        }
        if (isset($map['noAlignObjectiveCount'])) {
            $model->noAlignObjectiveCount = $map['noAlignObjectiveCount'];
        }
        if (isset($map['noKeyActionCount'])) {
            $model->noKeyActionCount = $map['noKeyActionCount'];
        }
        if (isset($map['objectiveAlignRate'])) {
            $model->objectiveAlignRate = $map['objectiveAlignRate'];
        }
        if (isset($map['objectiveNoSetCount'])) {
            $model->objectiveNoSetCount = $map['objectiveNoSetCount'];
        }
        if (isset($map['objectiveRiskCount'])) {
            $model->objectiveRiskCount = $map['objectiveRiskCount'];
        }
        if (isset($map['objectiveSetRate'])) {
            $model->objectiveSetRate = $map['objectiveSetRate'];
        }
        if (isset($map['onlyOneKeyResultCount'])) {
            $model->onlyOneKeyResultCount = $map['onlyOneKeyResultCount'];
        }
        if (isset($map['onlyOneObjectiveCount'])) {
            $model->onlyOneObjectiveCount = $map['onlyOneObjectiveCount'];
        }
        if (isset($map['progressUpdateRateLast15Days'])) {
            $model->progressUpdateRateLast15Days = $map['progressUpdateRateLast15Days'];
        }
        if (isset($map['progressUpdateRateLast30Days'])) {
            $model->progressUpdateRateLast30Days = $map['progressUpdateRateLast30Days'];
        }
        if (isset($map['progressUpdateRateLast7Days'])) {
            $model->progressUpdateRateLast7Days = $map['progressUpdateRateLast7Days'];
        }

        return $model;
    }
}
