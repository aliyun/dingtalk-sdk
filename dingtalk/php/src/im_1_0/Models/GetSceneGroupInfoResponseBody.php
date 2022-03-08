<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSceneGroupInfoResponseBody extends Model
{
    /**
     * @description 群url
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @description 群头像mediaId
     *
     * @var string
     */
    public $icon;

    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群主员工id
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description result
     *
     * @var bool
     */
    public $success;

    /**
     * @description 场景群模板ID
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 群名称
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'groupUrl'           => 'groupUrl',
        'icon'               => 'icon',
        'openConversationId' => 'openConversationId',
        'ownerUserId'        => 'ownerUserId',
        'success'            => 'success',
        'templateId'         => 'templateId',
        'title'              => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
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
     * @return GetSceneGroupInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupUrl'])) {
            $model->groupUrl = $map['groupUrl'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
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
