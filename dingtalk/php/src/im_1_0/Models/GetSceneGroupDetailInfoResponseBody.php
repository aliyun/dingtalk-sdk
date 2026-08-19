<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupDetailInfoResponseBody\managementOptions;
use AlibabaCloud\Tea\Model;

class GetSceneGroupDetailInfoResponseBody extends Model
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
     * @var int
     */
    public $memberAmount;

    /**
     * @example cidXXXXXXXXX==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $ownerUnionId;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string
     */
    public $sceneData;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string[]
     */
    public $subAdminStaffIds;

    /**
     * @var string[]
     */
    public $subAdminUnionIds;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'groupUrl' => 'group_url',
        'icon' => 'icon',
        'managementOptions' => 'management_options',
        'memberAmount' => 'member_amount',
        'openConversationId' => 'open_conversation_id',
        'ownerUnionId' => 'owner_union_id',
        'ownerUserId' => 'owner_user_id',
        'sceneData' => 'scene_data',
        'status' => 'status',
        'subAdminStaffIds' => 'sub_admin_staff_ids',
        'subAdminUnionIds' => 'sub_admin_union_ids',
        'success' => 'success',
        'templateId' => 'template_id',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupUrl) {
            $res['group_url'] = $this->groupUrl;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->managementOptions) {
            $res['management_options'] = null !== $this->managementOptions ? $this->managementOptions->toMap() : null;
        }
        if (null !== $this->memberAmount) {
            $res['member_amount'] = $this->memberAmount;
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
        if (null !== $this->sceneData) {
            $res['scene_data'] = $this->sceneData;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subAdminStaffIds) {
            $res['sub_admin_staff_ids'] = $this->subAdminStaffIds;
        }
        if (null !== $this->subAdminUnionIds) {
            $res['sub_admin_union_ids'] = $this->subAdminUnionIds;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->templateId) {
            $res['template_id'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSceneGroupDetailInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['group_url'])) {
            $model->groupUrl = $map['group_url'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['management_options'])) {
            $model->managementOptions = managementOptions::fromMap($map['management_options']);
        }
        if (isset($map['member_amount'])) {
            $model->memberAmount = $map['member_amount'];
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
        if (isset($map['scene_data'])) {
            $model->sceneData = $map['scene_data'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['sub_admin_staff_ids'])) {
            if (!empty($map['sub_admin_staff_ids'])) {
                $model->subAdminStaffIds = $map['sub_admin_staff_ids'];
            }
        }
        if (isset($map['sub_admin_union_ids'])) {
            if (!empty($map['sub_admin_union_ids'])) {
                $model->subAdminUnionIds = $map['sub_admin_union_ids'];
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['template_id'])) {
            $model->templateId = $map['template_id'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
