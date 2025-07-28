<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskListResponseBody\taskList;
use AlibabaCloud\Tea\Model;

class GetTaskListResponseBody extends Model
{
    /**
     * @example 2
     *
     * @var int
     */
    public $count;

    /**
     * @var taskList[]
     */
    public $taskList;
    protected $_name = [
        'count' => 'count',
        'taskList' => 'taskList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->taskList) {
            $res['taskList'] = [];
            if (null !== $this->taskList && \is_array($this->taskList)) {
                $n = 0;
                foreach ($this->taskList as $item) {
                    $res['taskList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['taskList'])) {
            if (!empty($map['taskList'])) {
                $model->taskList = [];
                $n = 0;
                foreach ($map['taskList'] as $item) {
                    $model->taskList[$n++] = null !== $item ? taskList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
