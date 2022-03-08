<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\recurrence;

use AlibabaCloud\Tea\Model;

class range extends Model
{
    /**
     * @var string
     */
    public $endDate;

    /**
     * @var int
     */
    public $numberOfOccurrences;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'endDate'             => 'endDate',
        'numberOfOccurrences' => 'numberOfOccurrences',
        'type'                => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->numberOfOccurrences) {
            $res['numberOfOccurrences'] = $this->numberOfOccurrences;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return range
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['numberOfOccurrences'])) {
            $model->numberOfOccurrences = $map['numberOfOccurrences'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
