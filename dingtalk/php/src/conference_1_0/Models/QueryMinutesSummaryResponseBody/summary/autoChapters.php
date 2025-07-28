<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary;

use AlibabaCloud\Tea\Model;

class autoChapters extends Model
{
    /**
     * @var int
     */
    public $end;

    /**
     * @var string
     */
    public $headline;

    /**
     * @var int
     */
    public $id;

    /**
     * @var int
     */
    public $start;

    /**
     * @var string
     */
    public $summary;
    protected $_name = [
        'end' => 'end',
        'headline' => 'headline',
        'id' => 'id',
        'start' => 'start',
        'summary' => 'summary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = $this->end;
        }
        if (null !== $this->headline) {
            $res['headline'] = $this->headline;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->start) {
            $res['start'] = $this->start;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return autoChapters
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end'])) {
            $model->end = $map['end'];
        }
        if (isset($map['headline'])) {
            $model->headline = $map['headline'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['start'])) {
            $model->start = $map['start'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }

        return $model;
    }
}
