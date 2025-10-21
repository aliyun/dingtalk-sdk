<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOrgInnerGroupInfoByCursorPageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $count;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $cursor;

    /**
     * @var bool
     */
    public $forward;
    protected $_name = [
        'count' => 'count',
        'cursor' => 'cursor',
        'forward' => 'forward',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->forward) {
            $res['forward'] = $this->forward;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchOrgInnerGroupInfoByCursorPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['forward'])) {
            $model->forward = $map['forward'];
        }

        return $model;
    }
}
