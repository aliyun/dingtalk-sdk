<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddLibraryRequest extends Model
{
    /**
     * @description 知识库描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 团队id列表
     *
     * @var string[]
     */
    public $openTeamIds;

    /**
     * @description 知识来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 知识库的唯一性标识
     *
     * @var string
     */
    public $sourcePrimaryKey;

    /**
     * @description 知识库名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 知识库类型 INTERNAL:内部知识库 EXTERNAL:外部知识库
     *
     * @var string
     */
    public $type;

    /**
     * @description 员工ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'description'      => 'description',
        'openTeamIds'      => 'openTeamIds',
        'source'           => 'source',
        'sourcePrimaryKey' => 'sourcePrimaryKey',
        'title'            => 'title',
        'type'             => 'type',
        'userId'           => 'userId',
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
        if (null !== $this->openTeamIds) {
            $res['openTeamIds'] = $this->openTeamIds;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sourcePrimaryKey) {
            $res['sourcePrimaryKey'] = $this->sourcePrimaryKey;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLibraryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['openTeamIds'])) {
            if (!empty($map['openTeamIds'])) {
                $model->openTeamIds = $map['openTeamIds'];
            }
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sourcePrimaryKey'])) {
            $model->sourcePrimaryKey = $map['sourcePrimaryKey'];
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

        return $model;
    }
}
