<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CirclePostDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CirclePostDetailResponseBody\result\products;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CirclePostDetailResponseBody\result\tagList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $deptName;

    /**
     * @var int
     */
    public $dislikeCount;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $likeCount;

    /**
     * @var string[]
     */
    public $mediaUrlList;

    /**
     * @var int
     */
    public $postId;

    /**
     * @var string
     */
    public $postType;

    /**
     * @var products[]
     */
    public $products;

    /**
     * @var string
     */
    public $status;

    /**
     * @var tagList[]
     */
    public $tagList;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;

    /**
     * @var int
     */
    public $viewCount;
    protected $_name = [
        'content' => 'content',
        'deptId' => 'deptId',
        'deptName' => 'deptName',
        'dislikeCount' => 'dislikeCount',
        'gmtCreate' => 'gmtCreate',
        'likeCount' => 'likeCount',
        'mediaUrlList' => 'mediaUrlList',
        'postId' => 'postId',
        'postType' => 'postType',
        'products' => 'products',
        'status' => 'status',
        'tagList' => 'tagList',
        'title' => 'title',
        'userId' => 'userId',
        'userName' => 'userName',
        'viewCount' => 'viewCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->dislikeCount) {
            $res['dislikeCount'] = $this->dislikeCount;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->likeCount) {
            $res['likeCount'] = $this->likeCount;
        }
        if (null !== $this->mediaUrlList) {
            $res['mediaUrlList'] = $this->mediaUrlList;
        }
        if (null !== $this->postId) {
            $res['postId'] = $this->postId;
        }
        if (null !== $this->postType) {
            $res['postType'] = $this->postType;
        }
        if (null !== $this->products) {
            $res['products'] = [];
            if (null !== $this->products && \is_array($this->products)) {
                $n = 0;
                foreach ($this->products as $item) {
                    $res['products'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tagList) {
            $res['tagList'] = [];
            if (null !== $this->tagList && \is_array($this->tagList)) {
                $n = 0;
                foreach ($this->tagList as $item) {
                    $res['tagList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->viewCount) {
            $res['viewCount'] = $this->viewCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['dislikeCount'])) {
            $model->dislikeCount = $map['dislikeCount'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['likeCount'])) {
            $model->likeCount = $map['likeCount'];
        }
        if (isset($map['mediaUrlList'])) {
            if (!empty($map['mediaUrlList'])) {
                $model->mediaUrlList = $map['mediaUrlList'];
            }
        }
        if (isset($map['postId'])) {
            $model->postId = $map['postId'];
        }
        if (isset($map['postType'])) {
            $model->postType = $map['postType'];
        }
        if (isset($map['products'])) {
            if (!empty($map['products'])) {
                $model->products = [];
                $n = 0;
                foreach ($map['products'] as $item) {
                    $model->products[$n++] = null !== $item ? products::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tagList'])) {
            if (!empty($map['tagList'])) {
                $model->tagList = [];
                $n = 0;
                foreach ($map['tagList'] as $item) {
                    $model->tagList[$n++] = null !== $item ? tagList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['viewCount'])) {
            $model->viewCount = $map['viewCount'];
        }

        return $model;
    }
}
