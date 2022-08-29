<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description OA审批任务ID
     *
     * @var int
     */
    public $taskId;

    /**
     * @description OA审批任务执行人用户ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'taskId' => 'taskId',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
