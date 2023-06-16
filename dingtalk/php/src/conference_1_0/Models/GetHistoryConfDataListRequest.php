<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetHistoryConfDataListRequest extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $creatorNike;

    /**
     * @example 1682611199000
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
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example xxx9uZ0bVGoqjxxxxxxxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var bool
     */
    public $realData;

    /**
     * @example ding_talk
     *
     * @var string
     */
    public $scene;

    /**
     * @example 1682524800000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example xxxxx视频会议
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'creatorNike' => 'creatorNike',
        'endTime'     => 'endTime',
        'freeType'    => 'freeType',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'realData'    => 'realData',
        'scene'       => 'scene',
        'startTime'   => 'startTime',
        'title'       => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorNike) {
            $res['creatorNike'] = $this->creatorNike;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->freeType) {
            $res['freeType'] = $this->freeType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->realData) {
            $res['realData'] = $this->realData;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetHistoryConfDataListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorNike'])) {
            $model->creatorNike = $map['creatorNike'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['freeType'])) {
            $model->freeType = $map['freeType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['realData'])) {
            $model->realData = $map['realData'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
