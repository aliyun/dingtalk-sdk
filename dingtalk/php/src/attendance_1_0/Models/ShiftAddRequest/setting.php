<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest;

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
     * @var mixed[]
     */
    public $extras;

    /**
     * @var bool
     */
    public $isFlexible;

    /**
     * @example 31
     *
     * @var int
     */
    public $seriousLateMinutes;

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
        'attendDays'             => 'attendDays',
        'extras'                 => 'extras',
        'isFlexible'             => 'isFlexible',
        'seriousLateMinutes'     => 'seriousLateMinutes',
        'tags'                   => 'tags',
        'topRestTimeList'        => 'topRestTimeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->absenteeismLateMinutes) {
            $res['absenteeismLateMinutes'] = $this->absenteeismLateMinutes;
        }
        if (null !== $this->attendDays) {
            $res['attendDays'] = $this->attendDays;
        }
        if (null !== $this->extras) {
            $res['extras'] = $this->extras;
        }
        if (null !== $this->isFlexible) {
            $res['isFlexible'] = $this->isFlexible;
        }
        if (null !== $this->seriousLateMinutes) {
            $res['seriousLateMinutes'] = $this->seriousLateMinutes;
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
        if (isset($map['extras'])) {
            $model->extras = $map['extras'];
        }
        if (isset($map['isFlexible'])) {
            $model->isFlexible = $map['isFlexible'];
        }
        if (isset($map['seriousLateMinutes'])) {
            $model->seriousLateMinutes = $map['seriousLateMinutes'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }
        if (isset($map['topRestTimeList'])) {
            if (!empty($map['topRestTimeList'])) {
                $model->topRestTimeList = [];
                $n                      = 0;
                foreach ($map['topRestTimeList'] as $item) {
                    $model->topRestTimeList[$n++] = null !== $item ? topRestTimeList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
