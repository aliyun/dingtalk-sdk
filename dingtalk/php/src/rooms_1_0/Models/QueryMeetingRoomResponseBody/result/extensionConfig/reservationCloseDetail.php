<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\extensionConfig;

use AlibabaCloud\Tea\Model;

class reservationCloseDetail extends Model
{
    /**
     * @example 因为装修临时关闭预定
     *
     * @var string
     */
    public $closeReason;

    /**
     * @example nick
     *
     * @var string
     */
    public $contactNick;

    /**
     * @example 2iPOLbpxxxxuwggiiqiPwiEiF
     *
     * @var string
     */
    public $contactUnionId;

    /**
     * @var bool
     */
    public $sendNotify;

    /**
     * @example 1740045030000
     *
     * @var int
     */
    public $taskEndTime;

    /**
     * @example 1740463800000
     *
     * @var int
     */
    public $taskStartTime;
    protected $_name = [
        'closeReason' => 'closeReason',
        'contactNick' => 'contactNick',
        'contactUnionId' => 'contactUnionId',
        'sendNotify' => 'sendNotify',
        'taskEndTime' => 'taskEndTime',
        'taskStartTime' => 'taskStartTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->closeReason) {
            $res['closeReason'] = $this->closeReason;
        }
        if (null !== $this->contactNick) {
            $res['contactNick'] = $this->contactNick;
        }
        if (null !== $this->contactUnionId) {
            $res['contactUnionId'] = $this->contactUnionId;
        }
        if (null !== $this->sendNotify) {
            $res['sendNotify'] = $this->sendNotify;
        }
        if (null !== $this->taskEndTime) {
            $res['taskEndTime'] = $this->taskEndTime;
        }
        if (null !== $this->taskStartTime) {
            $res['taskStartTime'] = $this->taskStartTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reservationCloseDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['closeReason'])) {
            $model->closeReason = $map['closeReason'];
        }
        if (isset($map['contactNick'])) {
            $model->contactNick = $map['contactNick'];
        }
        if (isset($map['contactUnionId'])) {
            $model->contactUnionId = $map['contactUnionId'];
        }
        if (isset($map['sendNotify'])) {
            $model->sendNotify = $map['sendNotify'];
        }
        if (isset($map['taskEndTime'])) {
            $model->taskEndTime = $map['taskEndTime'];
        }
        if (isset($map['taskStartTime'])) {
            $model->taskStartTime = $map['taskStartTime'];
        }

        return $model;
    }
}
