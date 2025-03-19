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
     * @description This parameter is required.
     *
     * @example 62c25e3b376exxxxxx
     *
     * @var string
     */
    public $projectId;

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
    public $stageId;

    /**
     * @example 2022-06-13T07:36:50.318Z
     *
     * @var string
     */
    public $startDate;

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
        'note' => 'note',
        'parentTaskId' => 'parentTaskId',
        'priority' => 'priority',
        'projectId' => 'projectId',
        'scenariofieldconfigId' => 'scenariofieldconfigId',
        'stageId' => 'stageId',
        'startDate' => 'startDate',
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
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->parentTaskId) {
            $res['parentTaskId'] = $this->parentTaskId;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->scenariofieldconfigId) {
            $res['scenariofieldconfigId'] = $this->scenariofieldconfigId;
        }
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
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
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['parentTaskId'])) {
            $model->parentTaskId = $map['parentTaskId'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['scenariofieldconfigId'])) {
            $model->scenariofieldconfigId = $map['scenariofieldconfigId'];
        }
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
