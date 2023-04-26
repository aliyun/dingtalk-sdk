<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskPriorityRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $priority;
    protected $_name = [
        'priority' => 'priority',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskPriorityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }

        return $model;
    }
}
