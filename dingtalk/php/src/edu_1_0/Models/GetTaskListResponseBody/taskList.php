<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskListResponseBody;

use AlibabaCloud\Tea\Model;

class taskList extends Model
{
    /**
     * @example 2023希望校区初中
     *
     * @var string
     */
    public $name;

    /**
     * @example 4240028
     *
     * @var int
     */
    public $taskId;

    /**
     * @example 2023
     *
     * @var int
     */
    public $taskYear;
    protected $_name = [
        'name'     => 'name',
        'taskId'   => 'taskId',
        'taskYear' => 'taskYear',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskYear) {
            $res['taskYear'] = $this->taskYear;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return taskList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskYear'])) {
            $model->taskYear = $map['taskYear'];
        }

        return $model;
    }
}
