<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupDetailInfoResponseBody;

use AlibabaCloud\Tea\Model;

class managementOptions extends Model
{
    /**
     * @var string
     */
    public $chatBannedType;

    /**
     * @var string
     */
    public $managementType;

    /**
     * @var string
     */
    public $mentionAllAuthority;

    /**
     * @var string
     */
    public $notQuitWhenEmpLeave;

    /**
     * @var string
     */
    public $onlyAdminCanAddMem;

    /**
     * @var string
     */
    public $searchable;

    /**
     * @var string
     */
    public $showHistoryType;

    /**
     * @var string
     */
    public $validationType;
    protected $_name = [
        'chatBannedType' => 'chat_banned_type',
        'managementType' => 'management_type',
        'mentionAllAuthority' => 'mention_all_authority',
        'notQuitWhenEmpLeave' => 'not_quit_when_emp_leave',
        'onlyAdminCanAddMem' => 'only_admin_can_add_mem',
        'searchable' => 'searchable',
        'showHistoryType' => 'show_history_type',
        'validationType' => 'validation_type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatBannedType) {
            $res['chat_banned_type'] = $this->chatBannedType;
        }
        if (null !== $this->managementType) {
            $res['management_type'] = $this->managementType;
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
        if (isset($map['chat_banned_type'])) {
            $model->chatBannedType = $map['chat_banned_type'];
        }
        if (isset($map['management_type'])) {
            $model->managementType = $map['management_type'];
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
