<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskStartdateRequest extends Model
{
    /**
     * @description 任务开始时间。
     *
     * @var string
     */
    public $startDate;
    protected $_name = [
        'startDate' => 'startDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskStartdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
