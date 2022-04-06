<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody\resultList\manager;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponseBody\resultList\owner;
use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 群组内群数量（不包含已解散的群）。
     *
     * @var int
     */
    public $groupChatCount;

    /**
     * @description 最新裂变群的群openConversationId
     *
     * @var string
     */
    public $lastOpenConversationId;

    /**
     * @description 群管理员列表
     *
     * @var manager[]
     */
    public $manager;

    /**
     * @description 群管理员userId列表，多个用逗号隔开，裂变出的新群会自动设置这些userId为群管理员
     *
     * @var string
     */
    public $managerUserIds;

    /**
     * @description 群组内所有群的成员数量
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 单个群的人数上限
     *
     * @var int
     */
    public $memberQuota;

    /**
     * @description 群组名
     *
     * @var string
     */
    public $name;

    /**
     * @description 群公告文本，裂变出的新群会自动设置上该群公告
     *
     * @var string
     */
    public $notice;

    /**
     * @description 群公告是否置顶，0：不置顶，1：置顶。裂变出的新群会自动设置上该属性
     *
     * @var int
     */
    public $noticeToped;

    /**
     * @description 群组openGroupSetId
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 群主
     *
     * @var owner
     */
    public $owner;

    /**
     * @description 群主userId，裂变出的新群会自动设置该userId为群主
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description 关系类型
     *
     * @var string
     */
    public $relationType;

    /**
     * @description 群模板id
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
