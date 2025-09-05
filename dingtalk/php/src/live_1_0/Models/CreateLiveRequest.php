<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateLiveRequest extends Model
{
    /**
     * @example https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @example true
     *
     * @var bool
     */
    public $enableLinkMic;

    /**
     * @example 测试直播简介
     *
     * @var string
     */
    public $introduction;

    /**
     * @example true
     *
     * @var bool
     */
    public $isLandscape;

    /**
     * @description This parameter is required.
     *
     * @example 1659653648000
     *
     * @var int
     */
    public $preEndTime;

    /**
     * @description This parameter is required.
     *
     * @example 1659613648000
     *
     * @var int
     */
    public $preStartTime;

    /**
     * @example 2
     *
     * @var int
     */
    public $publicType;

    /**
     * @description This parameter is required.
     *
     * @example 测试直播
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example DC7wZGOSueEEIGOf3WKwWgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'coverUrl' => 'coverUrl',
        'enableLinkMic' => 'enableLinkMic',
        'introduction' => 'introduction',
        'isLandscape' => 'isLandscape',
        'preEndTime' => 'preEndTime',
        'preStartTime' => 'preStartTime',
        'publicType' => 'publicType',
        'title' => 'title',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->enableLinkMic) {
            $res['enableLinkMic'] = $this->enableLinkMic;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->isLandscape) {
            $res['isLandscape'] = $this->isLandscape;
        }
        if (null !== $this->preEndTime) {
            $res['preEndTime'] = $this->preEndTime;
        }
        if (null !== $this->preStartTime) {
            $res['preStartTime'] = $this->preStartTime;
        }
        if (null !== $this->publicType) {
            $res['publicType'] = $this->publicType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateLiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['enableLinkMic'])) {
            $model->enableLinkMic = $map['enableLinkMic'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['isLandscape'])) {
            $model->isLandscape = $map['isLandscape'];
        }
        if (isset($map['preEndTime'])) {
            $model->preEndTime = $map['preEndTime'];
        }
        if (isset($map['preStartTime'])) {
            $model->preStartTime = $map['preStartTime'];
        }
        if (isset($map['publicType'])) {
            $model->publicType = $map['publicType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
