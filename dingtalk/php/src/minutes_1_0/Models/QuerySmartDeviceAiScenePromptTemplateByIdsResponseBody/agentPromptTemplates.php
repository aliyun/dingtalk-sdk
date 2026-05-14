<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody;

use AlibabaCloud\Tea\Model;

class agentPromptTemplates extends Model
{
    /**
     * @var string
     */
    public $agentPromptTemplateId;

    /**
     * @var string
     */
    public $avatarUrl;

    /**
     * @var string
     */
    public $belongingId;

    /**
     * @var string
     */
    public $belongingType;

    /**
     * @var string
     */
    public $category;

    /**
     * @var string
     */
    public $country;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $order;

    /**
     * @var string
     */
    public $prompt;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'agentPromptTemplateId' => 'agentPromptTemplateId',
        'avatarUrl' => 'avatarUrl',
        'belongingId' => 'belongingId',
        'belongingType' => 'belongingType',
        'category' => 'category',
        'country' => 'country',
        'creatorUnionId' => 'creatorUnionId',
        'description' => 'description',
        'order' => 'order',
        'prompt' => 'prompt',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentPromptTemplateId) {
            $res['agentPromptTemplateId'] = $this->agentPromptTemplateId;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->belongingId) {
            $res['belongingId'] = $this->belongingId;
        }
        if (null !== $this->belongingType) {
            $res['belongingType'] = $this->belongingType;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->country) {
            $res['country'] = $this->country;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return agentPromptTemplates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentPromptTemplateId'])) {
            $model->agentPromptTemplateId = $map['agentPromptTemplateId'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['belongingId'])) {
            $model->belongingId = $map['belongingId'];
        }
        if (isset($map['belongingType'])) {
            $model->belongingType = $map['belongingType'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['country'])) {
            $model->country = $map['country'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
