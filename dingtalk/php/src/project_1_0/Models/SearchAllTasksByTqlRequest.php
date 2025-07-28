<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchAllTasksByTqlRequest extends Model
{
    /**
     * @example 50
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example DXF1ZXJ5QW5kRmV0Y2gBAAAAAAKC9p4WVjNKbUstaldRX3lOOHNBbElzcjA5Zw==
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example isDone = false
     *
     * @var string
     */
    public $tql;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'tql' => 'tql',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->tql) {
            $res['tql'] = $this->tql;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchAllTasksByTqlRequest
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
        if (isset($map['tql'])) {
            $model->tql = $map['tql'];
        }

        return $model;
    }
}
