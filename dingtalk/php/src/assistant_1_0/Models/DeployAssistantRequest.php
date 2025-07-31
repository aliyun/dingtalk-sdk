<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest\action;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest\appScopes;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest\fallback;
use AlibabaCloud\Tea\Model;

class DeployAssistantRequest extends Model
{
    /**
     * @var action
     */
    public $action;

    /**
     * @var string
     */
    public $aiAssistantId;

    /**
     * @var appScopes
     */
    public $appScopes;

    /**
     * @var string
     */
    public $description;

    /**
     * @var fallback
     */
    public $fallback;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var string
     */
    public $instructions;

    /**
     * @var int
     */
    public $isPublic;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $operateUserId;

    /**
     * @var string[]
     */
    public $recommendPrompts;

    /**
     * @var string
     */
    public $shareRecipient;

    /**
     * @var string
     */
    public $toneStyle;

    /**
     * @var string
     */
    public $uuid;

    /**
     * @var string
     */
    public $welcomeContent;

    /**
     * @var string
     */
    public $welcomeTitle;
    protected $_name = [
        'action' => 'action',
        'aiAssistantId' => 'aiAssistantId',
        'appScopes' => 'appScopes',
        'description' => 'description',
        'fallback' => 'fallback',
        'icon' => 'icon',
        'instructions' => 'instructions',
        'isPublic' => 'isPublic',
        'name' => 'name',
        'operateUserId' => 'operateUserId',
        'recommendPrompts' => 'recommendPrompts',
        'shareRecipient' => 'shareRecipient',
        'toneStyle' => 'toneStyle',
        'uuid' => 'uuid',
        'welcomeContent' => 'welcomeContent',
        'welcomeTitle' => 'welcomeTitle',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = null !== $this->action ? $this->action->toMap() : null;
        }
        if (null !== $this->aiAssistantId) {
            $res['aiAssistantId'] = $this->aiAssistantId;
        }
        if (null !== $this->appScopes) {
            $res['appScopes'] = null !== $this->appScopes ? $this->appScopes->toMap() : null;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->fallback) {
            $res['fallback'] = null !== $this->fallback ? $this->fallback->toMap() : null;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->instructions) {
            $res['instructions'] = $this->instructions;
        }
        if (null !== $this->isPublic) {
            $res['isPublic'] = $this->isPublic;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->recommendPrompts) {
            $res['recommendPrompts'] = $this->recommendPrompts;
        }
        if (null !== $this->shareRecipient) {
            $res['shareRecipient'] = $this->shareRecipient;
        }
        if (null !== $this->toneStyle) {
            $res['toneStyle'] = $this->toneStyle;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->welcomeContent) {
            $res['welcomeContent'] = $this->welcomeContent;
        }
        if (null !== $this->welcomeTitle) {
            $res['welcomeTitle'] = $this->welcomeTitle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeployAssistantRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = action::fromMap($map['action']);
        }
        if (isset($map['aiAssistantId'])) {
            $model->aiAssistantId = $map['aiAssistantId'];
        }
        if (isset($map['appScopes'])) {
            $model->appScopes = appScopes::fromMap($map['appScopes']);
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['fallback'])) {
            $model->fallback = fallback::fromMap($map['fallback']);
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['instructions'])) {
            $model->instructions = $map['instructions'];
        }
        if (isset($map['isPublic'])) {
            $model->isPublic = $map['isPublic'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['recommendPrompts'])) {
            if (!empty($map['recommendPrompts'])) {
                $model->recommendPrompts = $map['recommendPrompts'];
            }
        }
        if (isset($map['shareRecipient'])) {
            $model->shareRecipient = $map['shareRecipient'];
        }
        if (isset($map['toneStyle'])) {
            $model->toneStyle = $map['toneStyle'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['welcomeContent'])) {
            $model->welcomeContent = $map['welcomeContent'];
        }
        if (isset($map['welcomeTitle'])) {
            $model->welcomeTitle = $map['welcomeTitle'];
        }

        return $model;
    }
}
