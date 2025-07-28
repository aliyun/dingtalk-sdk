<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskFlowResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 62c25e3b376ecxxxxxxx
     *
     * @var string
     */
    public $boundToObjectId;

    /**
     * @example project
     *
     * @var string
     */
    public $boundToObjectType;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 07151530111xxxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example false
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @example 工作流1
     *
     * @var string
     */
    public $name;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskflowId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'boundToObjectId' => 'boundToObjectId',
        'boundToObjectType' => 'boundToObjectType',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'isDeleted' => 'isDeleted',
        'name' => 'name',
        'taskflowId' => 'taskflowId',
        'updated' => 'updated',
    ];

    public function validate() {}

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
