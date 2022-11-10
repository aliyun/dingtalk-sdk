<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskResponseBody;

use AlibabaCloud\Tea\Model;

class task extends Model
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
     * @description 子任务失败总数
     *
     * @var int
     */
    public $failCount;

    /**
     * @description 任务失败原因
     *
     * @var string
     */
    public $failMessage;

    /**
     * @description 任务id
     *
     * @var string
     */
    public $id;

    /**
     * @description 任务状态
     * FAIL: 失败
     * @var string
     */
    public $status;

    /**
     * @description 子任务成功总数
     *
     * @var int
     */
    public $successCount;

    /**
     * @description 子任务总数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'beginTime'    => 'beginTime',
        'endTime'      => 'endTime',
        'failCount'    => 'failCount',
        'failMessage'  => 'failMessage',
        'id'           => 'id',
        'status'       => 'status',
        'successCount' => 'successCount',
        'totalCount'   => 'totalCount',
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
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->failMessage) {
            $res['failMessage'] = $this->failMessage;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->successCount) {
            $res['successCount'] = $this->successCount;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return task
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
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['failMessage'])) {
            $model->failMessage = $map['failMessage'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['successCount'])) {
            $model->successCount = $map['successCount'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
