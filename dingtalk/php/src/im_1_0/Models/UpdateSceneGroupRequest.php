<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateSceneGroupRequest\managementOptions;
use AlibabaCloud\Tea\Model;

class UpdateSceneGroupRequest extends Model
{
    /**
     * @example http://***.png
     *
     * @var string
     */
    public $icon;

    /**
     * @var managementOptions
     */
    public $managementOptions;

    /**
     * @description This parameter is required.
     *
     * @example cidxxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example unionid****
     *
     * @var string
     */
    public $ownerUnionId;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @example 客户群
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'icon' => 'icon',
        'managementOptions' => 'management_options',
        'openConversationId' => 'open_conversation_id',
        'ownerUnionId' => 'owner_union_id',
        'ownerUserId' => 'owner_user_id',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->managementOptions) {
            $res['management_options'] = null !== $this->managementOptions ? $this->managementOptions->toMap() : null;
        }
        if (null !== $this->openConversationId) {
            $res['open_conversation_id'] = $this->openConversationId;
        }
        if (null !== $this->ownerUnionId) {
            $res['owner_union_id'] = $this->ownerUnionId;
        }
        if (null !== $this->ownerUserId) {
            $res['owner_user_id'] = $this->ownerUserId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSceneGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['management_options'])) {
            $model->managementOptions = managementOptions::fromMap($map['management_options']);
        }
        if (isset($map['open_conversation_id'])) {
            $model->openConversationId = $map['open_conversation_id'];
        }
        if (isset($map['owner_union_id'])) {
            $model->ownerUnionId = $map['owner_union_id'];
        }
        if (isset($map['owner_user_id'])) {
            $model->ownerUserId = $map['owner_user_id'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
