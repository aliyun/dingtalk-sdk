<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskResponseBody;

use AlibabaCloud\Tea\Model;

class task extends Model
{
    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $beginTime;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $endTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $failCount;

    /**
     * @example permissionDenied
     *
     * @var string
     */
    public $failMessage;

    /**
     * @example task_id
     *
     * @var string
     */
    public $id;

    /**
     * @example IN_PROGRESS
     *
     * @var string
     */
    public $status;

    /**
     * @example 3
     *
     * @var int
     */
    public $successCount;

    /**
     * @example 6
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
