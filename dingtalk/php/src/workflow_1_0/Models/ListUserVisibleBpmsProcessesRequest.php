<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListUserVisibleBpmsProcessesRequest extends Model
{
    /**
     * @description 分页大小，最大可设置成100。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，从0开始。根据返回结果里的nextToken是否为空来判断是否还有下一页，且再次调用时设置成nextToken的最新值。
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 要查询的员工的userid。不传表示查询企业下所有审批表单。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserVisibleBpmsProcessesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
