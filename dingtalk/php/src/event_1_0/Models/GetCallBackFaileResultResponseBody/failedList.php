<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponseBody;

use AlibabaCloud\Tea\Model;

class failedList extends Model
{
    /**
     * @example {\"CalendarEventUpdateTime\":1668735924619,\"CorpId\":\"ding9**cd16741\",\"ChangeType\":\"updated\",\"EventType\":\"calendar_event_change\",\"CalendarId\":\"NzE3MjU0NEB1c2V***5jb218MTQwMDE2\",\"EventTime\":1668735924640,\"LegacyCalendarEventId\":\"1C1BB56076***8A338\",\"BizId\":\"1668**4640\",\"CalendarEventId\":\"RVNUZllHK**elEydz09\",\"operator\":{\"type\":\"user\"},\"UnionIdList\":[\"QQa**mYiE\"]}
     *
     * @var string
     */
    public $callBackData;

    /**
     * @example calendar_event_change
     *
     * @var string
     */
    public $callBackTag;

    /**
     * @example ding9f50b15b*****41
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 166***39184
     *
     * @var int
     */
    public $eventTime;
    protected $_name = [
        'callBackData' => 'callBackData',
        'callBackTag' => 'callBackTag',
        'corpId' => 'corpId',
        'eventTime' => 'eventTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->callBackData) {
            $res['callBackData'] = $this->callBackData;
        }
        if (null !== $this->callBackTag) {
            $res['callBackTag'] = $this->callBackTag;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->eventTime) {
            $res['eventTime'] = $this->eventTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failedList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callBackData'])) {
            $model->callBackData = $map['callBackData'];
        }
        if (isset($map['callBackTag'])) {
            $model->callBackTag = $map['callBackTag'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['eventTime'])) {
            $model->eventTime = $map['eventTime'];
        }

        return $model;
    }
}
