<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskDueDateRequest extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $dueDate;
    protected $_name = [
        'dueDate' => 'dueDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dueDate) {
            $res['dueDate'] = $this->dueDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskDueDateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dueDate'])) {
            $model->dueDate = $map['dueDate'];
        }

        return $model;
    }
}
