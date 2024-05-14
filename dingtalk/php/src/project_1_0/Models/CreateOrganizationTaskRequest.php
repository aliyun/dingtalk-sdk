<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrganizationTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 明天12点前完成周报撰写
     *
     * @var string
     */
    public $content;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example false
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @example false
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @example 2021-08-13T07:36:50.318Z
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
     * @description This parameter is required.
     *
     * @example -10
     *
     * @var int
     */
    public $priority;

    /**
     * @description This parameter is required.
     *
     * @example members
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
