<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityRequest;

use AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models\CreateActivityRequest\detail\address;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @var address
     */
    public $address;

    /**
     * @example @mediaId
     *
     * @var string
     */
    public $bannerMediaId;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @example 2OGnTRTcoH6OQ0209168
     *
     * @var string
     */
    public $foreignId;

    /**
     * @example IT
     *
     * @var string
     */
    public $industry;

    /**
     * @example CTO
     *
     * @var string
     */
    public $roleName;

    /**
     * @example hdx
     *
     * @var string
     */
    public $source;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @example 钉峰会
     *
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $type;

    /**
     * @example https://www.dingtalk.com/
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'address'       => 'address',
        'bannerMediaId' => 'bannerMediaId',
        'endTime'       => 'endTime',
        'foreignId'     => 'foreignId',
        'industry'      => 'industry',
        'roleName'      => 'roleName',
        'source'        => 'source',
        'startTime'     => 'startTime',
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
        if (null !== $this->address) {
            $res['address'] = null !== $this->address ? $this->address->toMap() : null;
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
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
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
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = address::fromMap($map['address']);
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
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
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
