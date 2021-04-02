<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\notifyConfigs;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\reminder;
use AlibabaCloud\Tea\Model;

class CreateTodoTaskRequest extends Model
{
    /**
     * @description 来源id，接入业务系统侧的唯一标识id
     *
     * @var string
     */
    public $sourceId;

    /**
     * @description 待办标题
     *
     * @var string
     */
    public $subject;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 待办备注描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 截止时间
     *
     * @var int
     */
    public $dueTime;

    /**
     * @description 执行者列表
     *
     * @var string[]
     */
    public $executorIds;

    /**
     * @description 参与者列表
     *
     * @var string[]
     */
    public $participantIds;

    /**
     * @description 详情页url跳转地址
     *
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @description 待办重复规则配置
     *
     * @var string
     */
    public $recurrence;

    /**
     * @description 待办提醒规则配置
     *
     * @var reminder
     */
    public $reminder;

    /**
     * @description 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
     *
     * @var notifyConfigs
     */
    public $notifyConfigs;

    /**
     * @description 当前操作者id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'sourceId'       => 'sourceId',
        'subject'        => 'subject',
        'creatorId'      => 'creatorId',
        'description'    => 'description',
        'dueTime'        => 'dueTime',
        'executorIds'    => 'executorIds',
        'participantIds' => 'participantIds',
        'detailUrl'      => 'detailUrl',
        'recurrence'     => 'recurrence',
        'reminder'       => 'reminder',
        'notifyConfigs'  => 'notifyConfigs',
        'operatorId'     => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->participantIds) {
            $res['participantIds'] = $this->participantIds;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->recurrence) {
            $res['recurrence'] = $this->recurrence;
        }
        if (null !== $this->reminder) {
            $res['reminder'] = null !== $this->reminder ? $this->reminder->toMap() : null;
        }
        if (null !== $this->notifyConfigs) {
            $res['notifyConfigs'] = null !== $this->notifyConfigs ? $this->notifyConfigs->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
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
        if (isset($map['participantIds'])) {
            if (!empty($map['participantIds'])) {
                $model->participantIds = $map['participantIds'];
            }
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['recurrence'])) {
            $model->recurrence = $map['recurrence'];
        }
        if (isset($map['reminder'])) {
            $model->reminder = reminder::fromMap($map['reminder']);
        }
        if (isset($map['notifyConfigs'])) {
            $model->notifyConfigs = notifyConfigs::fromMap($map['notifyConfigs']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
