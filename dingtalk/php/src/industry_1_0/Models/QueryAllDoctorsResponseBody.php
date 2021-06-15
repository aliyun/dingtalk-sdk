<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsResponseBody\content;
use AlibabaCloud\Tea\Model;

class QueryAllDoctorsResponseBody extends Model
{
    /**
     * @description 人员列表
     *
     * @var content[]
     */
    public $content;

    /**
     * @description 总页数
     *
     * @var int
     */
    public $totalPages;

    /**
     * @description 数据总量
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description 当前页码
     *
     * @var int
     */
    public $currentPage;
    protected $_name = [
        'content'     => 'content',
        'totalPages'  => 'totalPages',
        'totalCount'  => 'totalCount',
        'currentPage' => 'currentPage',
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
        if (null !== $this->totalPages) {
            $res['totalPages'] = $this->totalPages;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllDoctorsResponseBody
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
        if (isset($map['totalPages'])) {
            $model->totalPages = $map['totalPages'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }

        return $model;
    }
}
