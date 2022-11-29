<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListAllDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 分页大小
     * 50
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标, 首次拉取不用传
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 排序规则, 升降或降序
     * ASC
     * @var string
     */
    public $order;

    /**
     * @description 是否获取文件缩略图临时链接
     * false
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
