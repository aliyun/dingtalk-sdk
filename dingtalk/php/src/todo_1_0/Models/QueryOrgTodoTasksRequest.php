<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgTodoTasksRequest extends Model
{
    /**
     * @var bool
     */
    public $isDone;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string[][]
     */
    public $roleTypes;

    /**
     * @example TODO
     *
     * @var string
     */
    public $todoType;
    protected $_name = [
        'isDone' => 'isDone',
        'nextToken' => 'nextToken',
        'roleTypes' => 'roleTypes',
        'todoType' => 'todoType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->todoType) {
            $res['todoType'] = $this->todoType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgTodoTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['roleTypes'])) {
            if (!empty($map['roleTypes'])) {
                $model->roleTypes = $map['roleTypes'];
            }
        }
        if (isset($map['todoType'])) {
            $model->todoType = $map['todoType'];
        }

        return $model;
    }
}
