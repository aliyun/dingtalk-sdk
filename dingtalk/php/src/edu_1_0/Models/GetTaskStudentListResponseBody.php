<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskStudentListResponseBody\studentList;
use AlibabaCloud\Tea\Model;

class GetTaskStudentListResponseBody extends Model
{
    /**
     * @example 2000
     *
     * @var int
     */
    public $count;

    /**
     * @var studentList[]
     */
    public $studentList;

    /**
     * @example 4240028
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'count'       => 'count',
        'studentList' => 'studentList',
        'taskId'      => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->studentList) {
            $res['studentList'] = [];
            if (null !== $this->studentList && \is_array($this->studentList)) {
                $n = 0;
                foreach ($this->studentList as $item) {
                    $res['studentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskStudentListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['studentList'])) {
            if (!empty($map['studentList'])) {
                $model->studentList = [];
                $n                  = 0;
                foreach ($map['studentList'] as $item) {
                    $model->studentList[$n++] = null !== $item ? studentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
