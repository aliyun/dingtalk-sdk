<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\calendars\scoreItem;
use AlibabaCloud\Tea\Model;

class calendars extends Model
{
    /**
     * @var int
     */
    public $creatorStaffId;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var bool
     */
    public $matchIntimacy;

    /**
     * @var string
     */
    public $material;

    /**
     * @var string
     */
    public $meetingRoom;

    /**
     * @var string[]
     */
    public $participantStaffIds;

    /**
     * @var string
     */
    public $rawComment;

    /**
     * @var string
     */
    public $refType;

    /**
     * @var float
     */
    public $score;

    /**
     * @var scoreItem
     */
    public $scoreItem;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $timestamp;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'creatorStaffId' => 'creatorStaffId',
        'endTime' => 'endTime',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon' => 'icon',
        'matchIntimacy' => 'matchIntimacy',
        'material' => 'material',
        'meetingRoom' => 'meetingRoom',
        'participantStaffIds' => 'participantStaffIds',
        'rawComment' => 'rawComment',
        'refType' => 'refType',
        'score' => 'score',
        'scoreItem' => 'scoreItem',
        'startTime' => 'startTime',
        'timestamp' => 'timestamp',
        'title' => 'title',
        'type' => 'type',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorStaffId) {
            $res['creatorStaffId'] = $this->creatorStaffId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->matchIntimacy) {
            $res['matchIntimacy'] = $this->matchIntimacy;
        }
        if (null !== $this->material) {
            $res['material'] = $this->material;
        }
        if (null !== $this->meetingRoom) {
            $res['meetingRoom'] = $this->meetingRoom;
        }
        if (null !== $this->participantStaffIds) {
            $res['participantStaffIds'] = $this->participantStaffIds;
        }
        if (null !== $this->rawComment) {
            $res['rawComment'] = $this->rawComment;
        }
        if (null !== $this->refType) {
            $res['refType'] = $this->refType;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->scoreItem) {
            $res['scoreItem'] = null !== $this->scoreItem ? $this->scoreItem->toMap() : null;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return calendars
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorStaffId'])) {
            $model->creatorStaffId = $map['creatorStaffId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['matchIntimacy'])) {
            $model->matchIntimacy = $map['matchIntimacy'];
        }
        if (isset($map['material'])) {
            $model->material = $map['material'];
        }
        if (isset($map['meetingRoom'])) {
            $model->meetingRoom = $map['meetingRoom'];
        }
        if (isset($map['participantStaffIds'])) {
            if (!empty($map['participantStaffIds'])) {
                $model->participantStaffIds = $map['participantStaffIds'];
            }
        }
        if (isset($map['rawComment'])) {
            $model->rawComment = $map['rawComment'];
        }
        if (isset($map['refType'])) {
            $model->refType = $map['refType'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['scoreItem'])) {
            $model->scoreItem = scoreItem::fromMap($map['scoreItem']);
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
