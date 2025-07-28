<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateEvaluatePerformanceCountRequest;

use AlibabaCloud\Tea\Model;

class unreadData extends Model
{
    /**
     * @var int
     */
    public $number;

    /**
     * @var string
     */
    public $studentId;
    protected $_name = [
        'number' => 'number',
        'studentId' => 'studentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->number) {
            $res['number'] = $this->number;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unreadData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['number'])) {
            $model->number = $map['number'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }

        return $model;
    }
}
