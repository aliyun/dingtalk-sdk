<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushDingMessageRequest extends Model
{
    /**
     * @description 应用Id，默认是医疗的应用。
     *
     * @var int
     */
    public $appId;

    /**
     * @description 消息内容，长度不超过500。
     *
     * @var string
     */
    public $content;

    /**
     * @description 消息类型：CARD:卡片消息；LINK:链接消息；TEXT：文本消息；
     *
     * @var string
     */
    public $messageType;

    /**
     * @description 链接消息时，消息文案下的URL。
     *
     * @var string
     */
    public $messageUrl;

    /**
     * @description 链接消息时，右侧图片URL。
     *
     * @var string
     */
    public $pictureUrl;

    /**
     * @description 卡片消息时，消息下面action的标题，长度不超过20。
     *
     * @var string
     */
    public $singleTitle;

    /**
     * @description 卡片消息时，消息下面action转跳URL，长度不超过500。
     *
     * @var string
     */
    public $singleUrl;

    /**
     * @description 消息展示标题，长度不超过100。
     *
     * @var string
     */
    public $title;

    /**
     * @description 组织下的staffId列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'appId'       => 'appId',
        'content'     => 'content',
        'messageType' => 'messageType',
        'messageUrl'  => 'messageUrl',
        'pictureUrl'  => 'pictureUrl',
        'singleTitle' => 'singleTitle',
        'singleUrl'   => 'singleUrl',
        'title'       => 'title',
        'userIdList'  => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->messageType) {
            $res['messageType'] = $this->messageType;
        }
        if (null !== $this->messageUrl) {
            $res['messageUrl'] = $this->messageUrl;
        }
        if (null !== $this->pictureUrl) {
            $res['pictureUrl'] = $this->pictureUrl;
        }
        if (null !== $this->singleTitle) {
            $res['singleTitle'] = $this->singleTitle;
        }
        if (null !== $this->singleUrl) {
            $res['singleUrl'] = $this->singleUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushDingMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['messageType'])) {
            $model->messageType = $map['messageType'];
        }
        if (isset($map['messageUrl'])) {
            $model->messageUrl = $map['messageUrl'];
        }
        if (isset($map['pictureUrl'])) {
            $model->pictureUrl = $map['pictureUrl'];
        }
        if (isset($map['singleTitle'])) {
            $model->singleTitle = $map['singleTitle'];
        }
        if (isset($map['singleUrl'])) {
            $model->singleUrl = $map['singleUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
