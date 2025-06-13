<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocResponseBody\result\items\executorList;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var int
     */
    public $deadline;

    /**
     * @var bool
     */
    public $deleted;

    /**
     * @var executorList[]
     */
    public $executorList;

    /**
     * @var int
     */
    public $priority;

    /**
     * @var string
     */
    public $taskKey;

    /**
     * @var string
     */
    public $taskStatus;

    /**
     * @var string
     */
    public $taskType;

    /**
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $updateTime;
    protected $_name = [
        'createTime' => 'createTime',
        'creatorId' => 'creatorId',
        'deadline' => 'deadline',
        'deleted' => 'deleted',
        'executorList' => 'executorList',
        'priority' => 'priority',
        'taskKey' => 'taskKey',
        'taskStatus' => 'taskStatus',
        'taskType' => 'taskType',
        'title' => 'title',
        'updateTime' => 'updateTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->deadline) {
            $res['deadline'] = $this->deadline;
        }
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
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
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->taskKey) {
            $res['taskKey'] = $this->taskKey;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['deadline'])) {
            $model->deadline = $map['deadline'];
        }
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
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
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['taskKey'])) {
            $model->taskKey = $map['taskKey'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
