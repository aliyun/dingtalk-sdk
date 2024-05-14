<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody\resultList\manager;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody\resultList\owner;
use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @example 2021-12-23T13:00Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2021-12-23T13:00Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example 10
     *
     * @var int
     */
    public $groupChatCount;

    /**
     * @description This parameter is required.
     *
     * @example 123agsg
     *
     * @var string
     */
    public $lastOpenConversationId;

    /**
     * @description This parameter is required.
     *
     * @var manager[]
     */
    public $manager;

    /**
     * @example afsd12,afsd13
     *
     * @var string
     */
    public $managerUserIds;

    /**
     * @example 10
     *
     * @var int
     */
    public $memberCount;

    /**
     * @example 100
     *
     * @var int
     */
    public $memberQuota;

    /**
     * @example 营销群
     *
     * @var string
     */
    public $name;

    /**
     * @example 群公告
     *
     * @var string
     */
    public $notice;

    /**
     * @example 0
     *
     * @var int
     */
    public $noticeToped;

    /**
     * @example adfads
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @var owner
     */
    public $owner;

    /**
     * @example afsd12
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @example crm_customer_personal
     *
     * @var string
     */
    public $relationType;

    /**
     * @example sfasgsab
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'gmtCreate'              => 'gmtCreate',
        'gmtModified'            => 'gmtModified',
        'groupChatCount'         => 'groupChatCount',
        'lastOpenConversationId' => 'lastOpenConversationId',
        'manager'                => 'manager',
        'managerUserIds'         => 'managerUserIds',
        'memberCount'            => 'memberCount',
        'memberQuota'            => 'memberQuota',
        'name'                   => 'name',
        'notice'                 => 'notice',
        'noticeToped'            => 'noticeToped',
        'openGroupSetId'         => 'openGroupSetId',
        'owner'                  => 'owner',
        'ownerUserId'            => 'ownerUserId',
        'relationType'           => 'relationType',
        'templateId'             => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->groupChatCount) {
            $res['groupChatCount'] = $this->groupChatCount;
        }
        if (null !== $this->lastOpenConversationId) {
            $res['lastOpenConversationId'] = $this->lastOpenConversationId;
        }
        if (null !== $this->manager) {
            $res['manager'] = [];
            if (null !== $this->manager && \is_array($this->manager)) {
                $n = 0;
                foreach ($this->manager as $item) {
                    $res['manager'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->managerUserIds) {
            $res['managerUserIds'] = $this->managerUserIds;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->memberQuota) {
            $res['memberQuota'] = $this->memberQuota;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->notice) {
            $res['notice'] = $this->notice;
        }
        if (null !== $this->noticeToped) {
            $res['noticeToped'] = $this->noticeToped;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->owner) {
            $res['owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['groupChatCount'])) {
            $model->groupChatCount = $map['groupChatCount'];
        }
        if (isset($map['lastOpenConversationId'])) {
            $model->lastOpenConversationId = $map['lastOpenConversationId'];
        }
        if (isset($map['manager'])) {
            if (!empty($map['manager'])) {
                $model->manager = [];
                $n              = 0;
                foreach ($map['manager'] as $item) {
                    $model->manager[$n++] = null !== $item ? manager::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['managerUserIds'])) {
            $model->managerUserIds = $map['managerUserIds'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['memberQuota'])) {
            $model->memberQuota = $map['memberQuota'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['notice'])) {
            $model->notice = $map['notice'];
        }
        if (isset($map['noticeToped'])) {
            $model->noticeToped = $map['noticeToped'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['owner'])) {
            $model->owner = owner::fromMap($map['owner']);
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
