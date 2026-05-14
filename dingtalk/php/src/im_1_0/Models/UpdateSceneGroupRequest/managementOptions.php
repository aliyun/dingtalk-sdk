<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateSceneGroupRequest;

use AlibabaCloud\Tea\Model;

class managementOptions extends Model
{
    /**
     * @var int
     */
    public $addFriendForbidden;

    /**
     * @var int
     */
    public $allMembersCanCreateCalendar;

    /**
     * @var int
     */
    public $allMembersCanCreateMcsConf;

    /**
     * @var int
     */
    public $chatBannedType;

    /**
     * @var int
     */
    public $groupEmailDisabled;

    /**
     * @var int
     */
    public $groupLiveSwitch;

    /**
     * @var int
     */
    public $managementType;

    /**
     * @var int
     */
    public $membersToAdminChat;

    /**
     * @var int
     */
    public $mentionAllAuthority;

    /**
     * @var int
     */
    public $notQuitWhenEmpLeave;

    /**
     * @var int
     */
    public $onlyAdminCanAddMem;

    /**
     * @var int
     */
    public $onlyAdminCanDing;

    /**
     * @var int
     */
    public $onlyAdminCanSetMsgTop;

    /**
     * @var int
     */
    public $pluginCustomizeVerify;

    /**
     * @var int
     */
    public $searchable;

    /**
     * @var int
     */
    public $showHistoryType;

    /**
     * @var int
     */
    public $validationType;
    protected $_name = [
        'addFriendForbidden' => 'add_friend_forbidden',
        'allMembersCanCreateCalendar' => 'all_members_can_create_calendar',
        'allMembersCanCreateMcsConf' => 'all_members_can_create_mcs_conf',
        'chatBannedType' => 'chat_banned_type',
        'groupEmailDisabled' => 'group_email_disabled',
        'groupLiveSwitch' => 'group_live_switch',
        'managementType' => 'management_type',
        'membersToAdminChat' => 'members_to_admin_chat',
        'mentionAllAuthority' => 'mention_all_authority',
        'notQuitWhenEmpLeave' => 'not_quit_when_emp_leave',
        'onlyAdminCanAddMem' => 'only_admin_can_add_mem',
        'onlyAdminCanDing' => 'only_admin_can_ding',
        'onlyAdminCanSetMsgTop' => 'only_admin_can_set_msg_top',
        'pluginCustomizeVerify' => 'plugin_customize_verify',
        'searchable' => 'searchable',
        'showHistoryType' => 'show_history_type',
        'validationType' => 'validation_type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->addFriendForbidden) {
            $res['add_friend_forbidden'] = $this->addFriendForbidden;
        }
        if (null !== $this->allMembersCanCreateCalendar) {
            $res['all_members_can_create_calendar'] = $this->allMembersCanCreateCalendar;
        }
        if (null !== $this->allMembersCanCreateMcsConf) {
            $res['all_members_can_create_mcs_conf'] = $this->allMembersCanCreateMcsConf;
        }
        if (null !== $this->chatBannedType) {
            $res['chat_banned_type'] = $this->chatBannedType;
        }
        if (null !== $this->groupEmailDisabled) {
            $res['group_email_disabled'] = $this->groupEmailDisabled;
        }
        if (null !== $this->groupLiveSwitch) {
            $res['group_live_switch'] = $this->groupLiveSwitch;
        }
        if (null !== $this->managementType) {
            $res['management_type'] = $this->managementType;
        }
        if (null !== $this->membersToAdminChat) {
            $res['members_to_admin_chat'] = $this->membersToAdminChat;
        }
        if (null !== $this->mentionAllAuthority) {
            $res['mention_all_authority'] = $this->mentionAllAuthority;
        }
        if (null !== $this->notQuitWhenEmpLeave) {
            $res['not_quit_when_emp_leave'] = $this->notQuitWhenEmpLeave;
        }
        if (null !== $this->onlyAdminCanAddMem) {
            $res['only_admin_can_add_mem'] = $this->onlyAdminCanAddMem;
        }
        if (null !== $this->onlyAdminCanDing) {
            $res['only_admin_can_ding'] = $this->onlyAdminCanDing;
        }
        if (null !== $this->onlyAdminCanSetMsgTop) {
            $res['only_admin_can_set_msg_top'] = $this->onlyAdminCanSetMsgTop;
        }
        if (null !== $this->pluginCustomizeVerify) {
            $res['plugin_customize_verify'] = $this->pluginCustomizeVerify;
        }
        if (null !== $this->searchable) {
            $res['searchable'] = $this->searchable;
        }
        if (null !== $this->showHistoryType) {
            $res['show_history_type'] = $this->showHistoryType;
        }
        if (null !== $this->validationType) {
            $res['validation_type'] = $this->validationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return managementOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['add_friend_forbidden'])) {
            $model->addFriendForbidden = $map['add_friend_forbidden'];
        }
        if (isset($map['all_members_can_create_calendar'])) {
            $model->allMembersCanCreateCalendar = $map['all_members_can_create_calendar'];
        }
        if (isset($map['all_members_can_create_mcs_conf'])) {
            $model->allMembersCanCreateMcsConf = $map['all_members_can_create_mcs_conf'];
        }
        if (isset($map['chat_banned_type'])) {
            $model->chatBannedType = $map['chat_banned_type'];
        }
        if (isset($map['group_email_disabled'])) {
            $model->groupEmailDisabled = $map['group_email_disabled'];
        }
        if (isset($map['group_live_switch'])) {
            $model->groupLiveSwitch = $map['group_live_switch'];
        }
        if (isset($map['management_type'])) {
            $model->managementType = $map['management_type'];
        }
        if (isset($map['members_to_admin_chat'])) {
            $model->membersToAdminChat = $map['members_to_admin_chat'];
        }
        if (isset($map['mention_all_authority'])) {
            $model->mentionAllAuthority = $map['mention_all_authority'];
        }
        if (isset($map['not_quit_when_emp_leave'])) {
            $model->notQuitWhenEmpLeave = $map['not_quit_when_emp_leave'];
        }
        if (isset($map['only_admin_can_add_mem'])) {
            $model->onlyAdminCanAddMem = $map['only_admin_can_add_mem'];
        }
        if (isset($map['only_admin_can_ding'])) {
            $model->onlyAdminCanDing = $map['only_admin_can_ding'];
        }
        if (isset($map['only_admin_can_set_msg_top'])) {
            $model->onlyAdminCanSetMsgTop = $map['only_admin_can_set_msg_top'];
        }
        if (isset($map['plugin_customize_verify'])) {
            $model->pluginCustomizeVerify = $map['plugin_customize_verify'];
        }
        if (isset($map['searchable'])) {
            $model->searchable = $map['searchable'];
        }
        if (isset($map['show_history_type'])) {
            $model->showHistoryType = $map['show_history_type'];
        }
        if (isset($map['validation_type'])) {
            $model->validationType = $map['validation_type'];
        }

        return $model;
    }
}
