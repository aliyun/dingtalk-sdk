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
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 工单创建人UnionId
     *
     * @var string
     */
    public $creatorUnionId;

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

    /**
     * @description 工单模板业务ID
     *
     * @var string
     */
    public $openTemplateBizId;

    /**
     * @description 自定义组件字段值(JSON格式)
     *
     * @var string
     */
    public $customFields;

    /**
     * @var notify
     */
    public $notify;

    /**
     * @description 工单开放ID
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @description 备注
     *
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingSuiteKey'       => 'dingSuiteKey',
        'openTeamId'         => 'openTeamId',
        'creatorUnionId'     => 'creatorUnionId',
        'processorUnionIds'  => 'processorUnionIds',
        'scene'              => 'scene',
        'sceneContext'       => 'sceneContext',
        'title'              => 'title',
        'openTemplateBizId'  => 'openTemplateBizId',
        'customFields'       => 'customFields',
        'notify'             => 'notify',
        'openTicketId'       => 'openTicketId',
        'ticketMemo'         => 'ticketMemo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
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
        if (null !== $this->openTemplateBizId) {
            $res['openTemplateBizId'] = $this->openTemplateBizId;
        }
        if (null !== $this->customFields) {
            $res['customFields'] = $this->customFields;
        }
        if (null !== $this->notify) {
            $res['notify'] = null !== $this->notify ? $this->notify->toMap() : null;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
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
        if (isset($map['openTemplateBizId'])) {
            $model->openTemplateBizId = $map['openTemplateBizId'];
        }
        if (isset($map['customFields'])) {
            $model->customFields = $map['customFields'];
        }
        if (isset($map['notify'])) {
            $model->notify = notify::fromMap($map['notify']);
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }

        return $model;
    }
}
