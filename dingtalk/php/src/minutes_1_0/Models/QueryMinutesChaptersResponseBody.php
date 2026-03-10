<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesChaptersResponseBody\chapterList;
use AlibabaCloud\Tea\Model;

class QueryMinutesChaptersResponseBody extends Model
{
    /**
     * @var chapterList[]
     */
    public $chapterList;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'chapterList' => 'chapterList',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chapterList) {
            $res['chapterList'] = [];
            if (null !== $this->chapterList && \is_array($this->chapterList)) {
                $n = 0;
                foreach ($this->chapterList as $item) {
                    $res['chapterList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMinutesChaptersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chapterList'])) {
            if (!empty($map['chapterList'])) {
                $model->chapterList = [];
                $n = 0;
                foreach ($map['chapterList'] as $item) {
                    $model->chapterList[$n++] = null !== $item ? chapterList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
