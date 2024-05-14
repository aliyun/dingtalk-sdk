<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOpenCategoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 5555
     *
     * @var int
     */
    public $libraryId;

    /**
     * @description This parameter is required.
     *
     * @example Jxi12wo3qxoa
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 0
     *
     * @var int
     */
    public $parentId;

    /**
     * @description This parameter is required.
     *
     * @example 测试类目
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 0159003451667222
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example 钉三多
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'libraryId'  => 'libraryId',
        'openTeamId' => 'openTeamId',
        'parentId'   => 'parentId',
        'title'      => 'title',
        'userId'     => 'userId',
        'userName'   => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->libraryId) {
            $res['libraryId'] = $this->libraryId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOpenCategoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['libraryId'])) {
            $model->libraryId = $map['libraryId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
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

        return $model;
    }
}
