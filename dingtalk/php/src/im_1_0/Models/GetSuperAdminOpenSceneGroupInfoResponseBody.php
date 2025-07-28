<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSuperAdminOpenSceneGroupInfoResponseBody\managementOptions;
use AlibabaCloud\Tea\Model;

class GetSuperAdminOpenSceneGroupInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $groupUrl;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var managementOptions
     */
    public $managementOptions;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string[]
     */
    public $subAdminUserIds;

    /**
     * @var bool
     */
    public $sucess;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'groupUrl' => 'groupUrl',
        'icon' => 'icon',
        'managementOptions' => 'managementOptions',
        'openConversationId' => 'openConversationId',
        'ownerUserId' => 'ownerUserId',
        'subAdminUserIds' => 'subAdminUserIds',
        'sucess' => 'sucess',
        'templateId' => 'templateId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->managementOptions) {
            $res['managementOptions'] = null !== $this->managementOptions ? $this->managementOptions->toMap() : null;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->subAdminUserIds) {
            $res['subAdminUserIds'] = $this->subAdminUserIds;
        }
        if (null !== $this->sucess) {
            $res['sucess'] = $this->sucess;
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
     * @return GetSuperAdminOpenSceneGroupInfoResponseBody
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
        if (isset($map['managementOptions'])) {
            $model->managementOptions = managementOptions::fromMap($map['managementOptions']);
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['subAdminUserIds'])) {
            if (!empty($map['subAdminUserIds'])) {
                $model->subAdminUserIds = $map['subAdminUserIds'];
            }
        }
        if (isset($map['sucess'])) {
            $model->sucess = $map['sucess'];
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
