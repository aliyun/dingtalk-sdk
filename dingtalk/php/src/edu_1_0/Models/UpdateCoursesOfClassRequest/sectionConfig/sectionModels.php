<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\sectionConfig;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\sectionConfig\sectionModels\end;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\sectionConfig\sectionModels\start;
use AlibabaCloud\Tea\Model;

class sectionModels extends Model
{
    /**
     * @description 节次类型枚举：COURSE/REST
     *
     * @var string
     */
    public $sectionType;

    /**
     * @description 开始时间
     *
     * @var start
     */
    public $start;

    /**
     * @description 第几节。
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @description 结束时间
     *
     * @var end
     */
    public $end;
    protected $_name = [
        'sectionType'  => 'sectionType',
        'start'        => 'start',
        'sectionIndex' => 'sectionIndex',
        'end'          => 'end',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sectionType) {
            $res['sectionType'] = $this->sectionType;
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sectionModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sectionType'])) {
            $model->sectionType = $map['sectionType'];
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['sectionIndex'])) {
            $model->sectionIndex = $map['sectionIndex'];
        }
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }

        return $model;
    }
}
