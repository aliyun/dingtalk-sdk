<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetTaskInfoResponseBody extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $failCount;

    /**
     * @example 2
     *
     * @var int
     */
    public $status;

    /**
     * @example 1
     *
     * @var int
     */
    public $succCount;

    /**
     * @example abcd
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 1
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'failCount' => 'failCount',
        'status' => 'status',
        'succCount' => 'succCount',
        'taskId' => 'taskId',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->succCount) {
            $res['succCount'] = $this->succCount;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['succCount'])) {
            $model->succCount = $map['succCount'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
