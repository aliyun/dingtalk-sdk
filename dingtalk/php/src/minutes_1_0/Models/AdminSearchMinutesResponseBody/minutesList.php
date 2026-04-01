<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\AdminSearchMinutesResponseBody;

use AlibabaCloud\Tea\Model;

class minutesList extends Model
{
    /**
     * @var int
     */
    public $bizType;

    /**
     * @var string
     */
    public $creatorNick;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var string
     */
    public $fullTextSummary;

    /**
     * @var string
     */
    public $originalText;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $taskUuid;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'bizType' => 'bizType',
        'creatorNick' => 'creatorNick',
        'creatorUnionId' => 'creatorUnionId',
        'duration' => 'duration',
        'fullTextSummary' => 'fullTextSummary',
        'originalText' => 'originalText',
        'startTime' => 'startTime',
        'status' => 'status',
        'taskUuid' => 'taskUuid',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->fullTextSummary) {
            $res['fullTextSummary'] = $this->fullTextSummary;
        }
        if (null !== $this->originalText) {
            $res['originalText'] = $this->originalText;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskUuid) {
            $res['taskUuid'] = $this->taskUuid;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return minutesList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['fullTextSummary'])) {
            $model->fullTextSummary = $map['fullTextSummary'];
        }
        if (isset($map['originalText'])) {
            $model->originalText = $map['originalText'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskUuid'])) {
            $model->taskUuid = $map['taskUuid'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
