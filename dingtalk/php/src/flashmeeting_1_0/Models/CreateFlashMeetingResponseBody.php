<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFlashMeetingResponseBody extends Model
{
    /**
     * @description 闪会结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 闪会开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 闪会标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 闪会url
     *
     * @var string
     */
    public $url;

    /**
     * @description 闪会的key
     *
     * @var string
     */
    public $flashMeetingKey;
    protected $_name = [
        'endTime'         => 'endTime',
        'startTime'       => 'startTime',
        'title'           => 'title',
        'url'             => 'url',
        'flashMeetingKey' => 'flashMeetingKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->flashMeetingKey) {
            $res['flashMeetingKey'] = $this->flashMeetingKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFlashMeetingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['flashMeetingKey'])) {
            $model->flashMeetingKey = $map['flashMeetingKey'];
        }

        return $model;
    }
}
