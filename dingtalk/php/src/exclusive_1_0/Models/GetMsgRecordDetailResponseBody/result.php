<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\actionCard;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\articles;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\link;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\markdown;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var actionCard
     */
    public $actionCard;

    /**
     * @var bool
     */
    public $allowComment;

    /**
     * @var bool
     */
    public $allowForward;

    /**
     * @var articles[]
     */
    public $articles;

    /**
     * @example 1766028831000
     *
     * @var int
     */
    public $createTime;

    /**
     * @var string[]
     */
    public $depIdList;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isToAll;

    /**
     * @var link
     */
    public $link;

    /**
     * @var markdown
     */
    public $markdown;

    /**
     * @example @sdafgffxxrgdssa1123
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @example 2569131246
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string[]
     */
    public $roleIdList;

    /**
     * @description This parameter is required.
     *
     * @example 1766028831000
     *
     * @var int
     */
    public $sendTime;

    /**
     * @description This parameter is required.
     *
     * @example pushkxQ2b2DTDAb0qkTjNdKLmwiEiE
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 文本消息
     *
     * @var string
     */
    public $textContent;

    /**
     * @example 文本消息
     *
     * @var string
     */
    public $title;

    /**
     * @var string[]
     */
    public $useridList;

    /**
     * @var string
     */
    public $viewScopeType;
    protected $_name = [
        'actionCard' => 'action_card',
        'allowComment' => 'allow_comment',
        'allowForward' => 'allow_forward',
        'articles' => 'articles',
        'createTime' => 'create_time',
        'depIdList' => 'dep_id_list',
        'isToAll' => 'is_to_all',
        'link' => 'link',
        'markdown' => 'markdown',
        'mediaId' => 'mediaId',
        'msgType' => 'msg_type',
        'operatorUserId' => 'operator_user_id',
        'roleIdList' => 'roleIdList',
        'sendTime' => 'send_time',
        'taskId' => 'task_id',
        'textContent' => 'textContent',
        'title' => 'title',
        'useridList' => 'userid_list',
        'viewScopeType' => 'view_scope_type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCard) {
            $res['action_card'] = null !== $this->actionCard ? $this->actionCard->toMap() : null;
        }
        if (null !== $this->allowComment) {
            $res['allow_comment'] = $this->allowComment;
        }
        if (null !== $this->allowForward) {
            $res['allow_forward'] = $this->allowForward;
        }
        if (null !== $this->articles) {
            $res['articles'] = [];
            if (null !== $this->articles && \is_array($this->articles)) {
                $n = 0;
                foreach ($this->articles as $item) {
                    $res['articles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->createTime) {
            $res['create_time'] = $this->createTime;
        }
        if (null !== $this->depIdList) {
            $res['dep_id_list'] = $this->depIdList;
        }
        if (null !== $this->isToAll) {
            $res['is_to_all'] = $this->isToAll;
        }
        if (null !== $this->link) {
            $res['link'] = null !== $this->link ? $this->link->toMap() : null;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = null !== $this->markdown ? $this->markdown->toMap() : null;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->msgType) {
            $res['msg_type'] = $this->msgType;
        }
        if (null !== $this->operatorUserId) {
            $res['operator_user_id'] = $this->operatorUserId;
        }
        if (null !== $this->roleIdList) {
            $res['roleIdList'] = $this->roleIdList;
        }
        if (null !== $this->sendTime) {
            $res['send_time'] = $this->sendTime;
        }
        if (null !== $this->taskId) {
            $res['task_id'] = $this->taskId;
        }
        if (null !== $this->textContent) {
            $res['textContent'] = $this->textContent;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->useridList) {
            $res['userid_list'] = $this->useridList;
        }
        if (null !== $this->viewScopeType) {
            $res['view_scope_type'] = $this->viewScopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action_card'])) {
            $model->actionCard = actionCard::fromMap($map['action_card']);
        }
        if (isset($map['allow_comment'])) {
            $model->allowComment = $map['allow_comment'];
        }
        if (isset($map['allow_forward'])) {
            $model->allowForward = $map['allow_forward'];
        }
        if (isset($map['articles'])) {
            if (!empty($map['articles'])) {
                $model->articles = [];
                $n = 0;
                foreach ($map['articles'] as $item) {
                    $model->articles[$n++] = null !== $item ? articles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['create_time'])) {
            $model->createTime = $map['create_time'];
        }
        if (isset($map['dep_id_list'])) {
            if (!empty($map['dep_id_list'])) {
                $model->depIdList = $map['dep_id_list'];
            }
        }
        if (isset($map['is_to_all'])) {
            $model->isToAll = $map['is_to_all'];
        }
        if (isset($map['link'])) {
            $model->link = link::fromMap($map['link']);
        }
        if (isset($map['markdown'])) {
            $model->markdown = markdown::fromMap($map['markdown']);
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['msg_type'])) {
            $model->msgType = $map['msg_type'];
        }
        if (isset($map['operator_user_id'])) {
            $model->operatorUserId = $map['operator_user_id'];
        }
        if (isset($map['roleIdList'])) {
            if (!empty($map['roleIdList'])) {
                $model->roleIdList = $map['roleIdList'];
            }
        }
        if (isset($map['send_time'])) {
            $model->sendTime = $map['send_time'];
        }
        if (isset($map['task_id'])) {
            $model->taskId = $map['task_id'];
        }
        if (isset($map['textContent'])) {
            $model->textContent = $map['textContent'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userid_list'])) {
            if (!empty($map['userid_list'])) {
                $model->useridList = $map['userid_list'];
            }
        }
        if (isset($map['view_scope_type'])) {
            $model->viewScopeType = $map['view_scope_type'];
        }

        return $model;
    }
}
