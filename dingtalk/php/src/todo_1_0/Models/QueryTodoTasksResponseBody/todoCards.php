<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards\originalSource;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards\todoCardView;
use AlibabaCloud\Tea\Model;

class todoCards extends Model
{
    /**
     * @description 待办id
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 待办标题
     *
     * @var string
     */
    public $subject;

    /**
     * @description 待办截止时间
     *
     * @var int
     */
    public $dueTime;

    /**
     * @description 详情页链接
     *
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @description 待办卡片视图模型
     *
     * @var todoCardView
     */
    public $todoCardView;

    /**
     * @description 优先级
     *
     * @var int
     */
    public $priority;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description 更新时间
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @description 待办状态
     *
     * @var string
     */
    public $todoStatus;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 来源id
     *
     * @var string
     */
    public $sourceId;

    /**
     * @description 所属分类
     *
     * @var string
     */
    public $category;

    /**
     * @description 所属应用
     *
     * @var string
     */
    public $bizTag;

    /**
     * @description 业务来源信息
     *
     * @var originalSource
     */
    public $originalSource;

    /**
     * @description 待办完成状态
     *
     * @var bool
     */
    public $isDone;
    protected $_name = [
        'taskId'         => 'taskId',
        'subject'        => 'subject',
        'dueTime'        => 'dueTime',
        'detailUrl'      => 'detailUrl',
        'todoCardView'   => 'todoCardView',
        'priority'       => 'priority',
        'createdTime'    => 'createdTime',
        'modifiedTime'   => 'modifiedTime',
        'todoStatus'     => 'todoStatus',
        'creatorId'      => 'creatorId',
        'sourceId'       => 'sourceId',
        'category'       => 'category',
        'bizTag'         => 'bizTag',
        'originalSource' => 'originalSource',
        'isDone'         => 'isDone',
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
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->todoCardView) {
            $res['todoCardView'] = null !== $this->todoCardView ? $this->todoCardView->toMap() : null;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->todoStatus) {
            $res['todoStatus'] = $this->todoStatus;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->bizTag) {
            $res['bizTag'] = $this->bizTag;
        }
        if (null !== $this->originalSource) {
            $res['originalSource'] = null !== $this->originalSource ? $this->originalSource->toMap() : null;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return todoCards
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['todoCardView'])) {
            $model->todoCardView = todoCardView::fromMap($map['todoCardView']);
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['todoStatus'])) {
            $model->todoStatus = $map['todoStatus'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['bizTag'])) {
            $model->bizTag = $map['bizTag'];
        }
        if (isset($map['originalSource'])) {
            $model->originalSource = originalSource::fromMap($map['originalSource']);
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }

        return $model;
    }
}
