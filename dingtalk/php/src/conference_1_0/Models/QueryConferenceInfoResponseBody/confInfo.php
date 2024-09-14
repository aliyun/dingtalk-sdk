<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody\confInfo\extensionAppSettings;
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
     * @var string
     */
    public $bizType;

    /**
     * @var string
     */
    public $cloudRecordOwnerUnionId;

    /**
     * @var int
     */
    public $cloudRecordStatus;

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
     * @var extensionAppSettings[]
     */
    public $extensionAppSettings;

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
     * @var string
     */
    public $minutesOwnerUnionId;

    /**
     * @var int
     */
    public $minutesStatus;

    /**
     * @example 42726033559
     *
     * @var string
     */
    public $roomCode;

    /**
     * @var string
     */
    public $scheduleConferenceId;

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
        'activeNum'               => 'activeNum',
        'attendNum'               => 'attendNum',
        'bizType'                 => 'bizType',
        'cloudRecordOwnerUnionId' => 'cloudRecordOwnerUnionId',
        'cloudRecordStatus'       => 'cloudRecordStatus',
        'confDuration'            => 'confDuration',
        'conferenceId'            => 'conferenceId',
        'creatorId'               => 'creatorId',
        'creatorNick'             => 'creatorNick',
        'endTime'                 => 'endTime',
        'extensionAppSettings'    => 'extensionAppSettings',
        'externalLinkUrl'         => 'externalLinkUrl',
        'invitedNum'              => 'invitedNum',
        'minutesOwnerUnionId'     => 'minutesOwnerUnionId',
        'minutesStatus'           => 'minutesStatus',
        'roomCode'                => 'roomCode',
        'scheduleConferenceId'    => 'scheduleConferenceId',
        'startTime'               => 'startTime',
        'status'                  => 'status',
        'title'                   => 'title',
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
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->cloudRecordOwnerUnionId) {
            $res['cloudRecordOwnerUnionId'] = $this->cloudRecordOwnerUnionId;
        }
        if (null !== $this->cloudRecordStatus) {
            $res['cloudRecordStatus'] = $this->cloudRecordStatus;
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
        if (null !== $this->extensionAppSettings) {
            $res['extensionAppSettings'] = [];
            if (null !== $this->extensionAppSettings && \is_array($this->extensionAppSettings)) {
                $n = 0;
                foreach ($this->extensionAppSettings as $item) {
                    $res['extensionAppSettings'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->externalLinkUrl) {
            $res['externalLinkUrl'] = $this->externalLinkUrl;
        }
        if (null !== $this->invitedNum) {
            $res['invitedNum'] = $this->invitedNum;
        }
        if (null !== $this->minutesOwnerUnionId) {
            $res['minutesOwnerUnionId'] = $this->minutesOwnerUnionId;
        }
        if (null !== $this->minutesStatus) {
            $res['minutesStatus'] = $this->minutesStatus;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
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
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['cloudRecordOwnerUnionId'])) {
            $model->cloudRecordOwnerUnionId = $map['cloudRecordOwnerUnionId'];
        }
        if (isset($map['cloudRecordStatus'])) {
            $model->cloudRecordStatus = $map['cloudRecordStatus'];
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
        if (isset($map['extensionAppSettings'])) {
            if (!empty($map['extensionAppSettings'])) {
                $model->extensionAppSettings = [];
                $n                           = 0;
                foreach ($map['extensionAppSettings'] as $item) {
                    $model->extensionAppSettings[$n++] = null !== $item ? extensionAppSettings::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['externalLinkUrl'])) {
            $model->externalLinkUrl = $map['externalLinkUrl'];
        }
        if (isset($map['invitedNum'])) {
            $model->invitedNum = $map['invitedNum'];
        }
        if (isset($map['minutesOwnerUnionId'])) {
            $model->minutesOwnerUnionId = $map['minutesOwnerUnionId'];
        }
        if (isset($map['minutesStatus'])) {
            $model->minutesStatus = $map['minutesStatus'];
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
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
