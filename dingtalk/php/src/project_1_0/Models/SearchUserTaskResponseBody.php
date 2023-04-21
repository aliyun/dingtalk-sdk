<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchUserTaskResponseBody extends Model
{
    /**
     * @description 分页标，供分页使用，下一页token。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 请求 ID，请求异常时可提供此 ID，进行问题排查。
     *
     * @var string
     */
    public $requestId;

    /**
     * @description 任务ID列表。
     *
     * @var string[]
     */
    public $result;

    /**
     * @description 任务总数。
     *
     * @var int
     */
    public $totalSize;
    protected $_name = [
        'nextToken' => 'nextToken',
        'requestId' => 'requestId',
        'result'    => 'result',
        'totalSize' => 'totalSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->totalSize) {
            $res['totalSize'] = $this->totalSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchUserTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['result'])) {
            if (!empty($map['result'])) {
                $model->result = $map['result'];
            }
        }
        if (isset($map['totalSize'])) {
            $model->totalSize = $map['totalSize'];
        }

        return $model;
    }
}
