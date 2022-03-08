<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var int
     */
    public $groupAdminsCount;

    /**
     * @var int
     */
    public $groupCreateTime;

    /**
     * @var int
     */
    public $groupLastActiveTime;

    /**
     * @var string
     */
    public $groupLastActiveTimeShow;

    /**
     * @var int
     */
    public $groupMembersCount;

    /**
     * @var string
     */
    public $groupName;

    /**
     * @var string
     */
    public $groupOwner;

    /**
     * @var string
     */
    public $groupOwnerUserId;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $status;

    /**
     * @var int
     */
    public $syncToDingpan;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $templateName;

    /**
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'groupAdminsCount'        => 'groupAdminsCount',
        'groupCreateTime'         => 'groupCreateTime',
        'groupLastActiveTime'     => 'groupLastActiveTime',
        'groupLastActiveTimeShow' => 'groupLastActiveTimeShow',
        'groupMembersCount'       => 'groupMembersCount',
        'groupName'               => 'groupName',
        'groupOwner'              => 'groupOwner',
        'groupOwnerUserId'        => 'groupOwnerUserId',
        'openConversationId'      => 'openConversationId',
        'status'                  => 'status',
        'syncToDingpan'           => 'syncToDingpan',
        'templateId'              => 'templateId',
        'templateName'            => 'templateName',
        'usedQuota'               => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupAdminsCount) {
            $res['groupAdminsCount'] = $this->groupAdminsCount;
        }
        if (null !== $this->groupCreateTime) {
            $res['groupCreateTime'] = $this->groupCreateTime;
        }
        if (null !== $this->groupLastActiveTime) {
            $res['groupLastActiveTime'] = $this->groupLastActiveTime;
        }
        if (null !== $this->groupLastActiveTimeShow) {
            $res['groupLastActiveTimeShow'] = $this->groupLastActiveTimeShow;
        }
        if (null !== $this->groupMembersCount) {
            $res['groupMembersCount'] = $this->groupMembersCount;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->groupOwnerUserId) {
            $res['groupOwnerUserId'] = $this->groupOwnerUserId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->syncToDingpan) {
            $res['syncToDingpan'] = $this->syncToDingpan;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupAdminsCount'])) {
            $model->groupAdminsCount = $map['groupAdminsCount'];
        }
        if (isset($map['groupCreateTime'])) {
            $model->groupCreateTime = $map['groupCreateTime'];
        }
        if (isset($map['groupLastActiveTime'])) {
            $model->groupLastActiveTime = $map['groupLastActiveTime'];
        }
        if (isset($map['groupLastActiveTimeShow'])) {
            $model->groupLastActiveTimeShow = $map['groupLastActiveTimeShow'];
        }
        if (isset($map['groupMembersCount'])) {
            $model->groupMembersCount = $map['groupMembersCount'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['groupOwnerUserId'])) {
            $model->groupOwnerUserId = $map['groupOwnerUserId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['syncToDingpan'])) {
            $model->syncToDingpan = $map['syncToDingpan'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
