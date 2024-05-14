<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFlashMeetingResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $flashMeetingKey;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'endTime'         => 'endTime',
        'flashMeetingKey' => 'flashMeetingKey',
        'startTime'       => 'startTime',
        'title'           => 'title',
        'url'             => 'url',
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
        if (null !== $this->flashMeetingKey) {
            $res['flashMeetingKey'] = $this->flashMeetingKey;
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
        if (isset($map['flashMeetingKey'])) {
            $model->flashMeetingKey = $map['flashMeetingKey'];
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

        return $model;
    }
}
