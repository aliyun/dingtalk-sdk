<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest\notify;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest\sceneContext;
use AlibabaCloud\Tea\Model;

class CreateTicketRequest extends Model
{
    /**
     * @description 工单创建人UnionId
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @description 自定义组件字段值(JSON格式)
     *
     * @var string
     */
    public $customFields;

    /**
     * @description 通知接收人配置
     *
     * @var notify
     */
    public $notify;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 工单模板业务ID
     *
     * @var string
     */
    public $openTemplateBizId;

    /**
     * @description 工单处理人UnionId列表
     *
     * @var string[]
     */
    public $processorUnionIds;

    /**
     * @description 工单场景 SG 或 VOC
     *
     * @var string
     */
    public $scene;

    /**
     * @description 工单场景信息
     *
     * @var sceneContext
     */
    public $sceneContext;

    /**
     * @description 工单标题
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
        'processorUnionIds' => 'processorUnionIds',
        'scene'             => 'scene',
        'sceneContext'      => 'sceneContext',
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
        if (null !== $this->processorUnionIds) {
            $res['processorUnionIds'] = $this->processorUnionIds;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sceneContext) {
            $res['sceneContext'] = null !== $this->sceneContext ? $this->sceneContext->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTicketRequest
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
