<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody;
use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @var bool
     */
    public $allowComment;

    /**
     * @var int
     */
    public $commentType;

    /**
     * @var int[]
     */
    public $depIdList;

    /**
     * @var bool
     */
    public $isPreview;

    /**
     * @var bool
     */
    public $isToAll;

    /**
     * @example P16mHftLYX8iE
     *
     * @var string
     */
    public $mediaId;

    /**
     * @var msgBody
     */
    public $msgBody;

    /**
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @var int[]
     */
    public $roleIds;

    /**
     * @var int
     */
    public $showHomepage;

    /**
     * @example hello
     *
     * @var string
     */
    public $textContent;

    /**
     * @example jYdrJoCmTo0iE
     *
     * @var string
     */
    public $unionid;

    /**
     * @var string[]
     */
    public $useridList;

    /**
     * @example 48566508-3f35
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'allowComment' => 'allow_comment',
        'commentType' => 'comment_type',
        'depIdList' => 'dep_id_list',
        'isPreview' => 'is_preview',
        'isToAll' => 'is_to_all',
        'mediaId' => 'media_id',
        'msgBody' => 'msg_body',
        'msgType' => 'msg_type',
        'roleIds' => 'roleIds',
        'showHomepage' => 'show_homepage',
        'textContent' => 'text_content',
        'unionid' => 'unionid',
        'useridList' => 'userid_list',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowComment) {
            $res['allow_comment'] = $this->allowComment;
        }
        if (null !== $this->commentType) {
            $res['comment_type'] = $this->commentType;
        }
        if (null !== $this->depIdList) {
            $res['dep_id_list'] = $this->depIdList;
        }
        if (null !== $this->isPreview) {
            $res['is_preview'] = $this->isPreview;
        }
        if (null !== $this->isToAll) {
            $res['is_to_all'] = $this->isToAll;
        }
        if (null !== $this->mediaId) {
            $res['media_id'] = $this->mediaId;
        }
        if (null !== $this->msgBody) {
            $res['msg_body'] = null !== $this->msgBody ? $this->msgBody->toMap() : null;
        }
        if (null !== $this->msgType) {
            $res['msg_type'] = $this->msgType;
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->showHomepage) {
            $res['show_homepage'] = $this->showHomepage;
        }
        if (null !== $this->textContent) {
            $res['text_content'] = $this->textContent;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }
        if (null !== $this->useridList) {
            $res['userid_list'] = $this->useridList;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allow_comment'])) {
            $model->allowComment = $map['allow_comment'];
        }
        if (isset($map['comment_type'])) {
            $model->commentType = $map['comment_type'];
        }
        if (isset($map['dep_id_list'])) {
            if (!empty($map['dep_id_list'])) {
                $model->depIdList = $map['dep_id_list'];
            }
        }
        if (isset($map['is_preview'])) {
            $model->isPreview = $map['is_preview'];
        }
        if (isset($map['is_to_all'])) {
            $model->isToAll = $map['is_to_all'];
        }
        if (isset($map['media_id'])) {
            $model->mediaId = $map['media_id'];
        }
        if (isset($map['msg_body'])) {
            $model->msgBody = msgBody::fromMap($map['msg_body']);
        }
        if (isset($map['msg_type'])) {
            $model->msgType = $map['msg_type'];
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['show_homepage'])) {
            $model->showHomepage = $map['show_homepage'];
        }
        if (isset($map['text_content'])) {
            $model->textContent = $map['text_content'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }
        if (isset($map['userid_list'])) {
            if (!empty($map['userid_list'])) {
                $model->useridList = $map['userid_list'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
