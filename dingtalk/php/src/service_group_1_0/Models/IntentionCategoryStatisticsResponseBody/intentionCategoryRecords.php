<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionCategoryStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class intentionCategoryRecords extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $askCount;

    /**
     * @description This parameter is required.
     *
     * @example 工单类
     *
     * @var string
     */
    public $categoryName;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $dissatisfiedCount;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $errorCount;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $praiseCount;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $suggestCount;
    protected $_name = [
        'askCount' => 'askCount',
        'categoryName' => 'categoryName',
        'dissatisfiedCount' => 'dissatisfiedCount',
        'errorCount' => 'errorCount',
        'praiseCount' => 'praiseCount',
        'suggestCount' => 'suggestCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->askCount) {
            $res['askCount'] = $this->askCount;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->dissatisfiedCount) {
            $res['dissatisfiedCount'] = $this->dissatisfiedCount;
        }
        if (null !== $this->errorCount) {
            $res['errorCount'] = $this->errorCount;
        }
        if (null !== $this->praiseCount) {
            $res['praiseCount'] = $this->praiseCount;
        }
        if (null !== $this->suggestCount) {
            $res['suggestCount'] = $this->suggestCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return intentionCategoryRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['askCount'])) {
            $model->askCount = $map['askCount'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['dissatisfiedCount'])) {
            $model->dissatisfiedCount = $map['dissatisfiedCount'];
        }
        if (isset($map['errorCount'])) {
            $model->errorCount = $map['errorCount'];
        }
        if (isset($map['praiseCount'])) {
            $model->praiseCount = $map['praiseCount'];
        }
        if (isset($map['suggestCount'])) {
            $model->suggestCount = $map['suggestCount'];
        }

        return $model;
    }
}
