<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskRequest\customfields;
use AlibabaCloud\Tea\Model;

class CreateTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 任务标题
     *
     * @var string
     */
    public $content;

    /**
     * @var customfields[]
     */
    public $customfields;

    /**
     * @example 2022-06-13T07:36:50.318Z
     *
     * @var string
     */
    public $dueDate;

    /**
     * @example 173xxxx
     *
     * @var string
     */
    public $executorId;

    /**
     * @var string[]
     */
    public $involveMembers;

    /**
     * @example 我是一条任务备注
     *
     * @var string
     */
    public $note;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $parentTaskId;

    /**
     * @example -10
     *
     * @var int
     */
    public $priority;

    /**
     * @example 通过名称填写优先级
     *
     * @var string
     */
    public $priorityName;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 通过名称填写所属项目
     *
     * @var string
     */
    public $projectName;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $sprintId;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $stageId;

    /**
     * @example 2022-06-13T07:36:50.318Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 1
     *
     * @var string
     */
    public $storyPoint;

    /**
     * @var string[]
     */
    public $tagIds;

    /**
     * @var string[]
     */
    public $tagNames;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $taskflowstatusId;

    /**
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $tasklistId;

    /**
     * @example 通过名称填写任务状态
     *
     * @var string
     */
    public $tfsName;

    /**
     * @example members
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'content' => 'content',
        'customfields' => 'customfields',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'involveMembers' => 'involveMembers',
        'note' => 'note',
        'parentTaskId' => 'parentTaskId',
        'priority' => 'priority',
        'priorityName' => 'priorityName',
        'projectId' => 'projectId',
        'projectName' => 'projectName',
        'scenariofieldconfigId' => 'scenariofieldconfigId',
        'sprintId' => 'sprintId',
        'stageId' => 'stageId',
        'startDate' => 'startDate',
        'storyPoint' => 'storyPoint',
        'tagIds' => 'tagIds',
        'tagNames' => 'tagNames',
        'taskflowstatusId' => 'taskflowstatusId',
        'tasklistId' => 'tasklistId',
        'tfsName' => 'tfsName',
        'visible' => 'visible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->customfields) {
            $res['customfields'] = [];
            if (null !== $this->customfields && \is_array($this->customfields)) {
                $n = 0;
                foreach ($this->customfields as $item) {
                    $res['customfields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dueDate) {
            $res['dueDate'] = $this->dueDate;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->parentTaskId) {
            $res['parentTaskId'] = $this->parentTaskId;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->priorityName) {
            $res['priorityName'] = $this->priorityName;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->scenariofieldconfigId) {
            $res['scenariofieldconfigId'] = $this->scenariofieldconfigId;
        }
        if (null !== $this->sprintId) {
            $res['sprintId'] = $this->sprintId;
        }
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->storyPoint) {
            $res['storyPoint'] = $this->storyPoint;
        }
        if (null !== $this->tagIds) {
            $res['tagIds'] = $this->tagIds;
        }
        if (null !== $this->tagNames) {
            $res['tagNames'] = $this->tagNames;
        }
        if (null !== $this->taskflowstatusId) {
            $res['taskflowstatusId'] = $this->taskflowstatusId;
        }
        if (null !== $this->tasklistId) {
            $res['tasklistId'] = $this->tasklistId;
        }
        if (null !== $this->tfsName) {
            $res['tfsName'] = $this->tfsName;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['customfields'])) {
            if (!empty($map['customfields'])) {
                $model->customfields = [];
                $n = 0;
                foreach ($map['customfields'] as $item) {
                    $model->customfields[$n++] = null !== $item ? customfields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dueDate'])) {
            $model->dueDate = $map['dueDate'];
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['parentTaskId'])) {
            $model->parentTaskId = $map['parentTaskId'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['priorityName'])) {
            $model->priorityName = $map['priorityName'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['scenariofieldconfigId'])) {
            $model->scenariofieldconfigId = $map['scenariofieldconfigId'];
        }
        if (isset($map['sprintId'])) {
            $model->sprintId = $map['sprintId'];
        }
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['storyPoint'])) {
            $model->storyPoint = $map['storyPoint'];
        }
        if (isset($map['tagIds'])) {
            if (!empty($map['tagIds'])) {
                $model->tagIds = $map['tagIds'];
            }
        }
        if (isset($map['tagNames'])) {
            if (!empty($map['tagNames'])) {
                $model->tagNames = $map['tagNames'];
            }
        }
        if (isset($map['taskflowstatusId'])) {
            $model->taskflowstatusId = $map['taskflowstatusId'];
        }
        if (isset($map['tasklistId'])) {
            $model->tasklistId = $map['tasklistId'];
        }
        if (isset($map['tfsName'])) {
            $model->tfsName = $map['tfsName'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
