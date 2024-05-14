<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo\mediaContents;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo\recommends;
use AlibabaCloud\Tea\Model;

class feedInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $actionType;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $belongsTo;

    /**
     * @description This parameter is required.
     *
     * @example 200000257
     *
     * @var int
     */
    public $feedCategory;

    /**
     * @example c497****-8a89-****-bc9b-*****48610d3
     *
     * @var string
     */
    public $feedId;

    /**
     * @example 标签
     *
     * @var string
     */
    public $feedTag;

    /**
     * @description This parameter is required.
     *
     * @example 4
     *
     * @var int
     */
    public $feedType;

    /**
     * @example 10001
     *
     * @var int
     */
    public $industryId;

    /**
     * @description This parameter is required.
     *
     * @example 描述
     *
     * @var string
     */
    public $introduction;

    /**
     * @example https://static.dingtalk.com/media/**************NAlg_600_337.jpg
     *
     * @var string
     */
    public $introductionPicUrl;

    /**
     * @description This parameter is required.
     *
     * @example 50730********40554
     *
     * @var string
     */
    public $mcnId;

    /**
     * @description This parameter is required.
     *
     * @var mediaContents[]
     */
    public $mediaContents;

    /**
     * @var recommends[]
     */
    public $recommends;

    /**
     * @description This parameter is required.
     *
     * @example https://static.dingtalk.com/media/**************NAlg_600_337.jpg
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @description This parameter is required.
     *
     * @example 课程标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionType'         => 'actionType',
        'belongsTo'          => 'belongsTo',
        'feedCategory'       => 'feedCategory',
        'feedId'             => 'feedId',
        'feedTag'            => 'feedTag',
        'feedType'           => 'feedType',
        'industryId'         => 'industryId',
        'introduction'       => 'introduction',
        'introductionPicUrl' => 'introductionPicUrl',
        'mcnId'              => 'mcnId',
        'mediaContents'      => 'mediaContents',
        'recommends'         => 'recommends',
        'thumbUrl'           => 'thumbUrl',
        'title'              => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->belongsTo) {
            $res['belongsTo'] = $this->belongsTo;
        }
        if (null !== $this->feedCategory) {
            $res['feedCategory'] = $this->feedCategory;
        }
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->feedTag) {
            $res['feedTag'] = $this->feedTag;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->industryId) {
            $res['industryId'] = $this->industryId;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->introductionPicUrl) {
            $res['introductionPicUrl'] = $this->introductionPicUrl;
        }
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }
        if (null !== $this->mediaContents) {
            $res['mediaContents'] = [];
            if (null !== $this->mediaContents && \is_array($this->mediaContents)) {
                $n = 0;
                foreach ($this->mediaContents as $item) {
                    $res['mediaContents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->recommends) {
            $res['recommends'] = [];
            if (null !== $this->recommends && \is_array($this->recommends)) {
                $n = 0;
                foreach ($this->recommends as $item) {
                    $res['recommends'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return feedInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['belongsTo'])) {
            $model->belongsTo = $map['belongsTo'];
        }
        if (isset($map['feedCategory'])) {
            $model->feedCategory = $map['feedCategory'];
        }
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['feedTag'])) {
            $model->feedTag = $map['feedTag'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['industryId'])) {
            $model->industryId = $map['industryId'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['introductionPicUrl'])) {
            $model->introductionPicUrl = $map['introductionPicUrl'];
        }
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }
        if (isset($map['mediaContents'])) {
            if (!empty($map['mediaContents'])) {
                $model->mediaContents = [];
                $n                    = 0;
                foreach ($map['mediaContents'] as $item) {
                    $model->mediaContents[$n++] = null !== $item ? mediaContents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['recommends'])) {
            if (!empty($map['recommends'])) {
                $model->recommends = [];
                $n                 = 0;
                foreach ($map['recommends'] as $item) {
                    $model->recommends[$n++] = null !== $item ? recommends::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
