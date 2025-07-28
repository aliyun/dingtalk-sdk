<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchAllTasksByTqlResponseBody extends Model
{
    /**
     * @example f279e812-e431-428d-846d-cxxxxxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 60BEE277-347B-1D5E-B6A4-E90788531911
     *
     * @var string
     */
    public $requestId;

    /**
     * @var string[]
     */
    public $result;

    /**
     * @example 1
     *
     * @var int
     */
    public $totalSize;
    protected $_name = [
        'nextToken' => 'nextToken',
        'requestId' => 'requestId',
        'result' => 'result',
        'totalSize' => 'totalSize',
    ];

    public function validate() {}

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
     * @return SearchAllTasksByTqlResponseBody
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
