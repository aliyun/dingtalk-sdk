<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionResponseBody\list_;
use AlibabaCloud\Tea\Model;

class PageListActionResponseBody extends Model
{
    /**
     * @description nextCursor
     *
     * @var int
     */
    public $nextCursor;

    /**
     * @description total
     *
     * @var int
     */
    public $total;

    /**
     * @description list
     *
     * @var list_[]
     */
    public $list;
    protected $_name = [
        'nextCursor' => 'nextCursor',
        'total'      => 'total',
        'list'       => 'list',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageListActionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = [];
                $n           = 0;
                foreach ($map['list'] as $item) {
                    $model->list[$n++] = null !== $item ? list_::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
