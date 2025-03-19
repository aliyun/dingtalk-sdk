<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushDingMessageRequest extends Model
{
    /**
     * @example 10001
     *
     * @var int
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @example 消息内容
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example CARD
     *
     * @var string
     */
    public $messageType;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $messageUrl;

    /**
     * @example http://pic.616pic.com/ys_b_img/00/27/71/Uu8E6C2Edn.jpg
     *
     * @var string
     */
    public $pictureUrl;

    /**
     * @example 转跳链接
     *
     * @var string
     */
    public $singleTitle;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $singleUrl;

    /**
     * @example 消息title
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'appId' => 'appId',
        'content' => 'content',
        'messageType' => 'messageType',
        'messageUrl' => 'messageUrl',
        'pictureUrl' => 'pictureUrl',
        'singleTitle' => 'singleTitle',
        'singleUrl' => 'singleUrl',
        'title' => 'title',
        'userIdList' => 'userIdList',
    ];

    public function validate() {}

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
