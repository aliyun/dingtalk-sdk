<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\contentFieldList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\detailUrl;
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
     * @description 创建者id，需传用户的unionId
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
     * @description 执行者列表，需传用户的unionId
     *
     * @var string[]
     */
    public $executorIds;

    /**
     * @description 参与者列表，需传用户的unionId
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
     * @description 待办卡片类型id
     *
     * @var string
     */
    public $cardTypeId;

    /**
     * @description 待办卡片内容区表单自定义字段列表
     *
     * @var contentFieldList[]
     */
    public $contentFieldList;

    /**
     * @description 生成的待办是否仅展示在执行者的待办列表中
     *
     * @var bool
     */
    public $isOnlyShowExecutor;

    /**
     * @description 优先级
     *
     * @var int
     */
    public $priority;

    /**
     * @description 业务来源展示名称
     *
     * @var string
     */
    public $sourceTitle;

    /**
     * @description 当前操作者id，需传用户的unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'sourceId'           => 'sourceId',
        'subject'            => 'subject',
        'creatorId'          => 'creatorId',
        'description'        => 'description',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'participantIds'     => 'participantIds',
        'detailUrl'          => 'detailUrl',
        'cardTypeId'         => 'cardTypeId',
        'contentFieldList'   => 'contentFieldList',
        'isOnlyShowExecutor' => 'isOnlyShowExecutor',
        'priority'           => 'priority',
        'sourceTitle'        => 'sourceTitle',
        'operatorId'         => 'operatorId',
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
        if (null !== $this->cardTypeId) {
            $res['cardTypeId'] = $this->cardTypeId;
        }
        if (null !== $this->contentFieldList) {
            $res['contentFieldList'] = [];
            if (null !== $this->contentFieldList && \is_array($this->contentFieldList)) {
                $n = 0;
                foreach ($this->contentFieldList as $item) {
                    $res['contentFieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isOnlyShowExecutor) {
            $res['isOnlyShowExecutor'] = $this->isOnlyShowExecutor;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->sourceTitle) {
            $res['sourceTitle'] = $this->sourceTitle;
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
        if (isset($map['cardTypeId'])) {
            $model->cardTypeId = $map['cardTypeId'];
        }
        if (isset($map['contentFieldList'])) {
            if (!empty($map['contentFieldList'])) {
                $model->contentFieldList = [];
                $n                       = 0;
                foreach ($map['contentFieldList'] as $item) {
                    $model->contentFieldList[$n++] = null !== $item ? contentFieldList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isOnlyShowExecutor'])) {
            $model->isOnlyShowExecutor = $map['isOnlyShowExecutor'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['sourceTitle'])) {
            $model->sourceTitle = $map['sourceTitle'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
