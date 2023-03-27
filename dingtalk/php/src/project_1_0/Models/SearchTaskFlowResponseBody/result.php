<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskFlowResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 绑定对象Id，此接口为项目id。
     *
     * @var string
     */
    public $boundToObjectId;

    /**
     * @description 绑定类型，增加项目成员默认是project。
     *
     * @var string
     */
    public $boundToObjectType;

    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建者id。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 是否已删除。
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 工作流名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 工作流ID。
     *
     * @var string
     */
    public $taskflowId;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'boundToObjectId'   => 'boundToObjectId',
        'boundToObjectType' => 'boundToObjectType',
        'created'           => 'created',
        'creatorId'         => 'creatorId',
        'isDeleted'         => 'isDeleted',
        'name'              => 'name',
        'taskflowId'        => 'taskflowId',
        'updated'           => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->boundToObjectId) {
            $res['boundToObjectId'] = $this->boundToObjectId;
        }
        if (null !== $this->boundToObjectType) {
            $res['boundToObjectType'] = $this->boundToObjectType;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->taskflowId) {
            $res['taskflowId'] = $this->taskflowId;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
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
        if (isset($map['boundToObjectId'])) {
            $model->boundToObjectId = $map['boundToObjectId'];
        }
        if (isset($map['boundToObjectType'])) {
            $model->boundToObjectType = $map['boundToObjectType'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['taskflowId'])) {
            $model->taskflowId = $map['taskflowId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
