<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content;
use AlibabaCloud\Tea\Model;

class QueryAllDepartmentResponseBody extends Model
{
    /**
     * @var content[]
     */
    public $content;

    /**
     * @example 1
     *
     * @var int
     */
    public $currentPage;

    /**
     * @example 100
     *
     * @var int
     */
    public $totalCount;

    /**
     * @example 10
     *
     * @var int
     */
    public $totalPages;
    protected $_name = [
        'content'     => 'content',
        'currentPage' => 'currentPage',
        'totalCount'  => 'totalCount',
        'totalPages'  => 'totalPages',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = [];
            if (null !== $this->content && \is_array($this->content)) {
                $n = 0;
                foreach ($this->content as $item) {
                    $res['content'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->totalPages) {
            $res['totalPages'] = $this->totalPages;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllDepartmentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            if (!empty($map['content'])) {
                $model->content = [];
                $n              = 0;
                foreach ($map['content'] as $item) {
                    $model->content[$n++] = null !== $item ? content::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['totalPages'])) {
            $model->totalPages = $map['totalPages'];
        }

        return $model;
    }
}
