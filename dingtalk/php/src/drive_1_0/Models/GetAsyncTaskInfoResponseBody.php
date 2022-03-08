<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAsyncTaskInfoResponseBody extends Model
{
    /**
     * @description 任务开始时间
     *
     * @var string
     */
    public $beginTime;

    /**
     * @description 任务结束时间
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 失败个数
     *
     * @var int
     */
    public $failed;

    /**
     * @description 任务状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 完成个数
     *
     * @var int
     */
    public $success;

    /**
     * @description 异步任务id
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 任务总数
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'beginTime' => 'beginTime',
        'endTime'   => 'endTime',
        'failed'    => 'failed',
        'status'    => 'status',
        'success'   => 'success',
        'taskId'    => 'taskId',
        'total'     => 'total',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->beginTime) {
            $res['beginTime'] = $this->beginTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->failed) {
            $res['failed'] = $this->failed;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAsyncTaskInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['beginTime'])) {
            $model->beginTime = $map['beginTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['failed'])) {
            $model->failed = $map['failed'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
