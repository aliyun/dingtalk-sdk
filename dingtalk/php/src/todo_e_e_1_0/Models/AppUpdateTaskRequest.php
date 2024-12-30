<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\Tea\Model;

class AppUpdateTaskRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var bool
     */
    public $done;

    /**
     * @var int
     */
    public $dueTime;

    /**
     * @var string[]
     */
    public $executorIds;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $subject;

    /**
     * @var int
     */
    public $taskId;

    /**
     * @var string
     */
    public $toolbarTemplateKey;
    protected $_name = [
        'description'        => 'description',
        'done'               => 'done',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'operatorId'         => 'operatorId',
        'subject'            => 'subject',
        'taskId'             => 'taskId',
        'toolbarTemplateKey' => 'toolbarTemplateKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->toolbarTemplateKey) {
            $res['toolbarTemplateKey'] = $this->toolbarTemplateKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppUpdateTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['toolbarTemplateKey'])) {
            $model->toolbarTemplateKey = $map['toolbarTemplateKey'];
        }

        return $model;
    }
}
