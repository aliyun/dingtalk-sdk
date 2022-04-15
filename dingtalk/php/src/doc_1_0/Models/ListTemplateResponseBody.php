<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListTemplateResponseBody\templateList;
use AlibabaCloud\Tea\Model;

class ListTemplateResponseBody extends Model
{
    /**
     * @description 是否还有更多模版
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 后续结果的偏移
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 模版信息列表
     *
     * @var templateList[]
     */
    public $templateList;
    protected $_name = [
        'hasMore'      => 'hasMore',
        'nextToken'    => 'nextToken',
        'templateList' => 'templateList',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->templateList) {
            $res['templateList'] = [];
            if (null !== $this->templateList && \is_array($this->templateList)) {
                $n = 0;
                foreach ($this->templateList as $item) {
                    $res['templateList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['templateList'])) {
            if (!empty($map['templateList'])) {
                $model->templateList = [];
                $n                   = 0;
                foreach ($map['templateList'] as $item) {
                    $model->templateList[$n++] = null !== $item ? templateList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
