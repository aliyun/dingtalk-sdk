<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\config\end;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\config\sectionModels;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\config\start;
use AlibabaCloud\Tea\Model;

class config extends Model
{
    /**
     * @var start
     */
    public $start;

    /**
     * @var sectionModels[]
     */
    public $sectionModels;

    /**
     * @var end
     */
    public $end;
    protected $_name = [
        'start'         => 'start',
        'sectionModels' => 'sectionModels',
        'end'           => 'end',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->sectionModels) {
            $res['sectionModels'] = [];
            if (null !== $this->sectionModels && \is_array($this->sectionModels)) {
                $n = 0;
                foreach ($this->sectionModels as $item) {
                    $res['sectionModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return config
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['sectionModels'])) {
            if (!empty($map['sectionModels'])) {
                $model->sectionModels = [];
                $n                    = 0;
                foreach ($map['sectionModels'] as $item) {
                    $model->sectionModels[$n++] = null !== $item ? sectionModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }

        return $model;
    }
}
