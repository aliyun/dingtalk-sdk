<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFlashMeetingRequest extends Model
{
    /**
     * @description 日程id
     *
     * @var string
     */
    public $eventId;

    /**
     * @description 钉闪会名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 创建人union id
     *
     * @var string
     */
    public $creator;
    protected $_name = [
        'eventId' => 'eventId',
        'title'   => 'title',
        'creator' => 'creator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFlashMeetingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }

        return $model;
    }
}
