<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigResponseBody\result\sectionModels\end;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigResponseBody\result\sectionModels\start;
use AlibabaCloud\Tea\Model;

class sectionModels extends Model
{
    /**
     * @var end
     */
    public $end;

    /**
     * @example 1
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @example 第一节
     *
     * @var string
     */
    public $sectionName;

    /**
     * @var string
     */
    public $sectionType;

    /**
     * @var start
     */
    public $start;
    protected $_name = [
        'end'          => 'end',
        'sectionIndex' => 'sectionIndex',
        'sectionName'  => 'sectionName',
        'sectionType'  => 'sectionType',
        'start'        => 'start',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->sectionName) {
            $res['sectionName'] = $this->sectionName;
        }
        if (null !== $this->sectionType) {
            $res['sectionType'] = $this->sectionType;
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
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
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }
        if (isset($map['sectionIndex'])) {
            $model->sectionIndex = $map['sectionIndex'];
        }
        if (isset($map['sectionName'])) {
            $model->sectionName = $map['sectionName'];
        }
        if (isset($map['sectionType'])) {
            $model->sectionType = $map['sectionType'];
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }

        return $model;
    }
}
