<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskRequest\customfields;
use AlibabaCloud\Tea\Model;

class CreateTaskRequest extends Model
{
    /**
     * @description 任务标题
     *
     * @var string
     */
    public $content;

    /**
     * @description 自定义字段列表
     *
     * @var customfields[]
     */
    public $customfields;

    /**
     * @description 任务截止时间
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行者userId
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 任务备注
     *
     * @var string
     */
    public $note;

    /**
     * @description 任务优先级
     *
     * @var int
     */
    public $priority;

    /**
     * @description 项目id
     *
     * @var string
     */
    public $projectId;
    protected $_name = [
        'content'      => 'content',
        'customfields' => 'customfields',
        'dueDate'      => 'dueDate',
        'executorId'   => 'executorId',
        'note'         => 'note',
        'priority'     => 'priority',
        'projectId'    => 'projectId',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
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
                $n                   = 0;
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
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }

        return $model;
    }
}
