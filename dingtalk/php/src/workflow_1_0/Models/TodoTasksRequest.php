<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class TodoTasksRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example staffId123
     *
     * @var string
     */
    public $actionerUserId;

    /**
     * @description This parameter is required.
     *
     * @example manager123
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @description This parameter is required.
     *
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'actionerUserId' => 'actionerUserId',
        'managerUserId'  => 'managerUserId',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionerUserId) {
            $res['actionerUserId'] = $this->actionerUserId;
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TodoTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionerUserId'])) {
            $model->actionerUserId = $map['actionerUserId'];
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
