<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody;

use AlibabaCloud\Tea\Model;

class confInfo extends Model
{
    /**
     * @description 当前在会人数
     *
     * @var int
     */
    public $activeNum;

    /**
     * @description 累积入会人数
     *
     * @var int
     */
    public $attendNum;

    /**
     * @description 会议时长
     *
     * @var int
     */
    public $confDuration;

    /**
     * @description 会议id
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 会议创建人unionId
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 会议创建人昵称
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @description 会议结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 会议web入会链接
     *
     * @var string
     */
    public $externalLinkUrl;

    /**
     * @description 邀请人数
     *
     * @var int
     */
    public $invitedNum;

    /**
     * @description 会议码
     *
     * @var string
     */
    public $roomCode;

    /**
     * @description 会议开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 会议状态
     * 2 结束
     * @var int
     */
    public $status;

    /**
     * @description 会议标题
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
