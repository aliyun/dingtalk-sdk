<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo\mediaContents;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo\recommends;
use AlibabaCloud\Tea\Model;

class feedInfo extends Model
{
    /**
     * @description 请求的行为，是保存还是发布,1为save，2为publish，是修改还是新建取决于feedId是否为空
     *
     * @var int
     */
    public $actionType;

    /**
     * @description 版权所属:1：自有， 2.代理， 3.钉钉
     *
     * @var int
     */
    public $belongsTo;

    /**
     * @description 内容分类，课程分类列表详情请见附录中的列表
     *
     * @var int
     */
    public $feedCategory;

    /**
     * @description 可选参数，当feedId不为null时，表示对当前课程进行修改，否则为新建一个课程
     *
     * @var string
     */
    public $feedId;

    /**
     * @description 课程的文字标签
     *
     * @var string
     */
    public $feedTag;

    /**
     * @description 内容类别,限制只能使用4种类型：0：免费 4：平价 5：专栏 6：训练营
     *
     * @var int
     */
    public $feedType;

    /**
     * @description 行业划分，决定了展示的页面的不同，例如学习中心下的职场、教育、商学院的划分,目前支持的行业id有：10001：职场学堂，10008：K12教育，10023：新职业，10024：钉钉培训
     *
     * @var int
     */
    public $industryId;

    /**
     * @description 课程的描述
     *
     * @var string
     */
    public $introduction;

    /**
     * @description 课程简介用的图片
     *
     * @var string
     */
    public $introductionPicUrl;

    /**
     * @description 入驻账号Id(请联系钉钉接口同学获取)
     *
     * @var string
     */
    public $mcnId;

    /**
     * @description 一个课程下可以有多个视频或音频教程
     *
     * @var mediaContents[]
     */
    public $mediaContents;

    /**
     * @description 推荐内容集合
     *
     * @var recommends[]
     */
    public $recommends;

    /**
     * @description 课程的封面Url
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @description 内容的标题（标题不能重复）
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
