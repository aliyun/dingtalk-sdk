<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConferenceDetailResponseBody\memberList;
use AlibabaCloud\Tea\Model;

class GetConferenceDetailResponseBody extends Model
{
    /**
     * @description 出席会议人数
     *
     * @var int
     */
    public $attendeeNum;

    /**
     * @description 出席率
     *
     * @var string
     */
    public $attendeePercentage;

    /**
     * @description 发起人uid
     *
     * @var string
     */
    public $callerId;

    /**
     * @description 发起人昵称
     *
     * @var string
     */
    public $callerName;

    /**
     * @description 开始时间
     *
     * @var float
     */
    public $confStartTime;

    /**
     * @description 会议ID
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 持续时间
     *
     * @var float
     */
    public $duration;

    /**
     * @description 参会人员列表
     *
     * @var memberList[]
     */
    public $memberList;

    /**
     * @description 会议标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 会议人数
     *
     * @var int
     */
    public $totalNum;
    protected $_name = [
        'attendeeNum'        => 'attendeeNum',
        'attendeePercentage' => 'attendeePercentage',
        'callerId'           => 'callerId',
        'callerName'         => 'callerName',
        'confStartTime'      => 'confStartTime',
        'conferenceId'       => 'conferenceId',
        'duration'           => 'duration',
        'memberList'         => 'memberList',
        'title'              => 'title',
        'totalNum'           => 'totalNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendeeNum) {
            $res['attendeeNum'] = $this->attendeeNum;
        }
        if (null !== $this->attendeePercentage) {
            $res['attendeePercentage'] = $this->attendeePercentage;
        }
        if (null !== $this->callerId) {
            $res['callerId'] = $this->callerId;
        }
        if (null !== $this->callerName) {
            $res['callerName'] = $this->callerName;
        }
        if (null !== $this->confStartTime) {
            $res['confStartTime'] = $this->confStartTime;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->memberList) {
            $res['memberList'] = [];
            if (null !== $this->memberList && \is_array($this->memberList)) {
                $n = 0;
                foreach ($this->memberList as $item) {
                    $res['memberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->totalNum) {
            $res['totalNum'] = $this->totalNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConferenceDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendeeNum'])) {
            $model->attendeeNum = $map['attendeeNum'];
        }
        if (isset($map['attendeePercentage'])) {
            $model->attendeePercentage = $map['attendeePercentage'];
        }
        if (isset($map['callerId'])) {
            $model->callerId = $map['callerId'];
        }
        if (isset($map['callerName'])) {
            $model->callerName = $map['callerName'];
        }
        if (isset($map['confStartTime'])) {
            $model->confStartTime = $map['confStartTime'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['memberList'])) {
            if (!empty($map['memberList'])) {
                $model->memberList = [];
                $n                 = 0;
                foreach ($map['memberList'] as $item) {
                    $model->memberList[$n++] = null !== $item ? memberList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['totalNum'])) {
            $model->totalNum = $map['totalNum'];
        }

        return $model;
    }
}
