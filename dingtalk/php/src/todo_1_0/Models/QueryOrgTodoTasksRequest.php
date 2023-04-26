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
    protected $_name = [
        'isDone'    => 'isDone',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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

        return $model;
    }
}
