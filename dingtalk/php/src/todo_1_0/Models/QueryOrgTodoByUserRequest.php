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
     * @var string
     */
    public $nextToken;

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
    protected $_name = [
        'fromDueTime' => 'fromDueTime',
        'isDone'      => 'isDone',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'roleTypes'   => 'roleTypes',
        'subject'     => 'subject',
        'toDueTime'   => 'toDueTime',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
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

        return $model;
    }
}
