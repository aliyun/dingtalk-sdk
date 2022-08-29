<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryIntegratedTodoTaskRequest extends Model
{
    /**
     * @description 在此时间戳之前创建的
     *
     * @var int
     */
    public $createBefore;

    /**
     * @description 第几页，取值范围为 1 ≤ page ≤ 1000
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小，取值范围为 1 ≤ pageSize ≤ 40
     *
     * @var int
     */
    public $pageSize;

    /**
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
