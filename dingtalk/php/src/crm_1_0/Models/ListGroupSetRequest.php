<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListGroupSetRequest extends Model
{
    /**
     * @description 每页返回的结果集个数
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 第一页不传，下一页传入上一页返回的nextToken
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 查询DSL
     *
     * @var string
     */
    public $queryDsl;

    /**
     * @description 关系类型
     *
     * @var string
     */
    public $relationType;
    protected $_name = [
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'queryDsl'     => 'queryDsl',
        'relationType' => 'relationType',
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
        if (null !== $this->queryDsl) {
            $res['queryDsl'] = $this->queryDsl;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListGroupSetRequest
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
        if (isset($map['queryDsl'])) {
            $model->queryDsl = $map['queryDsl'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}
