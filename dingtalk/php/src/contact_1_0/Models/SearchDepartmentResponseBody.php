<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchDepartmentResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $totalCount;

    /**
     * @var int[]
     */
    public $list;
    protected $_name = [
        'hasMore'    => 'hasMore',
        'totalCount' => 'totalCount',
        'list'       => 'list',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->list) {
            $res['list'] = $this->list;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchDepartmentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = $map['list'];
            }
        }

        return $model;
    }
}
