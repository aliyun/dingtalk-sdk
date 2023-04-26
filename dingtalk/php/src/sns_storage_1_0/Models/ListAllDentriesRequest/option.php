<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListAllDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
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
     * @example true
     *
     * @var bool
     */
    public $withThumbnail;
    protected $_name = [
        'maxResults'    => 'maxResults',
        'nextToken'     => 'nextToken',
        'order'         => 'order',
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
        if (null !== $this->withThumbnail) {
            $res['withThumbnail'] = $this->withThumbnail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
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
        if (isset($map['withThumbnail'])) {
            $model->withThumbnail = $map['withThumbnail'];
        }

        return $model;
    }
}
