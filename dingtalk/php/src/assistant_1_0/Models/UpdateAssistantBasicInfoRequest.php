<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAssistantBasicInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

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
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @var string[]
     */
    public $recommendPrompts;

    /**
     * @var string
     */
    public $welcomeContent;
    protected $_name = [
        'assistantId'      => 'assistantId',
        'description'      => 'description',
        'fallbackContent'  => 'fallbackContent',
        'icon'             => 'icon',
        'instructions'     => 'instructions',
        'name'             => 'name',
        'operatorUnionId'  => 'operatorUnionId',
        'recommendPrompts' => 'recommendPrompts',
        'welcomeContent'   => 'welcomeContent',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }
        if (null !== $this->recommendPrompts) {
            $res['recommendPrompts'] = $this->recommendPrompts;
        }
        if (null !== $this->welcomeContent) {
            $res['welcomeContent'] = $this->welcomeContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAssistantBasicInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }
        if (isset($map['recommendPrompts'])) {
            if (!empty($map['recommendPrompts'])) {
                $model->recommendPrompts = $map['recommendPrompts'];
            }
        }
        if (isset($map['welcomeContent'])) {
            $model->welcomeContent = $map['welcomeContent'];
        }

        return $model;
    }
}
