<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreatePersonalTodoTaskRequest\notifyConfigs;
use AlibabaCloud\Tea\Model;

class CreatePersonalTodoTaskRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var int
     */
    public $dueTime;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $executorIds;

    /**
     * @var notifyConfigs
     */
    public $notifyConfigs;

    /**
     * @var string[]
     */
    public $participantIds;

    /**
     * @var int
     */
    public $reminderTimeStamp;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subject;
    protected $_name = [
        'description' => 'description',
        'dueTime' => 'dueTime',
        'executorIds' => 'executorIds',
        'notifyConfigs' => 'notifyConfigs',
        'participantIds' => 'participantIds',
        'reminderTimeStamp' => 'reminderTimeStamp',
        'subject' => 'subject',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->notifyConfigs) {
            $res['notifyConfigs'] = null !== $this->notifyConfigs ? $this->notifyConfigs->toMap() : null;
        }
        if (null !== $this->participantIds) {
            $res['participantIds'] = $this->participantIds;
        }
        if (null !== $this->reminderTimeStamp) {
            $res['reminderTimeStamp'] = $this->reminderTimeStamp;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePersonalTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['notifyConfigs'])) {
            $model->notifyConfigs = notifyConfigs::fromMap($map['notifyConfigs']);
        }
        if (isset($map['participantIds'])) {
            if (!empty($map['participantIds'])) {
                $model->participantIds = $map['participantIds'];
            }
        }
        if (isset($map['reminderTimeStamp'])) {
            $model->reminderTimeStamp = $map['reminderTimeStamp'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }

        return $model;
    }
}
