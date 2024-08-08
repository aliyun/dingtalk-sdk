<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetrieveAssistantBasicInfoResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $actionNames;

    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var int
     */
    public $createdAt;

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
    public $fallbackContent;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var string
     */
    public $instructions;

    /**
     * @var string[]
     */
    public $knowledgeFileNames;

    /**
     * @var string
     */
    public $model;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $recommendPrompts;

    /**
     * @var string
     */
    public $unifiedAppId;

    /**
     * @var string
     */
    public $welcomeContent;
    protected $_name = [
        'actionNames'        => 'actionNames',
        'assistantId'        => 'assistantId',
        'createdAt'          => 'createdAt',
        'creatorUnionId'     => 'creatorUnionId',
        'description'        => 'description',
        'fallbackContent'    => 'fallbackContent',
        'icon'               => 'icon',
        'instructions'       => 'instructions',
        'knowledgeFileNames' => 'knowledgeFileNames',
        'model'              => 'model',
        'name'               => 'name',
        'recommendPrompts'   => 'recommendPrompts',
        'unifiedAppId'       => 'unifiedAppId',
        'welcomeContent'     => 'welcomeContent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionNames) {
            $res['actionNames'] = $this->actionNames;
        }
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->fallbackContent) {
            $res['fallbackContent'] = $this->fallbackContent;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->instructions) {
            $res['instructions'] = $this->instructions;
        }
        if (null !== $this->knowledgeFileNames) {
            $res['knowledgeFileNames'] = $this->knowledgeFileNames;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->recommendPrompts) {
            $res['recommendPrompts'] = $this->recommendPrompts;
        }
        if (null !== $this->unifiedAppId) {
            $res['unifiedAppId'] = $this->unifiedAppId;
        }
        if (null !== $this->welcomeContent) {
            $res['welcomeContent'] = $this->welcomeContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveAssistantBasicInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionNames'])) {
            if (!empty($map['actionNames'])) {
                $model->actionNames = $map['actionNames'];
            }
        }
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['fallbackContent'])) {
            $model->fallbackContent = $map['fallbackContent'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['instructions'])) {
            $model->instructions = $map['instructions'];
        }
        if (isset($map['knowledgeFileNames'])) {
            if (!empty($map['knowledgeFileNames'])) {
                $model->knowledgeFileNames = $map['knowledgeFileNames'];
            }
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['recommendPrompts'])) {
            if (!empty($map['recommendPrompts'])) {
                $model->recommendPrompts = $map['recommendPrompts'];
            }
        }
        if (isset($map['unifiedAppId'])) {
            $model->unifiedAppId = $map['unifiedAppId'];
        }
        if (isset($map['welcomeContent'])) {
            $model->welcomeContent = $map['welcomeContent'];
        }

        return $model;
    }
}
