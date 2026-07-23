<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result;

use AlibabaCloud\Tea\Model;

class mixPromotionVO extends Model
{
    /**
     * @var int
     */
    public $activityId;

    /**
     * @var string
     */
    public $activityName;

    /**
     * @var string
     */
    public $activityUrl;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var mixed[]
     */
    public $extendParam;

    /**
     * @var bool
     */
    public $forbiddenCoupon;

    /**
     * @var bool
     */
    public $isSelected;

    /**
     * @var int
     */
    public $marketActivityId;

    /**
     * @var int
     */
    public $promotionId;

    /**
     * @var string
     */
    public $promotionName;

    /**
     * @var string
     */
    public $promotionType;

    /**
     * @var string
     */
    public $source;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'activityId' => 'activityId',
        'activityName' => 'activityName',
        'activityUrl' => 'activityUrl',
        'endTime' => 'endTime',
        'extendParam' => 'extendParam',
        'forbiddenCoupon' => 'forbiddenCoupon',
        'isSelected' => 'isSelected',
        'marketActivityId' => 'marketActivityId',
        'promotionId' => 'promotionId',
        'promotionName' => 'promotionName',
        'promotionType' => 'promotionType',
        'source' => 'source',
        'startTime' => 'startTime',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->activityUrl) {
            $res['activityUrl'] = $this->activityUrl;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->extendParam) {
            $res['extendParam'] = $this->extendParam;
        }
        if (null !== $this->forbiddenCoupon) {
            $res['forbiddenCoupon'] = $this->forbiddenCoupon;
        }
        if (null !== $this->isSelected) {
            $res['isSelected'] = $this->isSelected;
        }
        if (null !== $this->marketActivityId) {
            $res['marketActivityId'] = $this->marketActivityId;
        }
        if (null !== $this->promotionId) {
            $res['promotionId'] = $this->promotionId;
        }
        if (null !== $this->promotionName) {
            $res['promotionName'] = $this->promotionName;
        }
        if (null !== $this->promotionType) {
            $res['promotionType'] = $this->promotionType;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mixPromotionVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityUrl'])) {
            $model->activityUrl = $map['activityUrl'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['extendParam'])) {
            $model->extendParam = $map['extendParam'];
        }
        if (isset($map['forbiddenCoupon'])) {
            $model->forbiddenCoupon = $map['forbiddenCoupon'];
        }
        if (isset($map['isSelected'])) {
            $model->isSelected = $map['isSelected'];
        }
        if (isset($map['marketActivityId'])) {
            $model->marketActivityId = $map['marketActivityId'];
        }
        if (isset($map['promotionId'])) {
            $model->promotionId = $map['promotionId'];
        }
        if (isset($map['promotionName'])) {
            $model->promotionName = $map['promotionName'];
        }
        if (isset($map['promotionType'])) {
            $model->promotionType = $map['promotionType'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
