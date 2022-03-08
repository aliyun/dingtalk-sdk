<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOpenLibraryRequest extends Model
{
    /**
     * @description 知识库描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 知识库来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 知识库名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 知识库类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 用户/员工ID
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
        'description' => 'description',
        'openTeamId'  => 'openTeamId',
        'source'      => 'source',
        'title'       => 'title',
        'type'        => 'type',
        'userId'      => 'userId',
        'userName'    => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
     * @return AddOpenLibraryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
