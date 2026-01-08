<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryMsgSendRecordsResponseBody\result;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1766028831000
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @example 2569131246
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example 1766028831000
     *
     * @var int
     */
    public $sendTime;

    /**
     * @description This parameter is required.
     *
     * @example pushkxQ2b2DTDAb0qkTjNdKLmwiEiE
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 文本消息
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'createTime' => 'create_time',
        'msgType' => 'msg_type',
        'operatorUserId' => 'operator_user_id',
        'sendTime' => 'send_time',
        'taskId' => 'task_id',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['create_time'] = $this->createTime;
        }
        if (null !== $this->msgType) {
            $res['msg_type'] = $this->msgType;
        }
        if (null !== $this->operatorUserId) {
            $res['operator_user_id'] = $this->operatorUserId;
        }
        if (null !== $this->sendTime) {
            $res['send_time'] = $this->sendTime;
        }
        if (null !== $this->taskId) {
            $res['task_id'] = $this->taskId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['create_time'])) {
            $model->createTime = $map['create_time'];
        }
        if (isset($map['msg_type'])) {
            $model->msgType = $map['msg_type'];
        }
        if (isset($map['operator_user_id'])) {
            $model->operatorUserId = $map['operator_user_id'];
        }
        if (isset($map['send_time'])) {
            $model->sendTime = $map['send_time'];
        }
        if (isset($map['task_id'])) {
            $model->taskId = $map['task_id'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
