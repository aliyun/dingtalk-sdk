<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 任务标题
     *
     * @var string
     */
    public $content;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 173xxxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var customfields[]
     */
    public $customfields;

    /**
     * @example 2022-08-13T07:36:50.318Z
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
     * @example 我是一条备注
     *
     * @var string
     */
    public $note;

    /**
     * @example -10
     *
     * @var int
     */
    public $priority;

    /**
     * @example 62c25e3b376ecxxxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 62a697c053c2ef5xxxxxx
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'content' => 'content',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'customfields' => 'customfields',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'involveMembers' => 'involveMembers',
        'note' => 'note',
        'priority' => 'priority',
        'projectId' => 'projectId',
        'taskId' => 'taskId',
        'updated' => 'updated',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
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
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
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
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
