<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOpenLibraryRequest extends Model
{
    /**
     * @example 这个是业务知识库
     *
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @example Jxi12wo3qxoa
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description This parameter is required.
     *
     * @example XMD
     *
     * @var string
     */
    public $source;

    /**
     * @description This parameter is required.
     *
     * @example 测试库
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example EXTERNAL
     *
     * @var string
     */
    public $type;

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
        'description' => 'description',
        'openTeamId' => 'openTeamId',
        'source' => 'source',
        'title' => 'title',
        'type' => 'type',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

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
