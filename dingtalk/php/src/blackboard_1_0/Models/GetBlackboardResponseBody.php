<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\GetBlackboardResponseBody\attachments;
use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\GetBlackboardResponseBody\deptList;
use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\GetBlackboardResponseBody\userList;
use AlibabaCloud\Tea\Model;

class GetBlackboardResponseBody extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;

    /**
     * @example example_category_id
     *
     * @var string
     */
    public $categoryId;

    /**
     * @example 分类示例
     *
     * @var string
     */
    public $categoryName;

    /**
     * @example 公告内容示例
     *
     * @var string
     */
    public $content;

    /**
     * @example https://down.dingtalk.com/ddmedia/xxxx.png?ddFrom=blackboard.pic
     *
     * @var string
     */
    public $coverPicUrl;

    /**
     * @var string[]
     */
    public $depNameList;

    /**
     * @var deptList[]
     */
    public $deptList;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2025-01-01 00:00:00
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example fbeaxxxxxxxxxxxxxxxxxxxxxxxxe292
     *
     * @var string
     */
    public $id;

    /**
     * @example 0
     *
     * @var int
     */
    public $isPushTop;

    /**
     * @example 0
     *
     * @var int
     */
    public $privateLevel;

    /**
     * @example 1
     *
     * @var int
     */
    public $readCount;

    /**
     * @example manager01
     *
     * @var string
     */
    public $senderStaffId;

    /**
     * @example 公告标题实例
     *
     * @var string
     */
    public $title;

    /**
     * @example 1
     *
     * @var int
     */
    public $unReadCount;

    /**
     * @var userList[]
     */
    public $userList;

    /**
     * @var string[]
     */
    public $userNameList;
    protected $_name = [
        'attachments' => 'attachments',
        'categoryId' => 'categoryId',
        'categoryName' => 'categoryName',
        'content' => 'content',
        'coverPicUrl' => 'coverPicUrl',
        'depNameList' => 'depNameList',
        'deptList' => 'deptList',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'id' => 'id',
        'isPushTop' => 'isPushTop',
        'privateLevel' => 'privateLevel',
        'readCount' => 'readCount',
        'senderStaffId' => 'senderStaffId',
        'title' => 'title',
        'unReadCount' => 'unReadCount',
        'userList' => 'userList',
        'userNameList' => 'userNameList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->categoryId) {
            $res['categoryId'] = $this->categoryId;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->coverPicUrl) {
            $res['coverPicUrl'] = $this->coverPicUrl;
        }
        if (null !== $this->depNameList) {
            $res['depNameList'] = $this->depNameList;
        }
        if (null !== $this->deptList) {
            $res['deptList'] = [];
            if (null !== $this->deptList && \is_array($this->deptList)) {
                $n = 0;
                foreach ($this->deptList as $item) {
                    $res['deptList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isPushTop) {
            $res['isPushTop'] = $this->isPushTop;
        }
        if (null !== $this->privateLevel) {
            $res['privateLevel'] = $this->privateLevel;
        }
        if (null !== $this->readCount) {
            $res['readCount'] = $this->readCount;
        }
        if (null !== $this->senderStaffId) {
            $res['senderStaffId'] = $this->senderStaffId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unReadCount) {
            $res['unReadCount'] = $this->unReadCount;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userNameList) {
            $res['userNameList'] = $this->userNameList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBlackboardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['categoryId'])) {
            $model->categoryId = $map['categoryId'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['coverPicUrl'])) {
            $model->coverPicUrl = $map['coverPicUrl'];
        }
        if (isset($map['depNameList'])) {
            if (!empty($map['depNameList'])) {
                $model->depNameList = $map['depNameList'];
            }
        }
        if (isset($map['deptList'])) {
            if (!empty($map['deptList'])) {
                $model->deptList = [];
                $n = 0;
                foreach ($map['deptList'] as $item) {
                    $model->deptList[$n++] = null !== $item ? deptList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isPushTop'])) {
            $model->isPushTop = $map['isPushTop'];
        }
        if (isset($map['privateLevel'])) {
            $model->privateLevel = $map['privateLevel'];
        }
        if (isset($map['readCount'])) {
            $model->readCount = $map['readCount'];
        }
        if (isset($map['senderStaffId'])) {
            $model->senderStaffId = $map['senderStaffId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unReadCount'])) {
            $model->unReadCount = $map['unReadCount'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userNameList'])) {
            if (!empty($map['userNameList'])) {
                $model->userNameList = $map['userNameList'];
            }
        }

        return $model;
    }
}
