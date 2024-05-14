<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketRequest\notify;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketRequest\sceneContext;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketRequest\ticketMemo;
use AlibabaCloud\Tea\Model;

class ResubmitTicketRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example Dq9hP8Sk2v6vQ6l05nCe5wiEiE
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @example [{\"identifier\":\"input1\",\"value\":\"123\"}]
     *
     * @var string
     */
    public $customFields;

    /**
     * @var notify
     */
    public $notify;

    /**
     * @description This parameter is required.
     *
     * @example eKWh3GBwsKEiE
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description This parameter is required.
     *
     * @example bLkvfXKiSngQiE
     *
     * @var string
     */
    public $openTemplateBizId;

    /**
     * @description This parameter is required.
     *
     * @example iPbrfXjdNjRoiE
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $processorUnionIds;

    /**
     * @description This parameter is required.
     *
     * @example SG
     *
     * @var string
     */
    public $scene;

    /**
     * @var sceneContext
     */
    public $sceneContext;

    /**
     * @var ticketMemo
     */
    public $ticketMemo;

    /**
     * @description This parameter is required.
     *
     * @example 工单标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'creatorUnionId'    => 'creatorUnionId',
        'customFields'      => 'customFields',
        'notify'            => 'notify',
        'openTeamId'        => 'openTeamId',
        'openTemplateBizId' => 'openTemplateBizId',
        'openTicketId'      => 'openTicketId',
        'processorUnionIds' => 'processorUnionIds',
        'scene'             => 'scene',
        'sceneContext'      => 'sceneContext',
        'ticketMemo'        => 'ticketMemo',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->customFields) {
            $res['customFields'] = $this->customFields;
        }
        if (null !== $this->notify) {
            $res['notify'] = null !== $this->notify ? $this->notify->toMap() : null;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->openTemplateBizId) {
            $res['openTemplateBizId'] = $this->openTemplateBizId;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->processorUnionIds) {
            $res['processorUnionIds'] = $this->processorUnionIds;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sceneContext) {
            $res['sceneContext'] = null !== $this->sceneContext ? $this->sceneContext->toMap() : null;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ResubmitTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['customFields'])) {
            $model->customFields = $map['customFields'];
        }
        if (isset($map['notify'])) {
            $model->notify = notify::fromMap($map['notify']);
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['openTemplateBizId'])) {
            $model->openTemplateBizId = $map['openTemplateBizId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['processorUnionIds'])) {
            if (!empty($map['processorUnionIds'])) {
                $model->processorUnionIds = $map['processorUnionIds'];
            }
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sceneContext'])) {
            $model->sceneContext = sceneContext::fromMap($map['sceneContext']);
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
