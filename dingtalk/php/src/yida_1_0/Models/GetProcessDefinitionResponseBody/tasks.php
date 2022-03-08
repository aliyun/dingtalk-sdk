<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\tasks\activity;
use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @description actioner
     *
     * @var string
     */
    public $actionerId;

    /**
     * @description activity
     *
     * @var activity
     */
    public $activity;

    /**
     * @description status
     *
     * @var string
     */
    public $status;

    /**
     * @description taskId
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'actionerId' => 'actionerId',
        'activity'   => 'activity',
        'status'     => 'status',
        'taskId'     => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionerId) {
            $res['actionerId'] = $this->actionerId;
        }
        if (null !== $this->activity) {
            $res['activity'] = null !== $this->activity ? $this->activity->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionerId'])) {
            $model->actionerId = $map['actionerId'];
        }
        if (isset($map['activity'])) {
            $model->activity = activity::fromMap($map['activity']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
