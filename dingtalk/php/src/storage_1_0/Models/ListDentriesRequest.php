<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListDentriesRequest extends Model
{
    /**
     * @example 30
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example DESC
     *
     * @var string
     */
    public $order;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $orderBy;

    /**
     * @example parent_id
     *
     * @var string
     */
    public $parentId;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;

    /**
     * @example true
     *
     * @var bool
     */
    public $withThumbnail;
    protected $_name = [
        'maxResults'    => 'maxResults',
        'nextToken'     => 'nextToken',
        'order'         => 'order',
        'orderBy'       => 'orderBy',
        'parentId'      => 'parentId',
        'unionId'       => 'unionId',
        'withThumbnail' => 'withThumbnail',
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
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->withThumbnail) {
            $res['withThumbnail'] = $this->withThumbnail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDentriesRequest
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
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['withThumbnail'])) {
            $model->withThumbnail = $map['withThumbnail'];
        }

        return $model;
    }
}
