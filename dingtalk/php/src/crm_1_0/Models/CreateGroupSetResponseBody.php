<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupSetResponseBody\manager;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupSetResponseBody\owner;
use AlibabaCloud\Tea\Model;

class CreateGroupSetResponseBody extends Model
{
    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $inviteLink;

    /**
     * @var string
     */
    public $lastOpenConversationId;

    /**
     * @var manager[]
     */
    public $manager;

    /**
     * @var string
     */
    public $managerUserIds;

    /**
     * @var int
     */
    public $memberCount;

    /**
     * @var int
     */
    public $memberQuota;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $notice;

    /**
     * @var int
     */
    public $noticeToped;

    /**
     * @var string
     */
    public $openGroupSetId;

    /**
     * @var owner
     */
    public $owner;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @var string
     */
    public $templateId;
    protected $_name = [
        'gmtCreate'              => 'gmtCreate',
        'gmtModified'            => 'gmtModified',
        'inviteLink'             => 'inviteLink',
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
        if (null !== $this->inviteLink) {
            $res['inviteLink'] = $this->inviteLink;
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
     * @return CreateGroupSetResponseBody
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
        if (isset($map['inviteLink'])) {
            $model->inviteLink = $map['inviteLink'];
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
