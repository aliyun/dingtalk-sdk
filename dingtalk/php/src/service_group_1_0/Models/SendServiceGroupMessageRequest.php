<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest\btns;
use AlibabaCloud\Tea\Model;

class SendServiceGroupMessageRequest extends Model
{
    /**
     * @var string[]
     */
    public $atDingtalkIds;

    /**
     * @var string[]
     */
    public $atMobiles;

    /**
     * @var string[]
     */
    public $atUnionIds;

    /**
     * @example 0
     *
     * @var string
     */
    public $btnOrientation;

    /**
     * @var btns[]
     */
    public $btns;

    /**
     * @description This parameter is required.
     *
     * @example 你有新的任务待审批
     *
     * @var string
     */
    public $content;

    /**
     * @example false
     *
     * @var bool
     */
    public $hasContentLinks;

    /**
     * @example false
     *
     * @var bool
     */
    public $isAtAll;

    /**
     * @description This parameter is required.
     *
     * @example MARKDOWN
     *
     * @var string
     */
    public $messageType;

    /**
     * @var string[]
     */
    public $receiverDingtalkIds;

    /**
     * @var string[]
     */
    public $receiverMobiles;

    /**
     * @var string[]
     */
    public $receiverUnionIds;

    /**
     * @description This parameter is required.
     *
     * @example cidxxxxx==
     *
     * @var string
     */
    public $targetOpenConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 服务提醒
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
