<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryIntegratedTodoTaskRequest extends Model
{
    /**
     * @example 1660036833411
     *
     * @var int
     */
    public $createBefore;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 20
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example manager001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'createBefore' => 'createBefore',
        'pageNumber'   => 'pageNumber',
        'pageSize'     => 'pageSize',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createBefore) {
            $res['createBefore'] = $this->createBefore;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryIntegratedTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createBefore'])) {
            $model->createBefore = $map['createBefore'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
