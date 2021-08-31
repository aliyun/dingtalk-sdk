<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllTracksRequest extends Model
{
    /**
     * @description 分页游标
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页size
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 排序
     *
     * @var string
     */
    public $order;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'order'      => 'order',
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
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllTracksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
