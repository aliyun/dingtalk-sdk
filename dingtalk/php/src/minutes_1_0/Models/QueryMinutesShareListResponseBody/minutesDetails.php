<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesShareListResponseBody;

use AlibabaCloud\Tea\Model;

class minutesDetails extends Model
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
    public $durationMicros;

    /**
     * @var int
     */
    public $isDeleted;

    /**
     * @var int
     */
    public $size;

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
        'bizType'        => 'bizType',
        'creatorNick'    => 'creatorNick',
        'creatorUnionId' => 'creatorUnionId',
        'durationMicros' => 'durationMicros',
        'isDeleted'      => 'isDeleted',
        'size'           => 'size',
        'startTime'      => 'startTime',
        'status'         => 'status',
        'taskUuid'       => 'taskUuid',
        'title'          => 'title',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->durationMicros) {
            $res['durationMicros'] = $this->durationMicros;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
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
     * @return minutesDetails
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
        if (isset($map['durationMicros'])) {
            $model->durationMicros = $map['durationMicros'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
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
