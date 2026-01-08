<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class aiSummaryList extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $aiSceneRuleAvatarUrl;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $openFileId;

    /**
     * @var int
     */
    public $order;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'agentId' => 'agentId',
        'aiSceneRuleAvatarUrl' => 'aiSceneRuleAvatarUrl',
        'creatorUnionId' => 'creatorUnionId',
        'instanceId' => 'instanceId',
        'openFileId' => 'openFileId',
        'order' => 'order',
        'summary' => 'summary',
        'templateId' => 'templateId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->aiSceneRuleAvatarUrl) {
            $res['aiSceneRuleAvatarUrl'] = $this->aiSceneRuleAvatarUrl;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->openFileId) {
            $res['openFileId'] = $this->openFileId;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aiSummaryList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['aiSceneRuleAvatarUrl'])) {
            $model->aiSceneRuleAvatarUrl = $map['aiSceneRuleAvatarUrl'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['openFileId'])) {
            $model->openFileId = $map['openFileId'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
