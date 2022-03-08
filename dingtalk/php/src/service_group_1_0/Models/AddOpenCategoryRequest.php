<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOpenCategoryRequest extends Model
{
    /**
     * @description 所属知识库ID
     *
     * @var int
     */
    public $libraryId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 父类目ID(为0代表顶层id)
     *
     * @var int
     */
    public $parentId;

    /**
     * @description 类目标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 员工/用户ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户昵称或姓名
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
