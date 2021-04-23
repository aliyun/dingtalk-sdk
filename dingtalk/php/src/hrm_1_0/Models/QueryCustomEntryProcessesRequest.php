<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCustomEntryProcessesRequest extends Model
{
    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description 偏移量
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 最大值
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'operateUserId' => 'operateUserId',
        'nextToken'     => 'nextToken',
        'maxResults'    => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCustomEntryProcessesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }

        return $model;
    }
}
