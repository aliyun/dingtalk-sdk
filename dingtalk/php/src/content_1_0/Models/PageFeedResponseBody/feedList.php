<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedResponseBody;

use AlibabaCloud\Tea\Model;

class feedList extends Model
{
    /**
     * @description 内容分类，请见https://developers.dingtalk.com/document/app/appendix-content
     *
     * @var string
     */
    public $feedCategory;

    /**
     * @description 内容Id
     *
     * @var string
     */
    public $feedId;

    /**
     * @description 内容类型，0：免费内容 4：平价内容 5：专栏内容 6：训练营内容
     *
     * @var int
     */
    public $feedType;

    /**
     * @description 内容名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 封面URL
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @description 跳转Url，跳转到职场学堂后台页面
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'feedCategory' => 'feedCategory',
        'feedId'       => 'feedId',
        'feedType'     => 'feedType',
        'name'         => 'name',
        'thumbUrl'     => 'thumbUrl',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feedCategory) {
            $res['feedCategory'] = $this->feedCategory;
        }
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return feedList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feedCategory'])) {
            $model->feedCategory = $map['feedCategory'];
        }
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
