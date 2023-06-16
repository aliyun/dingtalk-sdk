<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetHistoryConfDataListResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 6449d8a6414xxxxxxxx01464af9f0
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @example njMTqKo9xxxxEiE
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $creatorNick;

    /**
     * @example xxxxx
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 1682561790000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 0
     *
     * @var string
     */
    public $freeType;

    /**
     * @example ding_talk
     *
     * @var string
     */
    public $scene;

    /**
     * @example 1682561190000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 600000
     *
     * @var int
     */
    public $timeLength;

    /**
     * @example xxxxx视频会议
     *
     * @var string
     */
    public $title;

    /**
     * @example 2
     *
     * @var int
     */
    public $userCount;
    protected $_name = [
        'conferenceId' => 'conferenceId',
        'creatorId'    => 'creatorId',
        'creatorNick'  => 'creatorNick',
        'deptName'     => 'deptName',
        'endTime'      => 'endTime',
        'freeType'     => 'freeType',
        'scene'        => 'scene',
        'startTime'    => 'startTime',
        'timeLength'   => 'timeLength',
        'title'        => 'title',
        'userCount'    => 'userCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->freeType) {
            $res['freeType'] = $this->freeType;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->timeLength) {
            $res['timeLength'] = $this->timeLength;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userCount) {
            $res['userCount'] = $this->userCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['freeType'])) {
            $model->freeType = $map['freeType'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['timeLength'])) {
            $model->timeLength = $map['timeLength'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userCount'])) {
            $model->userCount = $map['userCount'];
        }

        return $model;
    }
}
