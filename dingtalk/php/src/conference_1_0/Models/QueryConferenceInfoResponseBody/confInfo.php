<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody;

use AlibabaCloud\Tea\Model;

class confInfo extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $activeNum;

    /**
     * @example 15
     *
     * @var int
     */
    public $attendNum;

    /**
     * @example 1000000
     *
     * @var int
     */
    public $confDuration;

    /**
     * @example 6323d7568777190142ab9d10
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 昵称
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @example https://meeting.dingtalk.com/app?roomCode=42726033559&token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c
     *
     * @var string
     */
    public $externalLinkUrl;

    /**
     * @example 20
     *
     * @var int
     */
    public $invitedNum;

    /**
     * @example 42726033559
     *
     * @var string
     */
    public $roomCode;

    /**
     * @example 1663293270000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'activeNum'       => 'activeNum',
        'attendNum'       => 'attendNum',
        'confDuration'    => 'confDuration',
        'conferenceId'    => 'conferenceId',
        'creatorId'       => 'creatorId',
        'creatorNick'     => 'creatorNick',
        'endTime'         => 'endTime',
        'externalLinkUrl' => 'externalLinkUrl',
        'invitedNum'      => 'invitedNum',
        'roomCode'        => 'roomCode',
        'startTime'       => 'startTime',
        'status'          => 'status',
        'title'           => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activeNum) {
            $res['activeNum'] = $this->activeNum;
        }
        if (null !== $this->attendNum) {
            $res['attendNum'] = $this->attendNum;
        }
        if (null !== $this->confDuration) {
            $res['confDuration'] = $this->confDuration;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->externalLinkUrl) {
            $res['externalLinkUrl'] = $this->externalLinkUrl;
        }
        if (null !== $this->invitedNum) {
            $res['invitedNum'] = $this->invitedNum;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return confInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activeNum'])) {
            $model->activeNum = $map['activeNum'];
        }
        if (isset($map['attendNum'])) {
            $model->attendNum = $map['attendNum'];
        }
        if (isset($map['confDuration'])) {
            $model->confDuration = $map['confDuration'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['externalLinkUrl'])) {
            $model->externalLinkUrl = $map['externalLinkUrl'];
        }
        if (isset($map['invitedNum'])) {
            $model->invitedNum = $map['invitedNum'];
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
