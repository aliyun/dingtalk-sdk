<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdResponseBody\deptList;
use AlibabaCloud\Tea\Model;

class GetDeptsByOrgIdResponseBody extends Model
{
    /**
     * @description deptList
     *
     * @var deptList[]
     */
    public $deptList;

    /**
     * @description hasMore
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @description nextCursor
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'deptList'   => 'deptList',
        'hasMore'    => 'hasMore',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptList) {
            $res['deptList'] = [];
            if (null !== $this->deptList && \is_array($this->deptList)) {
                $n = 0;
                foreach ($this->deptList as $item) {
                    $res['deptList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeptsByOrgIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptList'])) {
            if (!empty($map['deptList'])) {
                $model->deptList = [];
                $n               = 0;
                foreach ($map['deptList'] as $item) {
                    $model->deptList[$n++] = null !== $item ? deptList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
