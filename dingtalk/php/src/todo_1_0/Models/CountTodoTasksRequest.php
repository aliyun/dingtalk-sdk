<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class CountTodoTasksRequest extends Model
{
    /**
     * @var int
     */
    public $fromDueTime;

    /**
     * @var bool
     */
    public $isDone;

    /**
     * @var bool
     */
    public $isRecycled;

    /**
     * @var string[][]
     */
    public $roleTypes;

    /**
     * @var int
     */
    public $toDueTime;
    protected $_name = [
        'fromDueTime' => 'fromDueTime',
        'isDone' => 'isDone',
        'isRecycled' => 'isRecycled',
        'roleTypes' => 'roleTypes',
        'toDueTime' => 'toDueTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fromDueTime) {
            $res['fromDueTime'] = $this->fromDueTime;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->isRecycled) {
            $res['isRecycled'] = $this->isRecycled;
        }
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->toDueTime) {
            $res['toDueTime'] = $this->toDueTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CountTodoTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fromDueTime'])) {
            $model->fromDueTime = $map['fromDueTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['isRecycled'])) {
            $model->isRecycled = $map['isRecycled'];
        }
        if (isset($map['roleTypes'])) {
            if (!empty($map['roleTypes'])) {
                $model->roleTypes = $map['roleTypes'];
            }
        }
        if (isset($map['toDueTime'])) {
            $model->toDueTime = $map['toDueTime'];
        }

        return $model;
    }
}
