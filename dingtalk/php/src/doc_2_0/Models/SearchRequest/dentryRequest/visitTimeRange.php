<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest\dentryRequest;

use AlibabaCloud\Tea\Model;

class visitTimeRange extends Model
{
    /**
     * @description 结束时间戳（ms）。
     *
     * @var int
     */
    public $end;

    /**
     * @description 起始时间戳（ms）。
     *
     * @var int
     */
    public $start;
    protected $_name = [
        'end'   => 'end',
        'start' => 'start',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = $this->end;
        }
        if (null !== $this->start) {
            $res['start'] = $this->start;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visitTimeRange
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end'])) {
            $model->end = $map['end'];
        }
        if (isset($map['start'])) {
            $model->start = $map['start'];
        }

        return $model;
    }
}
