<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateUserTaskStatusRequest;

use AlibabaCloud\Tea\Model;

class userTaskStatuses extends Model
{
    /**
     * @var bool
     */
    public $done;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'done' => 'done',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userTaskStatuses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
