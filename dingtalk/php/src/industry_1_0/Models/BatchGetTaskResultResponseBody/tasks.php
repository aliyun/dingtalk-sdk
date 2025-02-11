<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result;
use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @var result
     */
    public $result;

    /**
     * @example COMPLETED
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $statusInfo;

    /**
     * @example 4beae5155406457291fcbdd76c4e8da8
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'result'     => 'result',
        'status'     => 'status',
        'statusInfo' => 'statusInfo',
        'taskId'     => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->statusInfo) {
            $res['statusInfo'] = $this->statusInfo;
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
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['statusInfo'])) {
            $model->statusInfo = $map['statusInfo'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
