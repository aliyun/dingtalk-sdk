<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgTodoByUserRequest extends Model
{
    /**
     * @var int
     */
    public $fromDueTime;

    /**
     * @var bool
     */
    public $isDone;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var bool
     */
    public $needPersonalTodo;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $orderBy;

    /**
     * @var string
     */
    public $orderDirection;

    /**
     * @var string[][]
     */
    public $roleTypes;

    /**
     * @var string
     */
    public $subject;

    /**
     * @var int
     */
    public $toDueTime;

    /**
     * @example TODO
     *
     * @var string
     */
    public $todoType;
    protected $_name = [
        'fromDueTime' => 'fromDueTime',
        'isDone' => 'isDone',
        'maxResults' => 'maxResults',
        'needPersonalTodo' => 'needPersonalTodo',
        'nextToken' => 'nextToken',
        'orderBy' => 'orderBy',
        'orderDirection' => 'orderDirection',
        'roleTypes' => 'roleTypes',
        'subject' => 'subject',
        'toDueTime' => 'toDueTime',
        'todoType' => 'todoType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fromDueTime) {
            $res['fromDueTime'] = $this->fromDueTime;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->needPersonalTodo) {
            $res['needPersonalTodo'] = $this->needPersonalTodo;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->orderDirection) {
            $res['orderDirection'] = $this->orderDirection;
        }
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->toDueTime) {
            $res['toDueTime'] = $this->toDueTime;
        }
        if (null !== $this->todoType) {
            $res['todoType'] = $this->todoType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgTodoByUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fromDueTime'])) {
            $model->fromDueTime = $map['fromDueTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['needPersonalTodo'])) {
            $model->needPersonalTodo = $map['needPersonalTodo'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['orderDirection'])) {
            $model->orderDirection = $map['orderDirection'];
        }
        if (isset($map['roleTypes'])) {
            if (!empty($map['roleTypes'])) {
                $model->roleTypes = $map['roleTypes'];
            }
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['toDueTime'])) {
            $model->toDueTime = $map['toDueTime'];
        }
        if (isset($map['todoType'])) {
            $model->todoType = $map['todoType'];
        }

        return $model;
    }
}
