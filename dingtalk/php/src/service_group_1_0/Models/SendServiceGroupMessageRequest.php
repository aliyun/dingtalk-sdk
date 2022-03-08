<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest\btns;
use AlibabaCloud\Tea\Model;

class SendServiceGroupMessageRequest extends Model
{
    /**
     * @description at dingtalkId
     *
     * @var string[]
     */
    public $atDingtalkIds;

    /**
     * @description at 手机号
     *
     * @var string[]
     */
    public $atMobiles;

    /**
     * @description at unionIds
     *
     * @var string[]
     */
    public $atUnionIds;

    /**
     * @description 排列方式：0-按钮竖直排列，1-按钮横向排列
     *
     * @var string
     */
    public $btnOrientation;

    /**
     * @description actionCard按钮
     *
     * @var btns[]
     */
    public $btns;

    /**
     * @description 内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 如果正文内容包含链接，并且按钮链接和文本链接分开跳转，则传递true; 否则传递false
     *
     * @var bool
     */
    public $hasContentLinks;

    /**
     * @description 是否 at所有人
     *
     * @var bool
     */
    public $isAtAll;

    /**
     * @description 消息类型：MARKDOWN，ACTIONCARD
     *
     * @var string
     */
    public $messageType;

    /**
     * @description dingtalkId接收者
     *
     * @var string[]
     */
    public $receiverDingtalkIds;

    /**
     * @description 手机号接收者
     *
     * @var string[]
     */
    public $receiverMobiles;

    /**
     * @description unionId接收者
     *
     * @var string[]
     */
    public $receiverUnionIds;

    /**
     * @description 开放群ID
     *
     * @var string
     */
    public $targetOpenConversationId;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'atDingtalkIds'            => 'atDingtalkIds',
        'atMobiles'                => 'atMobiles',
        'atUnionIds'               => 'atUnionIds',
        'btnOrientation'           => 'btnOrientation',
        'btns'                     => 'btns',
        'content'                  => 'content',
        'hasContentLinks'          => 'hasContentLinks',
        'isAtAll'                  => 'isAtAll',
        'messageType'              => 'messageType',
        'receiverDingtalkIds'      => 'receiverDingtalkIds',
        'receiverMobiles'          => 'receiverMobiles',
        'receiverUnionIds'         => 'receiverUnionIds',
        'targetOpenConversationId' => 'targetOpenConversationId',
        'title'                    => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atDingtalkIds) {
            $res['atDingtalkIds'] = $this->atDingtalkIds;
        }
        if (null !== $this->atMobiles) {
            $res['atMobiles'] = $this->atMobiles;
        }
        if (null !== $this->atUnionIds) {
            $res['atUnionIds'] = $this->atUnionIds;
        }
        if (null !== $this->btnOrientation) {
            $res['btnOrientation'] = $this->btnOrientation;
        }
        if (null !== $this->btns) {
            $res['btns'] = [];
            if (null !== $this->btns && \is_array($this->btns)) {
                $n = 0;
                foreach ($this->btns as $item) {
                    $res['btns'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->hasContentLinks) {
            $res['hasContentLinks'] = $this->hasContentLinks;
        }
        if (null !== $this->isAtAll) {
            $res['isAtAll'] = $this->isAtAll;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->receiverDingtalkIds) {
            $res['receiverDingtalkIds'] = $this->receiverDingtalkIds;
        }
        if (null !== $this->receiverMobiles) {
            $res['receiverMobiles'] = $this->receiverMobiles;
        }
        if (null !== $this->receiverUnionIds) {
            $res['receiverUnionIds'] = $this->receiverUnionIds;
        }
        if (null !== $this->targetOpenConversationId) {
            $res['targetOpenConversationId'] = $this->targetOpenConversationId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendServiceGroupMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atDingtalkIds'])) {
            if (!empty($map['atDingtalkIds'])) {
                $model->atDingtalkIds = $map['atDingtalkIds'];
            }
        }
        if (isset($map['atMobiles'])) {
            if (!empty($map['atMobiles'])) {
                $model->atMobiles = $map['atMobiles'];
            }
        }
        if (isset($map['atUnionIds'])) {
            if (!empty($map['atUnionIds'])) {
                $model->atUnionIds = $map['atUnionIds'];
            }
        }
        if (isset($map['btnOrientation'])) {
            $model->btnOrientation = $map['btnOrientation'];
        }
        if (isset($map['btns'])) {
            if (!empty($map['btns'])) {
                $model->btns = [];
                $n           = 0;
                foreach ($map['btns'] as $item) {
                    $model->btns[$n++] = null !== $item ? btns::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['hasContentLinks'])) {
            $model->hasContentLinks = $map['hasContentLinks'];
        }
        if (isset($map['isAtAll'])) {
            $model->isAtAll = $map['isAtAll'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['receiverDingtalkIds'])) {
            if (!empty($map['receiverDingtalkIds'])) {
                $model->receiverDingtalkIds = $map['receiverDingtalkIds'];
            }
        }
        if (isset($map['receiverMobiles'])) {
            if (!empty($map['receiverMobiles'])) {
                $model->receiverMobiles = $map['receiverMobiles'];
            }
        }
        if (isset($map['receiverUnionIds'])) {
            if (!empty($map['receiverUnionIds'])) {
                $model->receiverUnionIds = $map['receiverUnionIds'];
            }
        }
        if (isset($map['targetOpenConversationId'])) {
            $model->targetOpenConversationId = $map['targetOpenConversationId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
