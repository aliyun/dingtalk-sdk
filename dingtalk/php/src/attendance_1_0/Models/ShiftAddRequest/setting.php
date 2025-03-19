<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting\lateBackSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting\topRestTimeList;
use AlibabaCloud\Tea\Model;

class setting extends Model
{
    /**
     * @example 60
     *
     * @var int
     */
    public $absenteeismLateMinutes;

    /**
     * @example 0.8
     *
     * @var float
     */
    public $attendDays;

    /**
     * @example 480
     *
     * @var int
     */
    public $demandWorkTimeMinutes;

    /**
     * @var bool
     */
    public $enableOutsideLateBack;

    /**
     * @var mixed[]
     */
    public $extras;

    /**
     * @var bool
     */
    public $isFlexible;

    /**
     * @var lateBackSetting
     */
    public $lateBackSetting;

    /**
     * @example 1234
     *
     * @var int
     */
    public $referenceClassId;

    /**
     * @example 31
     *
     * @var int
     */
    public $seriousLateMinutes;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $shiftType;

    /**
     * @example temp:schedule:isv
     *
     * @var string
     */
    public $tags;

    /**
     * @var topRestTimeList[]
     */
    public $topRestTimeList;
    protected $_name = [
        'absenteeismLateMinutes' => 'absenteeismLateMinutes',
        'attendDays' => 'attendDays',
        'demandWorkTimeMinutes' => 'demandWorkTimeMinutes',
        'enableOutsideLateBack' => 'enableOutsideLateBack',
        'extras' => 'extras',
        'isFlexible' => 'isFlexible',
        'lateBackSetting' => 'lateBackSetting',
        'referenceClassId' => 'referenceClassId',
        'seriousLateMinutes' => 'seriousLateMinutes',
        'shiftType' => 'shiftType',
        'tags' => 'tags',
        'topRestTimeList' => 'topRestTimeList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->absenteeismLateMinutes) {
            $res['absenteeismLateMinutes'] = $this->absenteeismLateMinutes;
        }
        if (null !== $this->attendDays) {
            $res['attendDays'] = $this->attendDays;
        }
        if (null !== $this->demandWorkTimeMinutes) {
            $res['demandWorkTimeMinutes'] = $this->demandWorkTimeMinutes;
        }
        if (null !== $this->enableOutsideLateBack) {
            $res['enableOutsideLateBack'] = $this->enableOutsideLateBack;
        }
        if (null !== $this->extras) {
            $res['extras'] = $this->extras;
        }
        if (null !== $this->isFlexible) {
            $res['isFlexible'] = $this->isFlexible;
        }
        if (null !== $this->lateBackSetting) {
            $res['lateBackSetting'] = null !== $this->lateBackSetting ? $this->lateBackSetting->toMap() : null;
        }
        if (null !== $this->referenceClassId) {
            $res['referenceClassId'] = $this->referenceClassId;
        }
        if (null !== $this->seriousLateMinutes) {
            $res['seriousLateMinutes'] = $this->seriousLateMinutes;
        }
        if (null !== $this->shiftType) {
            $res['shiftType'] = $this->shiftType;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }
        if (null !== $this->topRestTimeList) {
            $res['topRestTimeList'] = [];
            if (null !== $this->topRestTimeList && \is_array($this->topRestTimeList)) {
                $n = 0;
                foreach ($this->topRestTimeList as $item) {
                    $res['topRestTimeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return setting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['absenteeismLateMinutes'])) {
            $model->absenteeismLateMinutes = $map['absenteeismLateMinutes'];
        }
        if (isset($map['attendDays'])) {
            $model->attendDays = $map['attendDays'];
        }
        if (isset($map['demandWorkTimeMinutes'])) {
            $model->demandWorkTimeMinutes = $map['demandWorkTimeMinutes'];
        }
        if (isset($map['enableOutsideLateBack'])) {
            $model->enableOutsideLateBack = $map['enableOutsideLateBack'];
        }
        if (isset($map['extras'])) {
            $model->extras = $map['extras'];
        }
        if (isset($map['isFlexible'])) {
            $model->isFlexible = $map['isFlexible'];
        }
        if (isset($map['lateBackSetting'])) {
            $model->lateBackSetting = lateBackSetting::fromMap($map['lateBackSetting']);
        }
        if (isset($map['referenceClassId'])) {
            $model->referenceClassId = $map['referenceClassId'];
        }
        if (isset($map['seriousLateMinutes'])) {
            $model->seriousLateMinutes = $map['seriousLateMinutes'];
        }
        if (isset($map['shiftType'])) {
            $model->shiftType = $map['shiftType'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }
        if (isset($map['topRestTimeList'])) {
            if (!empty($map['topRestTimeList'])) {
                $model->topRestTimeList = [];
                $n = 0;
                foreach ($map['topRestTimeList'] as $item) {
                    $model->topRestTimeList[$n++] = null !== $item ? topRestTimeList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
