<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\ListActivityResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 5tL2HIQiQiOARCZ6xWAPHA02091683513
     *
     * @var string
     */
    public $activityId;

    /**
     * @example @mediaId
     *
     * @var string
     */
    public $bannerMediaId;

    /**
     * @example 1683515695000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 20230613_001
     *
     * @var string
     */
    public $foreignId;

    /**
     * @example 1683514695000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 3
     *
     * @var string
     */
    public $status;

    /**
     * @example AIGC研讨会
     *
     * @var string
     */
    public $title;

    /**
     * @example 0
     *
     * @var string
     */
    public $type;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'activityId'    => 'activityId',
        'bannerMediaId' => 'bannerMediaId',
        'endTime'       => 'endTime',
        'foreignId'     => 'foreignId',
        'startTime'     => 'startTime',
        'status'        => 'status',
        'title'         => 'title',
        'type'          => 'type',
        'url'           => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->bannerMediaId) {
            $res['bannerMediaId'] = $this->bannerMediaId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['bannerMediaId'])) {
            $model->bannerMediaId = $map['bannerMediaId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
