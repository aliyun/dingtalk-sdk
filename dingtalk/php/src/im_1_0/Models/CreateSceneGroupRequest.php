<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupRequest\managementOptions;
use AlibabaCloud\Tea\Model;

class CreateSceneGroupRequest extends Model
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
     * @example 1107****2120
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string[]
     */
    public $subadminIds;

    /**
     * @description This parameter is required.
     *
     * @example 8d42****nkld
     *
     * @var string
     */
    public $templateId;

    /**
     * @description This parameter is required.
     *
     * @example 客户群
     *
     * @var string
     */
    public $title;

    /**
     * @var string[]
     */
    public $userIds;

    /**
     * @example asdazxc
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'icon' => 'icon',
        'managementOptions' => 'management_options',
        'ownerUserId' => 'owner_user_id',
        'subadminIds' => 'subadmin_ids',
        'templateId' => 'template_id',
        'title' => 'title',
        'userIds' => 'user_ids',
        'uuid' => 'uuid',
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
        if (null !== $this->ownerUserId) {
            $res['owner_user_id'] = $this->ownerUserId;
        }
        if (null !== $this->subadminIds) {
            $res['subadmin_ids'] = $this->subadminIds;
        }
        if (null !== $this->templateId) {
            $res['template_id'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userIds) {
            $res['user_ids'] = $this->userIds;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSceneGroupRequest
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
        if (isset($map['owner_user_id'])) {
            $model->ownerUserId = $map['owner_user_id'];
        }
        if (isset($map['subadmin_ids'])) {
            if (!empty($map['subadmin_ids'])) {
                $model->subadminIds = $map['subadmin_ids'];
            }
        }
        if (isset($map['template_id'])) {
            $model->templateId = $map['template_id'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['user_ids'])) {
            if (!empty($map['user_ids'])) {
                $model->userIds = $map['user_ids'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
