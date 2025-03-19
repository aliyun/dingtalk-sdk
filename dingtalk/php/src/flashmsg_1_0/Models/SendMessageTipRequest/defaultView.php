<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\SendMessageTipRequest;

use AlibabaCloud\Tea\Model;

class defaultView extends Model
{
    /**
     * @var string
     */
    public $actionName;

    /**
     * @var string
     */
    public $actionUrl;

    /**
     * @var string
     */
    public $authCode;

    /**
     * @var string
     */
    public $authMediaId;

    /**
     * @example 闪读消息卡片1
     *
     * @var string
     */
    public $cardTitle;

    /**
     * @var string
     */
    public $cardTitleColor;

    /**
     * @example 查看详情
     *
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @var string
     */
    public $needShowUpdateTail;

    /**
     * @var string
     */
    public $summary;

    /**
     * @example 闪读消息卡片2
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionName' => 'actionName',
        'actionUrl' => 'actionUrl',
        'authCode' => 'authCode',
        'authMediaId' => 'authMediaId',
        'cardTitle' => 'cardTitle',
        'cardTitleColor' => 'cardTitleColor',
        'desc' => 'desc',
        'mediaId' => 'mediaId',
        'needShowUpdateTail' => 'needShowUpdateTail',
        'summary' => 'summary',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->actionUrl) {
            $res['actionUrl'] = $this->actionUrl;
        }
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->authMediaId) {
            $res['authMediaId'] = $this->authMediaId;
        }
        if (null !== $this->cardTitle) {
            $res['cardTitle'] = $this->cardTitle;
        }
        if (null !== $this->cardTitleColor) {
            $res['cardTitleColor'] = $this->cardTitleColor;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->needShowUpdateTail) {
            $res['needShowUpdateTail'] = $this->needShowUpdateTail;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return defaultView
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['actionUrl'])) {
            $model->actionUrl = $map['actionUrl'];
        }
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['authMediaId'])) {
            $model->authMediaId = $map['authMediaId'];
        }
        if (isset($map['cardTitle'])) {
            $model->cardTitle = $map['cardTitle'];
        }
        if (isset($map['cardTitleColor'])) {
            $model->cardTitleColor = $map['cardTitleColor'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['needShowUpdateTail'])) {
            $model->needShowUpdateTail = $map['needShowUpdateTail'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
