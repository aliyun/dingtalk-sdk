<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogResponseBody\content;
use AlibabaCloud\Tea\Model;

class QueryBizOptLogResponseBody extends Model
{
    /**
     * @description content
     *
     * @var content[]
     */
    public $content;

    /**
     * @description 下次拉取数据的起始位置
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'content'   => 'content',
        'nextToken' => 'nextToken',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBizOptLogResponseBody
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
