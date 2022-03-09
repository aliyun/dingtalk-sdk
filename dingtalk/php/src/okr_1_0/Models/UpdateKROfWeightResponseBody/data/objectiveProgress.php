<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\UpdateKROfWeightResponseBody\data;

use AlibabaCloud\Tea\Model;

class objectiveProgress extends Model
{
    /**
     * @var int
     */
    public $percent;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'percent' => 'percent',
        'status'  => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->percent) {
            $res['percent'] = $this->percent;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return objectiveProgress
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['percent'])) {
            $model->percent = $map['percent'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
