<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrganizationTaskRequest extends Model
{
    /**
     * @description 任务标题
     *
     * @var string
     */
    public $content;

    /**
     * @description 任务创建日期
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 是否禁止动态
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @description 是否禁止通知
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @description 任务截止日期
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行者id
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 参与者id
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 任务备注
     *
     * @var string
     */
    public $note;

    /**
     * @description 优先级【-10,0,1,2】中选一个
     *
     * @var int
     */
    public $priority;

    /**
     * @description 任务可见性。involves：仅参与者可见。members:所有人可见
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'content'             => 'content',
        'createTime'          => 'createTime',
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'dueDate'             => 'dueDate',
        'executorId'          => 'executorId',
        'involveMembers'      => 'involveMembers',
        'note'                => 'note',
        'priority'            => 'priority',
        'visible'             => 'visible',
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
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->disableActivity) {
            $res['disableActivity'] = $this->disableActivity;
        }
        if (null !== $this->disableNotification) {
            $res['disableNotification'] = $this->disableNotification;
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
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrganizationTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['disableActivity'])) {
            $model->disableActivity = $map['disableActivity'];
        }
        if (isset($map['disableNotification'])) {
            $model->disableNotification = $map['disableNotification'];
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
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
