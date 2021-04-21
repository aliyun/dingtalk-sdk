<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest\btns;
use AlibabaCloud\Tea\Model;

class SendServiceGroupMessageRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

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

    /**
     * @description 内容
     *
     * @var string
     */
    public $content;

    /**
     * @description at 手机号
     *
     * @var string[]
     */
    public $atMobiles;

    /**
     * @description at dingtalkId
     *
     * @var string[]
     */
    public $atDingtalkIds;

    /**
     * @description at unionIds
     *
     * @var string[]
     */
    public $atUnionIds;

    /**
     * @description 手机号接收者
     *
     * @var string[]
     */
    public $receiverMobiles;

    /**
     * @description dingtalkId接收者
     *
     * @var string[]
     */
    public $receiverDingtalkIds;

    /**
     * @description unionId接收者
     *
     * @var string[]
     */
    public $receiverUnionIds;

    /**
     * @description 消息类型：MARKDOWN，ACTIONCARD
     *
     * @var string
     */
    public $messageType;

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
    protected $_name = [
        'dingIsvOrgId'             => 'dingIsvOrgId',
        'dingOrgId'                => 'dingOrgId',
        'dingTokenGrantType'       => 'dingTokenGrantType',
        'dingSuiteKey'             => 'dingSuiteKey',
        'targetOpenConversationId' => 'targetOpenConversationId',
        'title'                    => 'title',
        'content'                  => 'content',
        'atMobiles'                => 'atMobiles',
        'atDingtalkIds'            => 'atDingtalkIds',
        'atUnionIds'               => 'atUnionIds',
        'receiverMobiles'          => 'receiverMobiles',
        'receiverDingtalkIds'      => 'receiverDingtalkIds',
        'receiverUnionIds'         => 'receiverUnionIds',
        'messageType'              => 'messageType',
        'btnOrientation'           => 'btnOrientation',
        'btns'                     => 'btns',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->targetOpenConversationId) {
            $res['targetOpenConversationId'] = $this->targetOpenConversationId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->atMobiles) {
            $res['atMobiles'] = $this->atMobiles;
        }
        if (null !== $this->atDingtalkIds) {
            $res['atDingtalkIds'] = $this->atDingtalkIds;
        }
        if (null !== $this->atUnionIds) {
            $res['atUnionIds'] = $this->atUnionIds;
        }
        if (null !== $this->receiverMobiles) {
            $res['receiverMobiles'] = $this->receiverMobiles;
        }
        if (null !== $this->receiverDingtalkIds) {
            $res['receiverDingtalkIds'] = $this->receiverDingtalkIds;
        }
        if (null !== $this->receiverUnionIds) {
            $res['receiverUnionIds'] = $this->receiverUnionIds;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['targetOpenConversationId'])) {
            $model->targetOpenConversationId = $map['targetOpenConversationId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['atMobiles'])) {
            if (!empty($map['atMobiles'])) {
                $model->atMobiles = $map['atMobiles'];
            }
        }
        if (isset($map['atDingtalkIds'])) {
            if (!empty($map['atDingtalkIds'])) {
                $model->atDingtalkIds = $map['atDingtalkIds'];
            }
        }
        if (isset($map['atUnionIds'])) {
            if (!empty($map['atUnionIds'])) {
                $model->atUnionIds = $map['atUnionIds'];
            }
        }
        if (isset($map['receiverMobiles'])) {
            if (!empty($map['receiverMobiles'])) {
                $model->receiverMobiles = $map['receiverMobiles'];
            }
        }
        if (isset($map['receiverDingtalkIds'])) {
            if (!empty($map['receiverDingtalkIds'])) {
                $model->receiverDingtalkIds = $map['receiverDingtalkIds'];
            }
        }
        if (isset($map['receiverUnionIds'])) {
            if (!empty($map['receiverUnionIds'])) {
                $model->receiverUnionIds = $map['receiverUnionIds'];
            }
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
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

        return $model;
    }
}
