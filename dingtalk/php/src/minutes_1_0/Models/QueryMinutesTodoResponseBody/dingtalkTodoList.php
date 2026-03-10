<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTodoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTodoResponseBody\dingtalkTodoList\executorList;
use AlibabaCloud\Tea\Model;

class dingtalkTodoList extends Model
{
    /**
     * @var int
     */
    public $createdTime;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $deadline;

    /**
     * @var string
     */
    public $dingtalkTodoId;

    /**
     * @var executorList[]
     */
    public $executorList;

    /**
     * @var bool
     */
    public $isDone;

    /**
     * @var string
     */
    public $minutesTodoId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'createdTime' => 'createdTime',
        'creatorUnionId' => 'creatorUnionId',
        'deadline' => 'deadline',
        'dingtalkTodoId' => 'dingtalkTodoId',
        'executorList' => 'executorList',
        'isDone' => 'isDone',
        'minutesTodoId' => 'minutesTodoId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->deadline) {
            $res['deadline'] = $this->deadline;
        }
        if (null !== $this->dingtalkTodoId) {
            $res['dingtalkTodoId'] = $this->dingtalkTodoId;
        }
        if (null !== $this->executorList) {
            $res['executorList'] = [];
            if (null !== $this->executorList && \is_array($this->executorList)) {
                $n = 0;
                foreach ($this->executorList as $item) {
                    $res['executorList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->minutesTodoId) {
            $res['minutesTodoId'] = $this->minutesTodoId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dingtalkTodoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['deadline'])) {
            $model->deadline = $map['deadline'];
        }
        if (isset($map['dingtalkTodoId'])) {
            $model->dingtalkTodoId = $map['dingtalkTodoId'];
        }
        if (isset($map['executorList'])) {
            if (!empty($map['executorList'])) {
                $model->executorList = [];
                $n = 0;
                foreach ($map['executorList'] as $item) {
                    $model->executorList[$n++] = null !== $item ? executorList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['minutesTodoId'])) {
            $model->minutesTodoId = $map['minutesTodoId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
