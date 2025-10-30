<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoByCursorPageResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example 1756656000000
     *
     * @var int
     */
    public $groupCreateTime;

    /**
     * @var int
     */
    public $groupLastActiveTime;

    /**
     * @example 10
     *
     * @var int
     */
    public $groupMembersCnt;

    /**
     * @example 内部群
     *
     * @var string
     */
    public $groupName;

    /**
     * @var string
     */
    public $groupOwner;

    /**
     * @example user123
     *
     * @var string
     */
    public $groupOwnerUserId;

    /**
     * @example cid123
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 1
     *
     * @var int
     */
    public $syncToDingpan;

    /**
     * @example 1000
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'groupCreateTime' => 'groupCreateTime',
        'groupLastActiveTime' => 'groupLastActiveTime',
        'groupMembersCnt' => 'groupMembersCnt',
        'groupName' => 'groupName',
        'groupOwner' => 'groupOwner',
        'groupOwnerUserId' => 'groupOwnerUserId',
        'openConversationId' => 'openConversationId',
        'status' => 'status',
        'syncToDingpan' => 'syncToDingpan',
        'usedQuota' => 'usedQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupCreateTime) {
            $res['groupCreateTime'] = $this->groupCreateTime;
        }
        if (null !== $this->groupLastActiveTime) {
            $res['groupLastActiveTime'] = $this->groupLastActiveTime;
        }
        if (null !== $this->groupMembersCnt) {
            $res['groupMembersCnt'] = $this->groupMembersCnt;
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
        if (isset($map['groupCreateTime'])) {
            $model->groupCreateTime = $map['groupCreateTime'];
        }
        if (isset($map['groupLastActiveTime'])) {
            $model->groupLastActiveTime = $map['groupLastActiveTime'];
        }
        if (isset($map['groupMembersCnt'])) {
            $model->groupMembersCnt = $map['groupMembersCnt'];
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
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
