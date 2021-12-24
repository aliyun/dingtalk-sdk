<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetGroupSetResponseBody\manager;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetGroupSetResponseBody\owner;
use AlibabaCloud\Tea\Model;

class GetGroupSetResponseBody extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $openGroupSetId;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @var int
     */
    public $memberQuota;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $memberCount;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string
     */
    public $managerUserIds;

    /**
     * @var string
     */
    public $notice;

    /**
     * @var int
     */
    public $noticeToped;

    /**
     * @var owner
     */
    public $owner;

    /**
     * @var manager[]
     */
    public $manager;

    /**
     * @var string
     */
    public $lastOpenConversationId;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;
    protected $_name = [
        'name'                   => 'name',
        'openGroupSetId'         => 'openGroupSetId',
        'relationType'           => 'relationType',
        'memberQuota'            => 'memberQuota',
        'corpId'                 => 'corpId',
        'memberCount'            => 'memberCount',
        'templateId'             => 'templateId',
        'ownerUserId'            => 'ownerUserId',
        'managerUserIds'         => 'managerUserIds',
        'notice'                 => 'notice',
        'noticeToped'            => 'noticeToped',
        'owner'                  => 'owner',
        'manager'                => 'manager',
        'lastOpenConversationId' => 'lastOpenConversationId',
        'gmtCreate'              => 'gmtCreate',
        'gmtModified'            => 'gmtModified',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->memberQuota) {
            $res['memberQuota'] = $this->memberQuota;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->managerUserIds) {
            $res['managerUserIds'] = $this->managerUserIds;
        }
        if (null !== $this->notice) {
            $res['notice'] = $this->notice;
        }
        if (null !== $this->noticeToped) {
            $res['noticeToped'] = $this->noticeToped;
        }
        if (null !== $this->owner) {
            $res['owner'] = null !== $this->owner ? $this->owner->toMap() : null;
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
        if (null !== $this->lastOpenConversationId) {
            $res['lastOpenConversationId'] = $this->lastOpenConversationId;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupSetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['memberQuota'])) {
            $model->memberQuota = $map['memberQuota'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['managerUserIds'])) {
            $model->managerUserIds = $map['managerUserIds'];
        }
        if (isset($map['notice'])) {
            $model->notice = $map['notice'];
        }
        if (isset($map['noticeToped'])) {
            $model->noticeToped = $map['noticeToped'];
        }
        if (isset($map['owner'])) {
            $model->owner = owner::fromMap($map['owner']);
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
        if (isset($map['lastOpenConversationId'])) {
            $model->lastOpenConversationId = $map['lastOpenConversationId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }

        return $model;
    }
}
